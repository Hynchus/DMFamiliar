namespace RollTheDice {
    partial class Modifier {
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
            this.MagnitudeTextbox = new System.Windows.Forms.MaskedTextBox();
            this.ReasonTextbox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.PlusMinusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MagnitudeTextbox
            // 
            this.MagnitudeTextbox.HidePromptOnLeave = true;
            this.MagnitudeTextbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.MagnitudeTextbox.Location = new System.Drawing.Point(36, 7);
            this.MagnitudeTextbox.Mask = "000";
            this.MagnitudeTextbox.Name = "MagnitudeTextbox";
            this.MagnitudeTextbox.PromptChar = ' ';
            this.MagnitudeTextbox.Size = new System.Drawing.Size(38, 26);
            this.MagnitudeTextbox.TabIndex = 0;
            this.MagnitudeTextbox.Text = "999";
            this.MagnitudeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReasonTextbox
            // 
            this.ReasonTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReasonTextbox.Location = new System.Drawing.Point(80, 7);
            this.ReasonTextbox.Name = "ReasonTextbox";
            this.ReasonTextbox.Size = new System.Drawing.Size(307, 26);
            this.ReasonTextbox.TabIndex = 2;
            this.ReasonTextbox.Enter += new System.EventHandler(this.ReasonTextbox_Enter);
            this.ReasonTextbox.Leave += new System.EventHandler(this.ReasonTextbox_Leave);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(407, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(86, 35);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // PlusMinusLabel
            // 
            this.PlusMinusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMinusLabel.Location = new System.Drawing.Point(4, 7);
            this.PlusMinusLabel.Name = "PlusMinusLabel";
            this.PlusMinusLabel.Size = new System.Drawing.Size(26, 26);
            this.PlusMinusLabel.TabIndex = 5;
            this.PlusMinusLabel.Text = "+";
            this.PlusMinusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlusMinusLabel.Click += new System.EventHandler(this.PlusMinusLabel_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlusMinusLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ReasonTextbox);
            this.Controls.Add(this.MagnitudeTextbox);
            this.Name = "Modifier";
            this.Size = new System.Drawing.Size(541, 42);
            this.Load += new System.EventHandler(this.Modifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MagnitudeTextbox;
        private System.Windows.Forms.TextBox ReasonTextbox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label PlusMinusLabel;
    }
}
