namespace RollTheDice {
    partial class DieControl {
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
            this.label1 = new System.Windows.Forms.Label();
            this.DieCount = new System.Windows.Forms.MaskedTextBox();
            this.DieFaces = new System.Windows.Forms.MaskedTextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "D";
            // 
            // DieCount
            // 
            this.DieCount.HidePromptOnLeave = true;
            this.DieCount.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.DieCount.Location = new System.Drawing.Point(14, 7);
            this.DieCount.Mask = "000";
            this.DieCount.Name = "DieCount";
            this.DieCount.PromptChar = ' ';
            this.DieCount.Size = new System.Drawing.Size(38, 26);
            this.DieCount.TabIndex = 1;
            this.DieCount.Text = "999";
            this.DieCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DieCount.ValidatingType = typeof(int);
            this.DieCount.Enter += new System.EventHandler(this.DieCount_Enter);
            this.DieCount.Validated += new System.EventHandler(this.DieCount_Validated);
            // 
            // DieFaces
            // 
            this.DieFaces.HidePromptOnLeave = true;
            this.DieFaces.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.DieFaces.Location = new System.Drawing.Point(75, 7);
            this.DieFaces.Mask = "000";
            this.DieFaces.Name = "DieFaces";
            this.DieFaces.PromptChar = ' ';
            this.DieFaces.Size = new System.Drawing.Size(38, 26);
            this.DieFaces.TabIndex = 2;
            this.DieFaces.Text = "999";
            this.DieFaces.Enter += new System.EventHandler(this.DieFaces_Enter);
            this.DieFaces.Validated += new System.EventHandler(this.DieFaces_Validated);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveButton.Location = new System.Drawing.Point(163, 4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(86, 35);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.DieFaces);
            this.Controls.Add(this.DieCount);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(265, 32);
            this.Name = "DieControl";
            this.Size = new System.Drawing.Size(265, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox DieCount;
        private System.Windows.Forms.MaskedTextBox DieFaces;
        private System.Windows.Forms.Button RemoveButton;
    }
}
