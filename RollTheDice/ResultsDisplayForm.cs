using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollTheDice {
    public partial class ResultsDisplayForm : Form {
        private Main owner;

        public ResultsDisplayForm(Main owner) {
            InitializeComponent();
            this.owner = owner;
        }

        public void AddRollDisplay(RollDisplay roll_display) {
            DisplayFlowLayout.Controls.Add(roll_display);
            DisplayFlowLayout.Controls[DisplayFlowLayout.Controls.Count - 1].Focus();
            DisplayFlowLayout.ScrollControlIntoView(roll_display);
        }

        private void ResultsDisplayForm_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.DisplayFormState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal) {
                Properties.Settings.Default.DisplayFormLocation = this.Location;
                Properties.Settings.Default.DisplayFormSize = this.Size;
            }
            else {
                Properties.Settings.Default.DisplayFormLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.DisplayFormSize = this.RestoreBounds.Size;
            }
            Properties.Settings.Default.Save();

            owner.NullResultsDisplay();
        }

        private void ResultsDisplayForm_Load(object sender, EventArgs e) {
            this.Location = Properties.Settings.Default.DisplayFormLocation;
            this.Size = Properties.Settings.Default.DisplayFormSize;
            if (Properties.Settings.Default.DisplayFormState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
