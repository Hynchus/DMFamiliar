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
        Size ACTUAL_MINIMUM_SIZE;
        int STARTING_HEIGHT = 0;
        bool dragging = false;
        bool resizing = false;
        Point drag_start = new Point(0, 0);
        Size resize_start = new Size(0, 0);
        Point mouse_start = new Point(0, 0);
        Size previous_minimum_size = new Size(0, 0);

        DataView characters_view;



        private void populate_list()
        {
            SuspendLayout();
            List<Control> tmp = new List<Control>();
            foreach (DataRowView character in characters_view)
            {
                tmp.Add(create_character_label((string)character["name"]));
            }
            tmp.Reverse();  // Have to do this because the list is bottom docked
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

        private void setup()
        {
            STARTING_HEIGHT = Size.Height;
            ACTUAL_MINIMUM_SIZE = MinimumSize;
            characters_view = Storage.characters.AsDataView();
            update_filter();
            characters_view.Sort = "roll, mod";
            characters_view.ListChanged += update_list;
            Storage.active_ids.ListChanged += update_filter;
        }

        public InitiativeDisplayForm()
        {
            InitializeComponent();
            setup();
            populate_list();
        }

        private void InitiativeDisplayForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            drag_start = Location;
            mouse_start = MousePosition;
        }

        private void InitiativeDisplayForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void InitiativeDisplayForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) { return; }
            Location = new Point(drag_start.X + MousePosition.X - mouse_start.X, drag_start.Y + MousePosition.Y - mouse_start.Y);
        }

        private void InitiativeDisplayForm_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.LoadDisplayFormSettings) { return; }
            Location = Properties.Settings.Default.DisplayFormLocation;
            Size = new Size(Properties.Settings.Default.DisplayFormSize.Width, Size.Height);
            MinimumSize = new Size(Properties.Settings.Default.DisplayFormSize.Width, MinimumSize.Height);
        }

        private void InitiativeDisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.DisplayFormLocation = Location;
                Properties.Settings.Default.DisplayFormSize = Size;
            }
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

    }
}
