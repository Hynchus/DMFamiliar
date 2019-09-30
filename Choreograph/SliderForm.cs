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
    public partial class SliderForm : Form
    {
        public delegate void onValueChange(int value);

        onValueChange on_value_change;

        public SliderForm(onValueChange onValueChange, int start_value = 50, string title = "")
        {
            InitializeComponent();
            on_value_change = onValueChange;
            slider.Value = start_value;
            Text = title;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            on_value_change(slider.Value);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
