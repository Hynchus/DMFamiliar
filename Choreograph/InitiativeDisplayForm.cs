using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choreograph
{
    public partial class InitiativeDisplayForm : Form
    {
        public delegate void CloseDisplayFunction();

        // The character name labels are bottom docked, so the panel holding them has
        // its controls in the reverse order. We have to reverse the list when traversing it.
        CloseDisplayFunction close_display;
        Size ACTUAL_MINIMUM_SIZE;
        int STARTING_HEIGHT = 0;
        Color FOCUSED_BACKCOLOUR = Color.AliceBlue;
        bool dragging = false;
        bool drag_happened = false;
        bool resizing = false;
        Point drag_start = new Point(0, 0);
        Size resize_start = new Size(0, 0);
        Point mouse_start = new Point(0, 0);
        Size previous_minimum_size = new Size(0, 0);
        string focused_character = null;
        Color focused_character_previous_backcolour;
        Color focused_character_previous_forecolour;
        bool _transform_locked = false;
        bool transform_locked {
            get { return _transform_locked; }
            set 
            {
                _transform_locked = value;
                if (value)
                {
                    leftresizepanel.Cursor = Cursors.Default;
                    rightresizepanel.Cursor = Cursors.Default;
                    lockDisplayToolStripMenuItem.Text = "Unlock Display";
                }
                else
                {
                    leftresizepanel.Cursor = Cursors.SizeWE;
                    rightresizepanel.Cursor = Cursors.SizeWE;
                    lockDisplayToolStripMenuItem.Text = "Lock Display";
                }
            }
        }

        HashSet<Keys> pressed_keys = new HashSet<Keys>();
        LowLevelKeyboardHook keyboard_hook;

        DataView characters_view;


        protected override bool ShowWithoutActivation {
            get { return true; }
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams baseParams = base.CreateParams;

                const int WS_EX_NOACTIVATE = 0x08000000;
                const int WS_EX_TOOLWINDOW = 0x00000080;
                baseParams.ExStyle |= (int)(WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW);

                return baseParams;
            }
        }


        private void focus_character(string name)
        {
            string previous_focused = focused_character;
            foreach (Label label in characterlistpanel.Controls.OfType<Label>())
            {
                if (label.Text == previous_focused)
                {
                    label.BackColor = focused_character_previous_backcolour;
                    label.ForeColor = focused_character_previous_forecolour;
                }
                if (label.Text == name)
                {
                    focused_character_previous_backcolour = label.BackColor;
                    focused_character_previous_forecolour = label.ForeColor;
                    label.BackColor = focused_character_previous_forecolour;
                    label.ForeColor = focused_character_previous_backcolour;
                    focused_character = name;
                }
            }
            if (focused_character != name)
            {
                focused_character = null;
            }
        }

        private string get_next_character()
        {
            if (characterlistpanel.Controls.Count <= 0) { return null; }
            if (focused_character == null)
            {
                return ((Label)characterlistpanel.Controls[0]).Text;
            }
            bool flag = false;
            for (int i = 0; i < characterlistpanel.Controls.Count; i++)
            {
                if (flag)
                {
                    return ((Label)characterlistpanel.Controls[i]).Text;
                }
                if (((Label)characterlistpanel.Controls[i]).Text == focused_character)
                {
                    flag = true;
                }
            }
            return ((Label)characterlistpanel.Controls[0]).Text;
        }

        private void update_focus()
        {
            focus_character(get_next_character());
        }

        private void populate_list()
        {
            SuspendLayout();
            List<Control> tmp = new List<Control>();
            foreach (DataRowView character in characters_view)
            {
                tmp.Add(create_character_label((string)character["name"]));
            }
            tmp.Reverse();
            focused_character = null;
            characterlistpanel.Controls.Clear();
            characterlistpanel.Controls.AddRange(tmp.ToArray());
            update_filter();
            ResumeLayout();
        }

        private void update_list(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    populate_list();
                    break;
                default:
                    break;
            }
        }

        private void update_filter()
        {
            if (Storage.active_ids.Count <= 0)
            {
                characters_view.RowFilter = "1 = 0";
            }
            else
            {
                characters_view.RowFilter = string.Join(" AND ",
                    "TRIM(name) <> ''",

                    "(" + string.Join(" OR ", 
                        Storage.active_ids.Select(
                            i => string.Format("{0} = '{1}'", "id", i)
                        )
                        ) + ")"
                    );
            }
        }

        private void update_filter(object sender, EventArgs e)
        {
            update_filter();
        }

        private void check_key_combos()
        {
            if (pressed_keys.Contains(Keys.LControlKey) && pressed_keys.Contains(Keys.Space))
            {
                update_focus();
            }
        }

        private void global_key_pressed(object sender, Keys e)
        {
            pressed_keys.Add(e);
            check_key_combos();
        }

        private void global_key_unpressed(object sender, Keys e)
        {
            pressed_keys.Remove(e);
        }

        private void setup()
        {
            STARTING_HEIGHT = Size.Height;
            ACTUAL_MINIMUM_SIZE = MinimumSize;
            characters_view = Storage.characters.AsDataView();
            update_filter();
            characters_view.Sort = "roll, mod";
            characters_view.ListChanged += update_list;
            Storage.active_ids.ListChanged += update_filter;
            keyboard_hook = new LowLevelKeyboardHook();
            keyboard_hook.OnKeyPressed += global_key_pressed;
            keyboard_hook.OnKeyUnpressed += global_key_unpressed;
            keyboard_hook.HookKeyboard();
        }

        public InitiativeDisplayForm(CloseDisplayFunction close_display)
        {
            InitializeComponent();
            this.close_display = close_display;
            setup();
            populate_list();
        }

        private void InitiativeDisplayForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (transform_locked) { return; }
            dragging = true;
            drag_start = Location;
            mouse_start = MousePosition;
        }

        private void InitiativeDisplayForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            if (!drag_happened && ClientRectangle.Contains(e.Location))
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        update_focus();
                        break;
                    case MouseButtons.Right:
                        contextMenuStrip1.Show(MousePosition);
                        break;
                }
            }
            drag_happened = false;
        }

        private void InitiativeDisplayForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) { return; }
            drag_happened = true;
            Location = new Point(drag_start.X + MousePosition.X - mouse_start.X, drag_start.Y + MousePosition.Y - mouse_start.Y);
        }

        private void InitiativeDisplayForm_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.LoadDisplayFormSettings) { return; }
            Location = Properties.Settings.Default.DisplayFormLocation;
            Size = new Size(Properties.Settings.Default.DisplayFormSize.Width, Size.Height);
            MinimumSize = new Size(Properties.Settings.Default.DisplayFormSize.Width, MinimumSize.Height);
            transform_locked = Properties.Settings.Default.DisplayFormTransformLock;
        }

        private void InitiativeDisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyboard_hook.UnHookKeyboard();
            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.DisplayFormLocation = Location;
                Properties.Settings.Default.DisplayFormSize = Size;
            }
            Properties.Settings.Default.DisplayFormTransformLock = transform_locked;
            Properties.Settings.Default.LoadDisplayFormSettings = true;
            Properties.Settings.Default.Save();
        }

        private Label create_character_label(string character_name)
        {
            Label character_label = new Label();
            character_label.Margin = new Padding(3, 10, 3, 0);
            //character_label.AutoSize = false;
            character_label.Dock = DockStyle.Bottom;
            character_label.Font = new Font("TrebuchetMS", 20);
            character_label.Size = new Size(character_label.Size.Width, (int)(character_label.Font.Size * 2));
            character_label.TextAlign = ContentAlignment.MiddleCenter;
            character_label.Text = character_name;
            character_label.MouseDown += InitiativeDisplayForm_MouseDown;
            character_label.MouseMove += InitiativeDisplayForm_MouseMove;
            character_label.MouseUp += InitiativeDisplayForm_MouseUp;

            return character_label;
        }

        private void resizepanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (transform_locked) { return; }
            resizing = true;
            drag_start = Location;
            resize_start = Size;
            mouse_start = MousePosition;
            previous_minimum_size = MinimumSize;
            MinimumSize = new Size(ACTUAL_MINIMUM_SIZE.Width, Size.Height);
            AutoSize = false;
        }

        private void rightresizepanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!resizing) { return; }
            Size = new Size(resize_start.Width + MousePosition.X - mouse_start.X, Size.Height);
        }

        private void leftresizepanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!resizing) { return; }
            int mouse_x = MousePosition.X;
            if (resize_start.Width - mouse_x + mouse_start.X < MinimumSize.Width)
            {
                mouse_x = resize_start.Width + mouse_start.X - MinimumSize.Width;
            }
            Location = new Point(drag_start.X + mouse_x - mouse_start.X, Location.Y);
            Size = new Size(resize_start.Width - mouse_x + mouse_start.X, Size.Height);
        }

        private void resizepanel_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
            MinimumSize = new Size(Size.Width, previous_minimum_size.Height);
            AutoSize = true;
        }

        private void hideDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_display();
        }

        private void lockDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transform_locked = !transform_locked;
        }
    }
}
