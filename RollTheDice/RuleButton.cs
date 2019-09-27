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
    public partial class RuleButton : UserControl {
        private Main owner;

        public void set_button_colour(Color colour)
        {
            Button.BackColor = colour;
            float brightness = colour.GetBrightness();
            if (colour.GetBrightness() > 0.49f)
            {
                Button.ForeColor = Color.Black;
            }
            else
            {
                Button.ForeColor = Color.White;
            }
        }

        public RuleButton(Main owner, string rule_name, Color rule_colour) {
            InitializeComponent();
            this.owner = owner;
            Button.Text = rule_name;
            set_button_colour(rule_colour);
        }

        public string GetRuleName() {
            return Button.Text;
        }

        private void Button_Click(object sender, EventArgs e) {
            Button_MouseClick(sender, (MouseEventArgs)e);
        }

        private void Button_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (Secretary.GetActiveProfile().profile_name == "Default") {
                    removeToolStripMenuItem.Visible = false;
                }
                else {
                    removeToolStripMenuItem.Visible = true;
                }
                ButtonRightClickMenu.Show(Button, e.Location);
            }
            else if (Control.ModifierKeys == Keys.Shift) {

            }
            else if (Control.ModifierKeys == Keys.Control) {

            }
            else {
                owner.DisplayRuleRoll(Button.Text);
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
            owner.EditRule(Button.Text);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            owner.DeleteRuleButton(this);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
            owner.RemoveRuleButton(this);
        }
    }
}
