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
        private bool highlighted = false;


        public RollDisplay(int roll_number = 0, int roll_modifier = 0, StructCollection.Rule rule = new StructCollection.Rule()) {
            InitializeComponent();

            
            RuleNameLabel.Text = rule.rule_name;
            if (rule.results != null) {
                (string roll, string result) display = rule.results.Display(roll_number, roll_modifier);
                RollNumberLabel.Text = display.roll;
                ResultTextLabel.Text = display.result;
            }
            else {
                RollNumberLabel.Text = "";
                ResultTextLabel.Text = "";
            }
        }

        public RollDisplay(int roll_number = 0, int roll_modifier = 0, string roll_name = "") {
            InitializeComponent();

            RollNumberLabel.Text = (roll_number + roll_modifier).ToString();
            RuleNameLabel.Text = roll_name;
            ResultTextLabel.Text = "";
        }

        public void Flash()
        {
            
        }

        public void SetHighlighted(bool highlighted)
        {
            this.highlighted = highlighted;
            if (highlighted)
            {

            }
            else
            {

            }
        }
    }
}
