namespace RollTheDice {
    partial class EditAttackRule {
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
            this.AddDieButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DiceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ModifierLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.DamageDiceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DamageModifiersLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DamageTypeTextbox = new System.Windows.Forms.TextBox();
            this.AddDamageModifier = new System.Windows.Forms.Button();
            this.AddDamageDieButton = new System.Windows.Forms.Button();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AddModifierButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.somethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criticalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criticalSuccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CriticalSuccessThresholdTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.criticalFailureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CriticalFailThresholdTextbox = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddDieButton
            // 
            this.AddDieButton.Location = new System.Drawing.Point(12, 42);
            this.AddDieButton.Name = "AddDieButton";
            this.AddDieButton.Size = new System.Drawing.Size(120, 35);
            this.AddDieButton.TabIndex = 0;
            this.AddDieButton.Text = "Add Die";
            this.AddDieButton.UseVisualStyleBackColor = true;
            this.AddDieButton.Click += new System.EventHandler(this.AddDieButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(325, 364);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 34);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(474, 364);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 34);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 85);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Panel2.Controls.Add(this.DamageTypeTextbox);
            this.splitContainer1.Panel2.Controls.Add(this.AddDamageModifier);
            this.splitContainer1.Panel2.Controls.Add(this.AddDamageDieButton);
            this.splitContainer1.Size = new System.Drawing.Size(842, 263);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DiceLayout);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ModifierLayout);
            this.splitContainer2.Size = new System.Drawing.Size(842, 99);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 0;
            // 
            // DiceLayout
            // 
            this.DiceLayout.AutoScroll = true;
            this.DiceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiceLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DiceLayout.Location = new System.Drawing.Point(0, 0);
            this.DiceLayout.Name = "DiceLayout";
            this.DiceLayout.Size = new System.Drawing.Size(198, 97);
            this.DiceLayout.TabIndex = 0;
            this.DiceLayout.WrapContents = false;
            // 
            // ModifierLayout
            // 
            this.ModifierLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifierLayout.Location = new System.Drawing.Point(0, 0);
            this.ModifierLayout.Name = "ModifierLayout";
            this.ModifierLayout.Size = new System.Drawing.Size(636, 97);
            this.ModifierLayout.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 56);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.DamageDiceLayout);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.DamageModifiersLayout);
            this.splitContainer4.Size = new System.Drawing.Size(842, 104);
            this.splitContainer4.SplitterDistance = 200;
            this.splitContainer4.TabIndex = 1;
            // 
            // DamageDiceLayout
            // 
            this.DamageDiceLayout.AutoScroll = true;
            this.DamageDiceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DamageDiceLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DamageDiceLayout.Location = new System.Drawing.Point(0, 0);
            this.DamageDiceLayout.Name = "DamageDiceLayout";
            this.DamageDiceLayout.Size = new System.Drawing.Size(198, 102);
            this.DamageDiceLayout.TabIndex = 0;
            this.DamageDiceLayout.WrapContents = false;
            // 
            // DamageModifiersLayout
            // 
            this.DamageModifiersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DamageModifiersLayout.Location = new System.Drawing.Point(0, 0);
            this.DamageModifiersLayout.Name = "DamageModifiersLayout";
            this.DamageModifiersLayout.Size = new System.Drawing.Size(636, 102);
            this.DamageModifiersLayout.TabIndex = 1;
            // 
            // DamageTypeTextbox
            // 
            this.DamageTypeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DamageTypeTextbox.Location = new System.Drawing.Point(163, 19);
            this.DamageTypeTextbox.Name = "DamageTypeTextbox";
            this.DamageTypeTextbox.Size = new System.Drawing.Size(516, 26);
            this.DamageTypeTextbox.TabIndex = 8;
            this.DamageTypeTextbox.Text = "Damage Type";
            this.DamageTypeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DamageTypeTextbox.Enter += new System.EventHandler(this.DamageTypeTextbox_Enter);
            this.DamageTypeTextbox.Leave += new System.EventHandler(this.DamageTypeTextbox_Leave);
            // 
            // AddDamageModifier
            // 
            this.AddDamageModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDamageModifier.Location = new System.Drawing.Point(722, 15);
            this.AddDamageModifier.Name = "AddDamageModifier";
            this.AddDamageModifier.Size = new System.Drawing.Size(120, 35);
            this.AddDamageModifier.TabIndex = 7;
            this.AddDamageModifier.Text = "Add Modifier";
            this.AddDamageModifier.UseVisualStyleBackColor = true;
            this.AddDamageModifier.Click += new System.EventHandler(this.AddDamageModifier_Click);
            // 
            // AddDamageDieButton
            // 
            this.AddDamageDieButton.Location = new System.Drawing.Point(0, 15);
            this.AddDamageDieButton.Name = "AddDamageDieButton";
            this.AddDamageDieButton.Size = new System.Drawing.Size(120, 35);
            this.AddDamageDieButton.TabIndex = 1;
            this.AddDamageDieButton.Text = "Add Die";
            this.AddDamageDieButton.UseVisualStyleBackColor = true;
            this.AddDamageDieButton.Click += new System.EventHandler(this.AddDamageDieButton_Click);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextbox.Location = new System.Drawing.Point(175, 46);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(516, 26);
            this.NameTextbox.TabIndex = 5;
            this.NameTextbox.Text = "Rule Name";
            this.NameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_Change);
            this.NameTextbox.Enter += new System.EventHandler(this.NameTextbox_Enter);
            this.NameTextbox.Leave += new System.EventHandler(this.NameTextbox_Leave);
            // 
            // AddModifierButton
            // 
            this.AddModifierButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddModifierButton.Location = new System.Drawing.Point(733, 42);
            this.AddModifierButton.Name = "AddModifierButton";
            this.AddModifierButton.Size = new System.Drawing.Size(120, 35);
            this.AddModifierButton.TabIndex = 6;
            this.AddModifierButton.Text = "Add Modifier";
            this.AddModifierButton.UseVisualStyleBackColor = true;
            this.AddModifierButton.Click += new System.EventHandler(this.AddModifierButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethingToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuStrip.Size = new System.Drawing.Size(866, 33);
            this.MenuStrip.TabIndex = 7;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // somethingToolStripMenuItem
            // 
            this.somethingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criticalsToolStripMenuItem});
            this.somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            this.somethingToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.somethingToolStripMenuItem.Text = "Functionality";
            // 
            // criticalsToolStripMenuItem
            // 
            this.criticalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criticalSuccessToolStripMenuItem,
            this.criticalFailureToolStripMenuItem});
            this.criticalsToolStripMenuItem.Name = "criticalsToolStripMenuItem";
            this.criticalsToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.criticalsToolStripMenuItem.Text = "Criticals";
            // 
            // criticalSuccessToolStripMenuItem
            // 
            this.criticalSuccessToolStripMenuItem.Checked = true;
            this.criticalSuccessToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.criticalSuccessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CriticalSuccessThresholdTextbox});
            this.criticalSuccessToolStripMenuItem.Name = "criticalSuccessToolStripMenuItem";
            this.criticalSuccessToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.criticalSuccessToolStripMenuItem.Text = "Critical Success";
            this.criticalSuccessToolStripMenuItem.Click += new System.EventHandler(this.CriticalSuccessToolStripMenuItem_Click);
            // 
            // CriticalSuccessThresholdTextbox
            // 
            this.CriticalSuccessThresholdTextbox.Name = "CriticalSuccessThresholdTextbox";
            this.CriticalSuccessThresholdTextbox.Size = new System.Drawing.Size(100, 31);
            this.CriticalSuccessThresholdTextbox.Text = "20";
            this.CriticalSuccessThresholdTextbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CriticalSuccessThresholdTextbox.ToolTipText = "Dice Roll >= # results in Critical Success";
            this.CriticalSuccessThresholdTextbox.Leave += new System.EventHandler(this.CriticalSuccessThresholdTextbox_Leave);
            // 
            // criticalFailureToolStripMenuItem
            // 
            this.criticalFailureToolStripMenuItem.Checked = true;
            this.criticalFailureToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.criticalFailureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CriticalFailThresholdTextbox});
            this.criticalFailureToolStripMenuItem.Name = "criticalFailureToolStripMenuItem";
            this.criticalFailureToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.criticalFailureToolStripMenuItem.Text = "Critical Failure";
            this.criticalFailureToolStripMenuItem.Click += new System.EventHandler(this.CriticalFailureToolStripMenuItem_Click);
            // 
            // CriticalFailThresholdTextbox
            // 
            this.CriticalFailThresholdTextbox.Name = "CriticalFailThresholdTextbox";
            this.CriticalFailThresholdTextbox.Size = new System.Drawing.Size(100, 31);
            this.CriticalFailThresholdTextbox.Text = "1";
            this.CriticalFailThresholdTextbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CriticalFailThresholdTextbox.ToolTipText = "Dice roll <= # results in Critical Fail";
            this.CriticalFailThresholdTextbox.Leave += new System.EventHandler(this.CriticalFailThresholdTextbox_Leave);
            // 
            // EditAttackRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 410);
            this.Controls.Add(this.AddModifierButton);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddDieButton);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(888, 466);
            this.Name = "EditAttackRule";
            this.Text = "Rule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAttackRule_FormClosing);
            this.Load += new System.EventHandler(this.EditAttackRule_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDieButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel DiceLayout;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel ModifierLayout;
        private System.Windows.Forms.Button AddModifierButton;
        private System.Windows.Forms.TextBox DamageTypeTextbox;
        private System.Windows.Forms.Button AddDamageModifier;
        private System.Windows.Forms.Button AddDamageDieButton;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.FlowLayoutPanel DamageDiceLayout;
        private System.Windows.Forms.FlowLayoutPanel DamageModifiersLayout;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criticalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criticalSuccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criticalFailureToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox CriticalSuccessThresholdTextbox;
        private System.Windows.Forms.ToolStripTextBox CriticalFailThresholdTextbox;
    }
}