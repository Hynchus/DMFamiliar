namespace Choreograph
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activecharacterspanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.filtertb = new Choreograph.HintTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inactivecharacterspanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.displaybtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.rollbtn = new System.Windows.Forms.Button();
            this.menustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.versiontoolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.activecharactersmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllActiveCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayiconmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menustrip.SuspendLayout();
            this.activecharactersmenustrip.SuspendLayout();
            this.trayiconmenustrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(400, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(554, 278);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.activecharacterspanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 232);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // activecharacterspanel
            // 
            this.activecharacterspanel.AutoScroll = true;
            this.activecharacterspanel.BackColor = System.Drawing.SystemColors.Control;
            this.activecharacterspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activecharacterspanel.Location = new System.Drawing.Point(0, 0);
            this.activecharacterspanel.MinimumSize = new System.Drawing.Size(340, 100);
            this.activecharacterspanel.Name = "activecharacterspanel";
            this.activecharacterspanel.Size = new System.Drawing.Size(350, 230);
            this.activecharacterspanel.TabIndex = 0;
            this.activecharacterspanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(352, 38);
            this.tableLayoutPanel5.TabIndex = 2;
            this.tableLayoutPanel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Characters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.filtertb, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 278);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // filtertb
            // 
            this.filtertb.BackColor = System.Drawing.Color.White;
            this.filtertb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filtertb.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtertb.ForeColor = System.Drawing.Color.Gray;
            this.filtertb.Hint = "Filter";
            this.filtertb.Location = new System.Drawing.Point(2, 9);
            this.filtertb.Margin = new System.Windows.Forms.Padding(2);
            this.filtertb.Name = "filtertb";
            this.filtertb.Size = new System.Drawing.Size(190, 31);
            this.filtertb.SourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnValidation;
            this.filtertb.TabIndex = 0;
            this.filtertb.Text = "Filter";
            this.filtertb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filtertb.TextChanged += new System.EventHandler(this.filtertb_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.inactivecharacterspanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 232);
            this.panel2.TabIndex = 1;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // inactivecharacterspanel
            // 
            this.inactivecharacterspanel.AutoScroll = true;
            this.inactivecharacterspanel.BackColor = System.Drawing.SystemColors.Control;
            this.inactivecharacterspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inactivecharacterspanel.Location = new System.Drawing.Point(0, 0);
            this.inactivecharacterspanel.Name = "inactivecharacterspanel";
            this.inactivecharacterspanel.Size = new System.Drawing.Size(188, 230);
            this.inactivecharacterspanel.TabIndex = 1;
            this.inactivecharacterspanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(558, 339);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.Controls.Add(this.displaybtn, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.newbtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.rollbtn, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 284);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(554, 53);
            this.tableLayoutPanel4.TabIndex = 3;
            this.tableLayoutPanel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_mouseclick_to_form);
            // 
            // displaybtn
            // 
            this.displaybtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displaybtn.BackColor = System.Drawing.Color.Yellow;
            this.displaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displaybtn.Location = new System.Drawing.Point(360, 5);
            this.displaybtn.Margin = new System.Windows.Forms.Padding(2);
            this.displaybtn.Name = "displaybtn";
            this.displaybtn.Size = new System.Drawing.Size(134, 42);
            this.displaybtn.TabIndex = 0;
            this.displaybtn.Text = "Show Display";
            this.displaybtn.UseVisualStyleBackColor = false;
            this.displaybtn.Click += new System.EventHandler(this.displaybtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newbtn.Location = new System.Drawing.Point(58, 5);
            this.newbtn.Margin = new System.Windows.Forms.Padding(2);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(134, 42);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "New Character";
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.new_character_click);
            // 
            // rollbtn
            // 
            this.rollbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.rollbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rollbtn.Location = new System.Drawing.Point(209, 5);
            this.rollbtn.Margin = new System.Windows.Forms.Padding(2);
            this.rollbtn.Name = "rollbtn";
            this.rollbtn.Size = new System.Drawing.Size(134, 42);
            this.rollbtn.TabIndex = 0;
            this.rollbtn.Text = "Roll Initiative";
            this.rollbtn.UseVisualStyleBackColor = false;
            this.rollbtn.Click += new System.EventHandler(this.rollbtn_Click);
            // 
            // menustrip
            // 
            this.menustrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versiontoolstripmenuitem});
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(241, 67);
            // 
            // versiontoolstripmenuitem
            // 
            this.versiontoolstripmenuitem.Name = "versiontoolstripmenuitem";
            this.versiontoolstripmenuitem.Size = new System.Drawing.Size(240, 30);
            this.versiontoolstripmenuitem.Text = "version";
            this.versiontoolstripmenuitem.Click += new System.EventHandler(this.versiontoolstripmenuitem_Click);
            // 
            // activecharactersmenustrip
            // 
            this.activecharactersmenustrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.activecharactersmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearAllActiveCharactersToolStripMenuItem});
            this.activecharactersmenustrip.Name = "activecharactersmenustrip";
            this.activecharactersmenustrip.Size = new System.Drawing.Size(289, 70);
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.new_character_click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // clearAllActiveCharactersToolStripMenuItem
            // 
            this.clearAllActiveCharactersToolStripMenuItem.Name = "clearAllActiveCharactersToolStripMenuItem";
            this.clearAllActiveCharactersToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.clearAllActiveCharactersToolStripMenuItem.Text = "Clear All Active Characters";
            this.clearAllActiveCharactersToolStripMenuItem.Click += new System.EventHandler(this.clear_active_characters_click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayiconmenustrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Choreograph";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // trayiconmenustrip
            // 
            this.trayiconmenustrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.trayiconmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.trayiconmenustrip.Name = "trayiconmenustrip";
            this.trayiconmenustrip.Size = new System.Drawing.Size(129, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataSource = typeof(Choreograph.Storage);
            // 
            // storageBindingSource1
            // 
            this.storageBindingSource1.DataSource = typeof(Choreograph.Storage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.tableLayoutPanel3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choreograph";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.menustrip.ResumeLayout(false);
            this.activecharactersmenustrip.ResumeLayout(false);
            this.trayiconmenustrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private HintTextBox filtertb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button rollbtn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button displaybtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private System.Windows.Forms.BindingSource storageBindingSource1;
        private System.Windows.Forms.Panel activecharacterspanel;
        private System.Windows.Forms.Panel inactivecharacterspanel;
        private System.Windows.Forms.ContextMenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem versiontoolstripmenuitem;
        private System.Windows.Forms.ContextMenuStrip activecharactersmenustrip;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearAllActiveCharactersToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayiconmenustrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

