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
        private MainForm owner;

        public ResultsDisplayForm(MainForm owner) {
            InitializeComponent();
            this.owner = owner;
        }

        private void cull_displays(int threshold)
        {
            threshold = Math.Max(0, threshold);
            for (int i = DisplayFlowLayout.Controls.Count - 1 - threshold; i >= 0; i--)
            {
                DisplayFlowLayout.Controls.RemoveAt(i);
            }
        }

        public void AddRollDisplay(RollDisplay roll_display) {
            roll_display.Flash();
            DisplayFlowLayout.Controls.Add(roll_display);
            cull_displays(50);
            DisplayFlowLayout.Controls[DisplayFlowLayout.Controls.Count - 1].Focus();   // <-- Having this uncommented prevents weirdness with scrollbar for some reason
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
            Properties.Settings.Default.LoadDisplayFormSettings = true;
            Properties.Settings.Default.Save();

            owner.NullResultsDisplay();
        }

        private void ResultsDisplayForm_Load(object sender, EventArgs e) {
            if (Properties.Settings.Default.LoadDisplayFormSettings)
            {
                this.Location = Properties.Settings.Default.DisplayFormLocation;
                this.Size = Properties.Settings.Default.DisplayFormSize;
                if (Properties.Settings.Default.DisplayFormState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }
    }
}
