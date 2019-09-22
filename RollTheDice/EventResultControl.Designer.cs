namespace RollTheDice {
    partial class EventResultControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ResultNumberLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultProbabilityLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultNumberLabel
            // 
            this.ResultNumberLabel.AutoSize = true;
            this.ResultNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResultNumberLabel.Location = new System.Drawing.Point(5, 5);
            this.ResultNumberLabel.Name = "ResultNumberLabel";
            this.ResultNumberLabel.Padding = new System.Windows.Forms.Padding(5);
            this.ResultNumberLabel.Size = new System.Drawing.Size(46, 30);
            this.ResultNumberLabel.TabIndex = 0;
            this.ResultNumberLabel.Text = "999";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTextBox.Location = new System.Drawing.Point(5, 5);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(407, 26);
            this.ResultTextBox.TabIndex = 1;
            // 
            // ResultProbabilityLabel
            // 
            this.ResultProbabilityLabel.AutoSize = true;
            this.ResultProbabilityLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResultProbabilityLabel.Location = new System.Drawing.Point(42, 5);
            this.ResultProbabilityLabel.Name = "ResultProbabilityLabel";
            this.ResultProbabilityLabel.Padding = new System.Windows.Forms.Padding(5);
            this.ResultProbabilityLabel.Size = new System.Drawing.Size(60, 30);
            this.ResultProbabilityLabel.TabIndex = 2;
            this.ResultProbabilityLabel.Text = "100%";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ResultNumberLabel);
            this.panel1.Controls.Add(this.ResultProbabilityLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(107, 36);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ResultTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(107, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(417, 36);
            this.panel2.TabIndex = 4;
            // 
            // EventResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(524, 36);
            this.Name = "EventResultControl";
            this.Size = new System.Drawing.Size(524, 36);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ResultNumberLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultProbabilityLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
