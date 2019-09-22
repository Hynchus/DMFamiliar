namespace RollTheDice {
    partial class RollDisplay {
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
            this.RollNumberLabel = new System.Windows.Forms.Label();
            this.ResultTextLabel = new System.Windows.Forms.Label();
            this.RuleNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RollNumberLabel
            // 
            this.RollNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RollNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.RollNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollNumberLabel.Location = new System.Drawing.Point(3, -1);
            this.RollNumberLabel.Name = "RollNumberLabel";
            this.RollNumberLabel.Size = new System.Drawing.Size(618, 72);
            this.RollNumberLabel.TabIndex = 0;
            this.RollNumberLabel.Text = "Roll Number";
            this.RollNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ResultTextLabel
            // 
            this.ResultTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextLabel.Location = new System.Drawing.Point(-1, 71);
            this.ResultTextLabel.Name = "ResultTextLabel";
            this.ResultTextLabel.Size = new System.Drawing.Size(622, 103);
            this.ResultTextLabel.TabIndex = 1;
            this.ResultTextLabel.Text = "Result Text";
            this.ResultTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RuleNameLabel
            // 
            this.RuleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RuleNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RuleNameLabel.Enabled = false;
            this.RuleNameLabel.Location = new System.Drawing.Point(-1, -1);
            this.RuleNameLabel.Name = "RuleNameLabel";
            this.RuleNameLabel.Padding = new System.Windows.Forms.Padding(10);
            this.RuleNameLabel.Size = new System.Drawing.Size(626, 37);
            this.RuleNameLabel.TabIndex = 2;
            this.RuleNameLabel.Text = "Rule Name";
            this.RuleNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RollDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.RuleNameLabel);
            this.Controls.Add(this.ResultTextLabel);
            this.Controls.Add(this.RollNumberLabel);
            this.Name = "RollDisplay";
            this.Size = new System.Drawing.Size(624, 174);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RollNumberLabel;
        private System.Windows.Forms.Label ResultTextLabel;
        private System.Windows.Forms.Label RuleNameLabel;
    }
}
