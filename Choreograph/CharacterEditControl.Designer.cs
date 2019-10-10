namespace Choreograph
{
    partial class CharacterEditControl
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.removebtn = new System.Windows.Forms.Button();
            this.lockbox = new System.Windows.Forms.PictureBox();
            this.rolltb = new Choreograph.HintTextBox();
            this.modtb = new Choreograph.HintTextBox();
            this.nametb = new Choreograph.HintTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lockbox)).BeginInit();
            this.SuspendLayout();
            // 
            // removebtn
            // 
            this.removebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removebtn.BackColor = System.Drawing.SystemColors.Control;
            this.removebtn.BackgroundImage = global::Choreograph.Properties.Resources.x;
            this.removebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removebtn.FlatAppearance.BorderSize = 0;
            this.removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebtn.Location = new System.Drawing.Point(284, 4);
            this.removebtn.Margin = new System.Windows.Forms.Padding(4);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(32, 32);
            this.removebtn.TabIndex = 4;
            this.removebtn.TabStop = false;
            this.toolTip1.SetToolTip(this.removebtn, "Remove from Active list");
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // lockbox
            // 
            this.lockbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lockbox.Image = global::Choreograph.Properties.Resources.unlocked;
            this.lockbox.Location = new System.Drawing.Point(240, 4);
            this.lockbox.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.lockbox.Name = "lockbox";
            this.lockbox.Size = new System.Drawing.Size(32, 32);
            this.lockbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockbox.TabIndex = 3;
            this.lockbox.TabStop = false;
            this.toolTip1.SetToolTip(this.lockbox, "Lock Initiative Roll");
            this.lockbox.Click += new System.EventHandler(this.lockbox_Click);
            // 
            // rolltb
            // 
            this.rolltb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolltb.BackColor = System.Drawing.SystemColors.Window;
            this.rolltb.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolltb.ForeColor = System.Drawing.Color.Gray;
            this.rolltb.Hint = "Roll";
            this.rolltb.Location = new System.Drawing.Point(182, 4);
            this.rolltb.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.rolltb.Name = "rolltb";
            this.rolltb.Size = new System.Drawing.Size(50, 32);
            this.rolltb.SourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnValidation;
            this.rolltb.TabIndex = 7;
            this.rolltb.Text = "Roll";
            this.rolltb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.rolltb, "Initiative Roll");
            // 
            // modtb
            // 
            this.modtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modtb.BackColor = System.Drawing.SystemColors.Window;
            this.modtb.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modtb.ForeColor = System.Drawing.Color.Gray;
            this.modtb.Hint = "Mod";
            this.modtb.Location = new System.Drawing.Point(116, 4);
            this.modtb.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.modtb.Name = "modtb";
            this.modtb.Size = new System.Drawing.Size(50, 32);
            this.modtb.SourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnValidation;
            this.modtb.TabIndex = 6;
            this.modtb.Text = "Mod";
            this.modtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.modtb, "Initiative Modifier");
            // 
            // nametb
            // 
            this.nametb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nametb.BackColor = System.Drawing.SystemColors.Window;
            this.nametb.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.ForeColor = System.Drawing.Color.Gray;
            this.nametb.Hint = "Name";
            this.nametb.Location = new System.Drawing.Point(4, 4);
            this.nametb.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(96, 32);
            this.nametb.SourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
            this.nametb.TabIndex = 5;
            this.nametb.Text = "Name";
            this.nametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.nametb, "Character Name");
            // 
            // CharacterEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.rolltb);
            this.Controls.Add(this.modtb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.lockbox);
            this.MaximumSize = new System.Drawing.Size(0, 40);
            this.MinimumSize = new System.Drawing.Size(320, 40);
            this.Name = "CharacterEditControl";
            this.Size = new System.Drawing.Size(320, 40);
            ((System.ComponentModel.ISupportInitialize)(this.lockbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox lockbox;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private HintTextBox nametb;
        private HintTextBox modtb;
        private HintTextBox rolltb;
    }
}
