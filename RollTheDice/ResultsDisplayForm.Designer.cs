namespace RollTheDice {
    partial class ResultsDisplayForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsDisplayForm));
            this.DisplayFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // DisplayFlowLayout
            // 
            this.DisplayFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayFlowLayout.AutoScroll = true;
            this.DisplayFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.DisplayFlowLayout.Location = new System.Drawing.Point(14, 14);
            this.DisplayFlowLayout.Name = "DisplayFlowLayout";
            this.DisplayFlowLayout.Padding = new System.Windows.Forms.Padding(2);
            this.DisplayFlowLayout.Size = new System.Drawing.Size(664, 180);
            this.DisplayFlowLayout.TabIndex = 0;
            this.DisplayFlowLayout.WrapContents = false;
            // 
            // ResultsDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 210);
            this.Controls.Add(this.DisplayFlowLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(714, 5000);
            this.MinimumSize = new System.Drawing.Size(714, 260);
            this.Name = "ResultsDisplayForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "Results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultsDisplayForm_FormClosing);
            this.Load += new System.EventHandler(this.ResultsDisplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DisplayFlowLayout;
    }
}