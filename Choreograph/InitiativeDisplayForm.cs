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
                    leftborder.Cursor = Cursors.Default;
                    rightborder.Cursor = Cursors.Default;
                    lockDisplayToolStripMenuItem.Text = "Unlock Display";
                }
                else
                {
                    leftborder.Cursor = Cursors.SizeWE;
                    rightborder.Cursor = Cursors.SizeWE;
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
                    label.ForeColor = BackColor;
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

        private void refresh_title_text()
        {
            SuspendLayout();
            titlelbl.Text = Storage.settings.TitleText;
            titlelbl.Dock = DockStyle.Bottom;
            titlelbl.Font = Storage.settings.TitleFont;
            titlelbl.ForeColor = Storage.settings.TitleFontColour;
            if (Storage.settings.TitleText.Trim() == "")
            {
                titlelbl.Size = new Size(titlelbl.Size.Width, 0);
            }
            else
            {
                titlelbl.Size = new Size(titlelbl.Size.Width, (int)(titlelbl.Font.Size * 2));
            }
            Refresh();
            ResumeLayout();
        }

        private void update_border_opacity()
        {
            Image updated_border = Utilities.SetImageOpacity(Properties.Resources.border, Storage.settings.BorderOpacity);
            leftborder.BackgroundImage = updated_border;
            topborder.BackgroundImage = updated_border;
            rightborder.BackgroundImage = updated_border;
            bottomborder.BackgroundImage = updated_border;
        }

        private void load_cosmetics()
        {
            refresh_title_text();
            titlelbl.ForeColor = Storage.settings.TitleFontColour;
            BackColor = Storage.settings.BackgroundColour;
            update_border_opacity();
            // Gets erased when I put this directly in designer file, so here it goes
            Controls.SetChildIndex(topborder, 0);
            Controls.SetChildIndex(rightborder, 0);
            Controls.SetChildIndex(bottomborder, 0);
            Controls.SetChildIndex(leftborder, 0);
        }

        private void change_characters_font(Font font, Color font_colour)
        {
            foreach (Control character_control in characterlistpanel.Controls)
            {
                character_control.Font = font;
                character_control.ForeColor = font_colour;
            }
        }

        // Have to do this manually because the Bindings aren't notifying; I can't figure out why
        private void handle_settings_changed(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "DisplayTitleText":
                    titlelbl.Text = Storage.settings.TitleText;
                    titletextbox.Text = Storage.settings.TitleText;
                    refresh_title_text();
                    break;
                case "DisplayTitleFont":
                    refresh_title_text();
                    break;
                case "DisplayTitleFontColour":
                    titlelbl.ForeColor = Storage.settings.TitleFontColour;
                    break;
                case "DisplayCharactersFont":
                case "DisplayCharactersFontColour":
                    change_characters_font(Storage.settings.CharactersFont, Storage.settings.CharactersFontColour);
                    break;
                case "DisplayBackgroundColour":
                    BackColor = Storage.settings.BackgroundColour;
                    break;
                case "DisplayBorderOpacity":
                    update_border_opacity();
                    break;
            }
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
            load_cosmetics();
            Storage.settings.PropertyChanged += handle_settings_changed;
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
            if (e.Button != MouseButtons.Left) { return; }
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
            character_label.Margin = new Padding(0, 10, 0, 0);
            character_label.BackColor = Color.Transparent;
            character_label.Dock = DockStyle.Bottom;
            character_label.Font = Storage.settings.CharactersFont;
            character_label.ForeColor = Storage.settings.CharactersFontColour;
            character_label.Size = new Size(character_label.Size.Width, (int)(character_label.Font.Size * 2));
            character_label.TextAlign = ContentAlignment.TopCenter;
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

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Storage.settings.TitleFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Storage.settings.TitleFont = fontDialog1.Font;
            }
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Storage.settings.CharactersFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Storage.settings.CharactersFont = fontDialog1.Font;
            }
            populate_list();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Storage.settings.BackgroundColour;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Storage.settings.BackgroundColour = colorDialog1.Color;
            }
        }

        private void titletextbox_TextChanged(object sender, EventArgs e)
        {
            Storage.settings.TitleText = titletextbox.Text;
        }

        private void colourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            colorDialog1.Color = Storage.settings.TitleFontColour;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Storage.settings.TitleFontColour = colorDialog1.Color;
            }
        }

        private void colourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Storage.settings.CharactersFontColour;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Storage.settings.CharactersFontColour = colorDialog1.Color;
            }
        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                contextMenuStrip1.Close();
                e.Handled = true;
            }
        }

        private void opacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void on_value_change(int value)
            {
                Storage.settings.BorderOpacity = (float)((float)value * 0.01);
            }
            float old_value = Storage.settings.BorderOpacity;
            SliderForm slider_form = new SliderForm(on_value_change, (int)(Storage.settings.BorderOpacity * 100), "Border Opacity");
            {
                if (slider_form.ShowDialog() != DialogResult.OK)
                {
                    Storage.settings.BorderOpacity = old_value;
                }
            }
        }
    }
}