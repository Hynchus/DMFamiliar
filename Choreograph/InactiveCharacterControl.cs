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
    public partial class InactiveCharacterControl : UserControl
    {
        private string _id;
        public string id {
            get { return _id; }
            set {
                _id = value;
                update_bindings();
                update_visibility();
            }
        }
        private string _filter = "";
        public string filter {
            get { return _filter; }
            set {
                _filter = value;
                update_visibility();
            }
        }

        DataView character_view;


        // Currently overrides Visible if set from elsewhere. This can be reworked later if needed.
        private void update_visibility()
        {
            if (character_view.Count <= 0)
            {
                this.Parent.Controls.Remove(this);
                return;
            }
            if (!((string)character_view[0]["name"]).Contains(filter) || Storage.active_ids.Contains(id))
            {
                Visible = false;
            }
            else
            {
                Visible = true;
            }
        }

        private void update_bindings()
        {
            character_view.RowFilter = string.Format("{0} = '{1}'", "id", id);

            namelbl.DataBindings.Clear();
            namelbl.DataBindings.Add(new Binding("Text", character_view, "name", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void setup()
        {
            InitializeComponent();
            character_view = Storage.characters.AsDataView();
        }

        public InactiveCharacterControl()
        {
            setup();
        }

        public InactiveCharacterControl(string id)
        {
            setup();
            this.id = id;
        }

        private void movebtn_Click(object sender, EventArgs e)
        {
            Storage.active_ids.Add(id);
        }
    }
}
