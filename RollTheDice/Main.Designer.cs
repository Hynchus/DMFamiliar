namespace RollTheDice {
    partial class Main {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TipsLabel = new System.Windows.Forms.Label();
            this.RuleLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Default = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfilesSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.NewProfileTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ProfileRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteProfileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleToProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ProfileRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipsLabel
            // 
            this.TipsLabel.AutoSize = true;
            this.TipsLabel.ForeColor = System.Drawing.Color.Green;
            this.TipsLabel.Location = new System.Drawing.Point(573, 19);
            this.TipsLabel.Name = "TipsLabel";
            this.TipsLabel.Size = new System.Drawing.Size(0, 20);
            this.TipsLabel.TabIndex = 4;
            this.TipsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TipsLabel.Visible = false;
            // 
            // RuleLayout
            // 
            this.RuleLayout.AllowDrop = true;
            this.RuleLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RuleLayout.AutoScroll = true;
            this.RuleLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RuleLayout.Location = new System.Drawing.Point(13, 113);
            this.RuleLayout.Name = "RuleLayout";
            this.RuleLayout.Size = new System.Drawing.Size(592, 235);
            this.RuleLayout.TabIndex = 1;
            this.RuleLayout.DragDrop += new System.Windows.Forms.DragEventHandler(this.RuleLayout_DragDrop);
            this.RuleLayout.DragEnter += new System.Windows.Forms.DragEventHandler(this.RuleLayout_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.ProfilesMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attackToolStripMenuItem,
            this.eventRuleToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.newToolStripMenuItem.Text = "New";
            // 
            // attackToolStripMenuItem
            // 
            this.attackToolStripMenuItem.Name = "attackToolStripMenuItem";
            this.attackToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.attackToolStripMenuItem.Text = "Attack";
            this.attackToolStripMenuItem.Click += new System.EventHandler(this.attackToolStripMenuItem_Click);
            // 
            // eventRuleToolStripMenuItem
            // 
            this.eventRuleToolStripMenuItem.Name = "eventRuleToolStripMenuItem";
            this.eventRuleToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.eventRuleToolStripMenuItem.Text = "Event";
            this.eventRuleToolStripMenuItem.Click += new System.EventHandler(this.EventRuleToolStripMenuItem_Click);
            // 
            // ProfilesMenuItem
            // 
            this.ProfilesMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProfilesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Default,
            this.ProfilesSeparator,
            this.NewProfileTextbox});
            this.ProfilesMenuItem.Name = "ProfilesMenuItem";
            this.ProfilesMenuItem.Size = new System.Drawing.Size(82, 29);
            this.ProfilesMenuItem.Text = "Profiles";
            this.ProfilesMenuItem.DropDownClosed += new System.EventHandler(this.ToolStripTextBox1_Leave);
            // 
            // Default
            // 
            this.Default.Checked = true;
            this.Default.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(214, 30);
            this.Default.Tag = "";
            this.Default.Text = "Default";
            this.Default.Click += new System.EventHandler(this.Profile_Click);
            // 
            // ProfilesSeparator
            // 
            this.ProfilesSeparator.Name = "ProfilesSeparator";
            this.ProfilesSeparator.Size = new System.Drawing.Size(211, 6);
            // 
            // NewProfileTextbox
            // 
            this.NewProfileTextbox.ForeColor = System.Drawing.Color.Gray;
            this.NewProfileTextbox.Name = "NewProfileTextbox";
            this.NewProfileTextbox.Size = new System.Drawing.Size(142, 31);
            this.NewProfileTextbox.Text = "New Profile";
            this.NewProfileTextbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewProfileTextbox.Leave += new System.EventHandler(this.ToolStripTextBox1_Leave);
            this.NewProfileTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewProfileTextbox_KeyDown);
            this.NewProfileTextbox.Click += new System.EventHandler(this.NewProfileTextbox_Enter);
            this.NewProfileTextbox.TextChanged += new System.EventHandler(this.ToolStripTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "1d4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 7;
            this.button2.Text = "1d6";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 8;
            this.button3.Text = "1d8";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 9;
            this.button4.Text = "1d10";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(343, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 10;
            this.button5.Text = "1d12";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(423, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 11;
            this.button6.Text = "1d20";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(503, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 12;
            this.button7.Text = "1d100";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ProfileRightClickMenu
            // 
            this.ProfileRightClickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ProfileRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteProfileButton});
            this.ProfileRightClickMenu.Name = "ProfileRightClickMenu";
            this.ProfileRightClickMenu.Size = new System.Drawing.Size(135, 34);
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(134, 30);
            this.DeleteProfileButton.Text = "Delete";
            this.DeleteProfileButton.Click += new System.EventHandler(this.DeleteProfileButton_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruleToProfileToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // ruleToProfileToolStripMenuItem
            // 
            this.ruleToProfileToolStripMenuItem.Name = "ruleToProfileToolStripMenuItem";
            this.ruleToProfileToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.ruleToProfileToolStripMenuItem.Text = "Rule To Profile";
            this.ruleToProfileToolStripMenuItem.Click += new System.EventHandler(this.ruleToProfileToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(617, 360);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipsLabel);
            this.Controls.Add(this.RuleLayout);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(617, 360);
            this.Name = "Main";
            this.Text = "Roll The Dice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProfileRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TipsLabel;
        private System.Windows.Forms.FlowLayoutPanel RuleLayout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attackToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem ProfilesMenuItem;
        private System.Windows.Forms.ToolStripSeparator ProfilesSeparator;
        private System.Windows.Forms.ToolStripTextBox NewProfileTextbox;
        private System.Windows.Forms.ToolStripMenuItem Default;
        private System.Windows.Forms.ContextMenuStrip ProfileRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteProfileButton;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleToProfileToolStripMenuItem;
    }
}

