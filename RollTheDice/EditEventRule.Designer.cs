namespace RollTheDice {
    partial class EditEventRule {
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
            this.ResultsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AddModifierButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddDieButton
            // 
            this.AddDieButton.Location = new System.Drawing.Point(12, 12);
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
            this.SaveButton.Location = new System.Drawing.Point(332, 362);
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
            this.CancelBtn.Location = new System.Drawing.Point(481, 362);
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
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 53);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ResultsLayout);
            this.splitContainer1.Size = new System.Drawing.Size(842, 295);
            this.splitContainer1.SplitterDistance = 102;
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
            this.splitContainer2.Size = new System.Drawing.Size(842, 102);
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
            this.DiceLayout.Size = new System.Drawing.Size(198, 100);
            this.DiceLayout.TabIndex = 0;
            this.DiceLayout.WrapContents = false;
            // 
            // ModifierLayout
            // 
            this.ModifierLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifierLayout.Location = new System.Drawing.Point(0, 0);
            this.ModifierLayout.Name = "ModifierLayout";
            this.ModifierLayout.Size = new System.Drawing.Size(636, 100);
            this.ModifierLayout.TabIndex = 1;
            // 
            // ResultsLayout
            // 
            this.ResultsLayout.AutoScroll = true;
            this.ResultsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsLayout.Location = new System.Drawing.Point(0, 0);
            this.ResultsLayout.Name = "ResultsLayout";
            this.ResultsLayout.Size = new System.Drawing.Size(840, 187);
            this.ResultsLayout.TabIndex = 0;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextbox.Location = new System.Drawing.Point(175, 16);
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
            this.AddModifierButton.Location = new System.Drawing.Point(733, 12);
            this.AddModifierButton.Name = "AddModifierButton";
            this.AddModifierButton.Size = new System.Drawing.Size(120, 35);
            this.AddModifierButton.TabIndex = 6;
            this.AddModifierButton.Text = "Add Modifier";
            this.AddModifierButton.UseVisualStyleBackColor = true;
            this.AddModifierButton.Click += new System.EventHandler(this.AddModifierButton_Click);
            // 
            // EditEventRule
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
            this.MinimumSize = new System.Drawing.Size(888, 466);
            this.Name = "EditEventRule";
            this.Text = "Rule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RuleForm_Closing);
            this.Load += new System.EventHandler(this.RuleForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDieButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel DiceLayout;
        private System.Windows.Forms.FlowLayoutPanel ResultsLayout;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel ModifierLayout;
        private System.Windows.Forms.Button AddModifierButton;
    }
}