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
    public partial class Modifier : UserControl {
        private RuleEditor owner;
        

        public Modifier(RuleEditor owner, int magnitude, string reason) {
            InitializeComponent();
            this.owner = owner;
            if (magnitude < 0) {
                PlusMinusLabel.Text = "-";
            }
            MagnitudeTextbox.Text = magnitude.ToString();
            ReasonTextbox.Text = reason;
        }

        public StructCollection.Mod GetMod() {
            int magnitude = Convert.ToInt16(MagnitudeTextbox.Text);
            if (PlusMinusLabel.Text == "-") {
                magnitude *= -1;
            }
            return new StructCollection.Mod(magnitude, ReasonTextbox.Text);
        }

        private void SetNameTextboxPrompt() {
            if (ReasonTextbox.Text == "") {
                ReasonTextbox.Text = "Reason";
                ReasonTextbox.ForeColor = Color.Gray;
            }
        }

        private void ReasonTextbox_Leave(object sender, EventArgs e) {
            if (ReasonTextbox.Text == "") {
                SetNameTextboxPrompt();
            }
        }

        private void Modifier_Load(object sender, EventArgs e) {
            SetNameTextboxPrompt();
        }

        private void ReasonTextbox_Enter(object sender, EventArgs e) {
            if (ReasonTextbox.Text == "Reason") {
                ReasonTextbox.Text = "";
                ReasonTextbox.ForeColor = Color.Black;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            owner.RemoveModifier(this);
        }

        private void PlusMinusLabel_Click(object sender, EventArgs e) {
            if (PlusMinusLabel.Text == "+") {
                PlusMinusLabel.Text = "-";
            }
            else {
                PlusMinusLabel.Text = "+";
            }
        }
    }
}
