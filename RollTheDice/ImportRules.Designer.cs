namespace RollTheDice {
    partial class ImportRules {
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
            this.DamageRulesListbox = new System.Windows.Forms.ListBox();
            this.Importbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.EventRulesListbox = new System.Windows.Forms.ListBox();
            this.DamageRuleslbl = new System.Windows.Forms.Label();
            this.EventRuleslbl = new System.Windows.Forms.Label();
            this.RulesListboxesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RulesListboxesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DamageRulesListbox
            // 
            this.DamageRulesListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DamageRulesListbox.FormattingEnabled = true;
            this.DamageRulesListbox.ItemHeight = 20;
            this.DamageRulesListbox.Location = new System.Drawing.Point(3, 23);
            this.DamageRulesListbox.Name = "DamageRulesListbox";
            this.DamageRulesListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.DamageRulesListbox.Size = new System.Drawing.Size(201, 154);
            this.DamageRulesListbox.TabIndex = 0;
            // 
            // Importbtn
            // 
            this.Importbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Importbtn.Location = new System.Drawing.Point(126, 198);
            this.Importbtn.Name = "Importbtn";
            this.Importbtn.Size = new System.Drawing.Size(75, 34);
            this.Importbtn.TabIndex = 1;
            this.Importbtn.Text = "Import";
            this.Importbtn.UseVisualStyleBackColor = true;
            this.Importbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelbtn.Location = new System.Drawing.Point(236, 198);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 34);
            this.Cancelbtn.TabIndex = 2;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // EventRulesListbox
            // 
            this.EventRulesListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventRulesListbox.FormattingEnabled = true;
            this.EventRulesListbox.ItemHeight = 20;
            this.EventRulesListbox.Location = new System.Drawing.Point(210, 23);
            this.EventRulesListbox.Name = "EventRulesListbox";
            this.EventRulesListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.EventRulesListbox.Size = new System.Drawing.Size(201, 154);
            this.EventRulesListbox.TabIndex = 3;
            this.EventRulesListbox.SelectedIndexChanged += new System.EventHandler(this.EventRulesListbox_SelectedIndexChanged);
            // 
            // DamageRuleslbl
            // 
            this.DamageRuleslbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DamageRuleslbl.Location = new System.Drawing.Point(3, 0);
            this.DamageRuleslbl.Name = "DamageRuleslbl";
            this.DamageRuleslbl.Size = new System.Drawing.Size(201, 20);
            this.DamageRuleslbl.TabIndex = 4;
            this.DamageRuleslbl.Text = "Damage Rules";
            this.DamageRuleslbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // EventRuleslbl
            // 
            this.EventRuleslbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventRuleslbl.Location = new System.Drawing.Point(210, 0);
            this.EventRuleslbl.Name = "EventRuleslbl";
            this.EventRuleslbl.Size = new System.Drawing.Size(201, 20);
            this.EventRuleslbl.TabIndex = 5;
            this.EventRuleslbl.Text = "Event Rules";
            this.EventRuleslbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RulesListboxesPanel
            // 
            this.RulesListboxesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesListboxesPanel.ColumnCount = 2;
            this.RulesListboxesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RulesListboxesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RulesListboxesPanel.Controls.Add(this.DamageRulesListbox, 0, 1);
            this.RulesListboxesPanel.Controls.Add(this.DamageRuleslbl, 0, 0);
            this.RulesListboxesPanel.Controls.Add(this.EventRuleslbl, 1, 0);
            this.RulesListboxesPanel.Controls.Add(this.EventRulesListbox, 1, 1);
            this.RulesListboxesPanel.Location = new System.Drawing.Point(12, 12);
            this.RulesListboxesPanel.Name = "RulesListboxesPanel";
            this.RulesListboxesPanel.RowCount = 2;
            this.RulesListboxesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RulesListboxesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RulesListboxesPanel.Size = new System.Drawing.Size(414, 180);
            this.RulesListboxesPanel.TabIndex = 6;
            // 
            // ImportRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 244);
            this.Controls.Add(this.RulesListboxesPanel);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Importbtn);
            this.MinimumSize = new System.Drawing.Size(460, 300);
            this.Name = "ImportRules";
            this.Text = "ImportRules";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportRules_FormClosing);
            this.Load += new System.EventHandler(this.ImportRules_Load);
            this.RulesListboxesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DamageRulesListbox;
        private System.Windows.Forms.Button Importbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.ListBox EventRulesListbox;
        private System.Windows.Forms.Label DamageRuleslbl;
        private System.Windows.Forms.Label EventRuleslbl;
        private System.Windows.Forms.TableLayoutPanel RulesListboxesPanel;
    }
}