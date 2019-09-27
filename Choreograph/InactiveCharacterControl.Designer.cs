namespace Choreograph
{
    partial class InactiveCharacterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movebtn = new System.Windows.Forms.Button();
            this.namelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movebtn
            // 
            this.movebtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.movebtn.BackColor = System.Drawing.SystemColors.Control;
            this.movebtn.BackgroundImage = global::Choreograph.Properties.Resources.moveleft;
            this.movebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movebtn.FlatAppearance.BorderSize = 0;
            this.movebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movebtn.Location = new System.Drawing.Point(4, 4);
            this.movebtn.Name = "movebtn";
            this.movebtn.Size = new System.Drawing.Size(32, 32);
            this.movebtn.TabIndex = 5;
            this.movebtn.UseVisualStyleBackColor = false;
            this.movebtn.Click += new System.EventHandler(this.movebtn_Click);
            // 
            // namelbl
            // 
            this.namelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namelbl.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(44, 4);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(102, 32);
            this.namelbl.TabIndex = 6;
            this.namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InactiveCharacterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.movebtn);
            this.MinimumSize = new System.Drawing.Size(150, 40);
            this.Name = "InactiveCharacterControl";
            this.Size = new System.Drawing.Size(150, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button movebtn;
        private System.Windows.Forms.Label namelbl;
    }
}
