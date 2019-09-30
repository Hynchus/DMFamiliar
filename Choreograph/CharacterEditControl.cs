using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choreograph
{
    public partial class CharacterEditControl : UserControl
    {
        private string _id;
        public string id 
        {
            get { return _id; }
            set 
            {
                _id = value;
                update_bindings();
            }
        }

        DataView character_view;



        private void not_bool(object sender, ConvertEventArgs e)
        {
            e.Value = !(bool)e.Value;
        }

        private void bool_to_lockimage(object sender, ConvertEventArgs e)
        {
            if ((bool)e.Value)
            {
                e.Value = Properties.Resources.locked;
            }
            else
            {
                e.Value = Properties.Resources.unlocked;
            }
        }

        private void lockimage_to_bool(object sender, ConvertEventArgs e)
        {
            e.Value = (e.Value == Properties.Resources.locked);
        }

        private void name_to_removeimage(object sender, ConvertEventArgs e)
        {
            if (((string)e.Value).Trim() == "")
            {
                e.Value = Properties.Resources.x;
            }
            else
            {
                e.Value = Properties.Resources.moveright;
            }
        }

        private void name_to_removetooltip(object sender, ConvertEventArgs e)
        {
            if (((string)e.Value).Trim() == "")
            {
                e.Value = "Delete unnamed character";
            }
            else
            {
                e.Value = "Remove from Active list";
            }
        }

        private void update_bindings()
        {
            character_view.RowFilter = string.Format("{0} = '{1}'", "id", id);

            nametb.DataBindings.Clear();
            nametb.DataBindings.Add(new Binding("Text", character_view, "name", false, DataSourceUpdateMode.OnPropertyChanged));
            modtb.DataBindings.Clear();
            modtb.DataBindings.Add(new Binding("Text", character_view, "mod"));
            rolltb.DataBindings.Clear();
            rolltb.DataBindings.Add(new Binding("Text", character_view, "roll"));
            Binding roll_enabled_binding = new Binding("Enabled", character_view, "locked");
            roll_enabled_binding.Format += not_bool;
            roll_enabled_binding.Parse += not_bool;
            rolltb.DataBindings.Add(roll_enabled_binding);
            lockbox.DataBindings.Clear();
            Binding lock_image_binding = new Binding("Image", character_view, "locked");
            lock_image_binding.Format += bool_to_lockimage;
            lock_image_binding.Parse += lockimage_to_bool;
            lockbox.DataBindings.Add(lock_image_binding);

            update_removebtn((string)character_view[0].Row["name"]);
        }

        private void set_remove_button()
        {
            removebtn.BackgroundImage = Properties.Resources.moveright;
        }

        private void set_delete_button()
        {
            removebtn.BackgroundImage = Properties.Resources.x;
        }

        private void update_removebtn(string name_value)
        {
            if (name_value.Trim() == "")
            {
                set_delete_button();
            }
            else
            {
                set_remove_button();
            }
        }

        private void character_property_changed(object sender, DataColumnChangeEventArgs e)
        {
            if ((string)e.Row["id"] != id) { return; }

            if (e.Column.ColumnName == "name")
            {
                update_removebtn((string)e.ProposedValue);
            }
        }

        private void setup()
        {
            InitializeComponent();
            character_view = Storage.characters.AsDataView();
            Storage.characters.ColumnChanged += character_property_changed;
        }

        public CharacterEditControl()
        {
            setup();
        }

        public CharacterEditControl(string id)
        {
            setup();
            this.id = id;
        }

        private void toggle_lock()
        {
            DataRow tmp = Storage.characters.Rows.Find(id);
            tmp["locked"] = !(bool)tmp["locked"];
            Storage.characters.AcceptChanges();
        }

        private void lockbox_Click(object sender, EventArgs e)
        {
            toggle_lock();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            Storage.active_ids.Remove(this.id);
        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {
            Storage.characters.AcceptChanges();
        }
    }
}
