using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollTheDice {
    public partial class DieControl : UserControl {
        private RuleEditor owner;
        private string tmp = "";

        public DieControl(RuleEditor parent, int count, int faces) {
            InitializeComponent();
            owner = parent;
            DieCount.Text = count.ToString();
            DieFaces.Text = faces.ToString();
        }

        public StructCollection.Die GetDie() {
            return new StructCollection.Die(Convert.ToInt16(DieCount.Text), Convert.ToInt16(DieFaces.Text));
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            owner.RemoveDie(this);
        }

        private void DieChanged() {
            owner.DieChanged();
        }

        private void DieFaces_Validated(object sender, EventArgs e) {
            if (DieFaces.Text == "") {
                DieFaces.Text = "20";
            }
            if (DieFaces.Text != tmp) {
                DieChanged();
            }
        }

        private void DieCount_Validated(object sender, EventArgs e) {
            if (DieCount.Text == "") {
                DieCount.Text = "1";
            }
            if (DieCount.Text != tmp) {
                DieChanged();
            }
        }

        private void DieFaces_Enter(object sender, EventArgs e) {
            tmp = DieFaces.Text;
        }

        private void DieCount_Enter(object sender, EventArgs e) {
            tmp = DieCount.Text;
        }
    }
}
