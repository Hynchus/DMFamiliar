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
    public partial class RollDisplay : UserControl {

        private void RollLabel(int roll_number, int roll_modifier) {
            RollNumberLabel.Text = (roll_number + roll_modifier).ToString();
        }

        public RollDisplay(int roll_number = 0, int roll_modifier = 0, StructCollection.Rule rule = new StructCollection.Rule()) {
            InitializeComponent();

            RollLabel(roll_number, roll_modifier);
            RuleNameLabel.Text = rule.rule_name;
            if (rule.results != null) {
                ResultTextLabel.Text = rule.results.Display(roll_number, roll_modifier);
            }
            else {
                ResultTextLabel.Text = "";
            }
        }

        public RollDisplay(int roll_number = 0, int roll_modifier = 0, string roll_name = "") {
            InitializeComponent();

            RollLabel(roll_number, roll_modifier);
            RuleNameLabel.Text = roll_name;
            ResultTextLabel.Text = "";
        }
    }
}
