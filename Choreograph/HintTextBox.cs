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
    public partial class HintTextBox : TextBox
    {
        private Color starting_forecolour;
        public Color HintForecolor = Color.Gray;
        private bool hint_active = false;
        private bool hint_flag = false;
        private string _hint = "";
        public string Hint {
            get { return _hint; }
            set {
                _hint = value;
                if (hint_active)
                {
                    hint_flag = true;
                    Text = value;
                }
                else if (show_hint())
                {
                    enable_hint();
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!Focused)
            {
                if (show_hint())
                {
                    enable_hint();
                    return;
                }
                if (hint_flag)
                {
                    hint_flag = false;
                    return;
                }
            }
            disable_hint();
            base.OnTextChanged(e);
        }

        private void test(object sender, EventArgs e)
        {
            var tmp = e;
        }

        public HintTextBox()
        {
            InitializeComponent();
            starting_forecolour = ForeColor;
            this.Enter += textBox1_Enter;
            this.Validated += textBox1_Leave;

            AutoSize = false;
            Location = new Point(0, 0);
            Size = this.Size;
            BackColor = Color.Red;
            Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            ForeColor = HintForecolor;

            if (show_hint())
            {
                enable_hint();
            }
        }

        private bool show_hint()
        {
            return (!Focused && Text.Trim() == "" && Hint.Trim() != "");
        }

        private void enable_hint()
        {
            hint_flag = true;
            hint_active = true;
            ForeColor = HintForecolor;
            Text = Hint;
        }

        private void disable_hint()
        {
            hint_active = false;
            hint_flag = false;
            ForeColor = starting_forecolour;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (show_hint())
            {
                enable_hint();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (hint_active)
            {
                disable_hint();
                Text = "";
            }
        }
    }
}
