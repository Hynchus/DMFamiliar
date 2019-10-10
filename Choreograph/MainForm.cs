using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Choreograph
{
    public partial class MainForm : Form
    {
        bool close_to_tray = true;
        Form display_form = null;
        DataView characterlist_source = null;
        Random seed = new Random();


        private void enforce_inactivecharacters_filter()
        {
            foreach (InactiveCharacterControl control in inactivecharacterspanel.Controls)
            {
                control.filter = filtertb.Text;
            }
        }

        private void start_subscriptions()
        {
            characterlist_source = Storage.characters.AsDataView();
            characterlist_source.Sort = "id";
            enforce_inactivecharacters_filter();
            Storage.characters.RowChanged += handle_characters_change;
            Storage.active_ids.ListChanged += handle_actives_change;
            Storage.characters.ColumnChanged += character_property_changed;
        }

        private void stop_subscriptions()
        {
            Storage.characters.RowChanged -= handle_characters_change;
            Storage.active_ids.ListChanged -= handle_actives_change;
            Storage.characters.ColumnChanged -= character_property_changed;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void show_display()
        {
            if (display_form != null)
            {
                display_form.Close();
            }
            display_form = new InitiativeDisplayForm(hide_display);
            displaybtn.Text = "Hide Display";
            displaybtn.BackColor = Color.Violet;
            display_form.Show();
            Focus();
        }

        private void hide_display()
        {
            if (display_form != null)
            {
                try
                {
                    display_form.Close();
                }
                catch (Exception)
                {
                    // already closed, can ignore
                }
            }
            display_form = null;
            displaybtn.Text = "Show Display";
            displaybtn.BackColor = Color.Yellow;
        }

        private void toggle_display()
        {
            if (display_form == null)
            {
                show_display();
            }
            else
            {
                hide_display();
            }
            this.Focus();
        }

        private void new_character_click(object sender, EventArgs e)
        {
            DataRow new_character = Storage.characters.NewRow();
            new_character["id"] = Guid.NewGuid().ToString();
            new_character["name"] = "";
            Storage.characters.Rows.Add(new_character);
            Storage.characters.AcceptChanges();
            Storage.active_ids.Add((string)new_character["id"]);
        }

        private void clear_active_characters_click(object sender, EventArgs e)
        {
            relinquish_focus();
            Storage.active_ids.Clear();
        }

        private void displaybtn_Click(object sender, EventArgs e)
        {
            toggle_display();
        }

        private void filtertb_TextChanged(object sender, EventArgs e)
        {
            enforce_inactivecharacters_filter();
        }

        private void sort_activecharacterspanel()
        {
            activecharacterspanel.SuspendLayout();
            CharacterEditControl[] ordered_controls = activecharacterspanel.Controls.OfType<CharacterEditControl>().OrderByDescending(
                c => (string)Storage.characters.Rows.Find(c.id)["name"]
                ).ToArray();
            for (int i = 0; i < activecharacterspanel.Controls.Count; i++)
            {
                activecharacterspanel.Controls.SetChildIndex(ordered_controls[i], i);
            }
            activecharacterspanel.ResumeLayout();
        }

        private void sort_inactivecharacterspanel()
        {
            inactivecharacterspanel.SuspendLayout();
            InactiveCharacterControl[] ordered_controls = inactivecharacterspanel.Controls.OfType<InactiveCharacterControl>().OrderByDescending(
                c => (string)Storage.characters.Rows.Find(c.id)["name"]
                ).ToArray();
            for(int i = 0; i < inactivecharacterspanel.Controls.Count; i++)
            {
                inactivecharacterspanel.Controls.SetChildIndex(ordered_controls[i], i);
            }
            inactivecharacterspanel.ResumeLayout();
        }

        private void character_property_changed(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName == "name")
            {
                sort_activecharacterspanel();
                sort_inactivecharacterspanel();
            }
        }

        private CharacterEditControl create_active_control(string active_id)
        {
            CharacterEditControl new_control = new CharacterEditControl(relinquish_focus, active_id);
            new_control.Dock = DockStyle.Top;
            return new_control;
        }

        private void add_active_control(string active_id, bool sort = true)
        {
            CharacterEditControl new_control = create_active_control(active_id);
            activecharacterspanel.Controls.Add(new_control);
            if (sort)
            {
                sort_activecharacterspanel();
            }
        }

        private InactiveCharacterControl create_inactive_control(string id)
        {
            InactiveCharacterControl new_control = new InactiveCharacterControl(relinquish_focus, id);
            new_control.Dock = DockStyle.Top;
            return new_control;
        }

        private void add_inactive_control(string id, bool sort = true)
        {
            InactiveCharacterControl new_control = create_inactive_control(id);
            inactivecharacterspanel.Controls.Add(new_control);
            if (sort)
            {
                sort_inactivecharacterspanel();
            }
        }

        private void purge_active_controls()
        {
            foreach (CharacterEditControl control in activecharacterspanel.Controls)
            {
                if (!Storage.active_ids.Contains(control.id))
                {
                    activecharacterspanel.Controls.Remove(control);
                    DataRow character = Storage.characters.Rows.Find(control.id);
                    if (((string)character["name"]).Trim() == "")
                    {
                        Storage.characters.Rows.Remove(character);
                        Storage.characters.AcceptChanges();
                    }
                }
            }
        }

        private void purge_inactive_controls()
        {
            foreach (InactiveCharacterControl control in inactivecharacterspanel.Controls)
            {
                if (Storage.active_ids.Contains(control.id))
                {
                    inactivecharacterspanel.Controls.Remove(control);
                }
            }
        }

        private void handle_characters_change(object sender, DataRowChangeEventArgs e)
        {
            switch (e.Action)
            {
                case DataRowAction.Add:
                    string id = (string)e.Row["id"];
                    add_inactive_control(id);
                    var tmp = characterlist_source.Find(id);
                    break;
                default:
                    break;
            }
        }

        private void handle_actives_change(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    add_active_control(Storage.active_ids[e.NewIndex]);
                    enforce_inactivecharacters_filter();
                    break;
                case ListChangedType.ItemDeleted:
                    purge_active_controls();
                    enforce_inactivecharacters_filter();
                    break;
                case ListChangedType.Reset:
                    Storage.purge_characters();
                    load_active_controls();
                    load_inactive_controls();
                    break;
                default:
                    break;
            }
        }

        private void load_layout()
        {
            if (!Properties.Settings.Default.LoadMainFormSettings) { return; }
            Location = Properties.Settings.Default.MainFormLocation;
            Size = Properties.Settings.Default.MainFormSize;
        }

        private void load_active_controls()
        {
            List<CharacterEditControl> new_controls = new List<CharacterEditControl>();
            foreach(string active_id in Storage.active_ids)
            {
                new_controls.Add(create_active_control(active_id));
            }
            activecharacterspanel.Controls.Clear();
            activecharacterspanel.Controls.AddRange(new_controls.ToArray());
            sort_activecharacterspanel();
        }

        private void load_inactive_controls()
        {
            List<InactiveCharacterControl> new_controls = new List<InactiveCharacterControl>();
            foreach (DataRow character in Storage.characters.Rows)
            {
                new_controls.Add(create_inactive_control((string)character["id"]));
            }
            inactivecharacterspanel.Controls.Clear();
            inactivecharacterspanel.Controls.AddRange(new_controls.ToArray());
            sort_inactivecharacterspanel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SuspendLayout();
            Storage.load_storage();
            start_subscriptions();
            load_layout();
            load_inactive_controls();
            load_active_controls();
            filtertb.Unfocus = relinquish_focus;
            filtertb.Text = "";
            ResumeLayout();
        }

        private void save_layout()
        {
            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.MainFormLocation = Location;
                Properties.Settings.Default.MainFormSize = Size;
                Properties.Settings.Default.MainSplitterDistance = splitContainer1.SplitterDistance;
            }
            Properties.Settings.Default.ShowDisplay = (display_form != null);
            Properties.Settings.Default.LoadMainFormSettings = true;
            Properties.Settings.Default.Save();
        }

        public void Terminate()
        {
            close_to_tray = false;
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            relinquish_focus();
            save_layout();
            if (!Storage.save_storage())
            {
                if (MessageBox.Show("Failed while writing data to storage.\nThis may be due to folder permissions.\n\nContinue closing the application?", "Write Error", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (close_to_tray)
                {
                    e.Cancel = true;
                    Hide();
                    return;
                }
                hide_display();
            }
            stop_subscriptions();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                activecharactersmenustrip.Show(MousePosition);
            }
        }

        private int roll_initiative(int modifier)
        {
            return seed.Next(1, 21) + modifier;
        }

        private void rollbtn_Click(object sender, EventArgs e)
        {
            foreach (DataRow character in Storage.characters.Rows)
            {
                if ((bool)character["locked"]) { continue; }
                if (Storage.active_ids.Contains(character["id"]))
                {
                    character["roll"] = roll_initiative((int)character["mod"]);
                }
            }
            Storage.characters.AcceptChanges();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            relinquish_focus();
            if (Properties.Settings.Default.MainSplitterDistance >= 0)
            {
                splitContainer1.SplitterDistance = Properties.Settings.Default.MainSplitterDistance;
            }
            if (Properties.Settings.Default.ShowDisplay)
            {
                show_display();
            }
        }

        private void relinquish_focus()
        {
            if (Storage.active_ids.Count <= 0)
            {
                newbtn.Focus();
            }
            else
            {
                rollbtn.Focus();
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            relinquish_focus();
            if (e.Button == MouseButtons.Right)
            {
                // Nothing to show on menu at the moment
                //menustrip.Show(MousePosition);
            }
        }

        // Bubbling. There doesn't seem to be an option otherwise...
        private void pass_mouseclick_to_form(object sender, MouseEventArgs e)
        {
            MainForm_MouseClick(sender, e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Terminate();
        }

        private void show_mainform()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            Show();
            BringToFront();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_mainform();
        }

        private void notifyIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            show_mainform();
        }
    }
}
