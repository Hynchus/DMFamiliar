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
    public partial class EventResultControl : UserControl {

        public EventResultControl(int roll_number, float roll_probability, string result_text = "") {
            InitializeComponent();
            SetRollNumber(roll_number);
            SetRollProbability(roll_probability);
            SetResultText(result_text);
        }

        private void SetRollNumber(int roll_number) {
            ResultNumberLabel.Text = roll_number.ToString();
        }

        private void SetRollProbability(float roll_probability) {
            ResultProbabilityLabel.Text = (roll_probability * 100.0).ToString() + "%";
        }

        private void SetResultText(string result_text) {
            ResultTextBox.Text = result_text;
        }

        public StructCollection.EventResult GetData() {
            return new StructCollection.EventResult(Convert.ToInt16(ResultNumberLabel.Text), float.Parse(ResultProbabilityLabel.Text.Split('%')[0]), ResultTextBox.Text);
        }

    }
}
