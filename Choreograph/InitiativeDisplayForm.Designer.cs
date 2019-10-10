namespace Choreograph
{
    partial class InitiativeDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitiativeDisplayForm));
            this.titlelbl = new System.Windows.Forms.Label();
            this.characterlistpanel = new System.Windows.Forms.Panel();
            this.leftborder = new System.Windows.Forms.Panel();
            this.rightborder = new System.Windows.Forms.Panel();
            this.titlepanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cosmeticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titletextbox = new System.Windows.Forms.ToolStripTextBox();
            this.titlefontbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersfontbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundcolourbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growthDirectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growdowntoolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.growuptoolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hideDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topborder = new System.Windows.Forms.Panel();
            this.bottomborder = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.titlepanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlelbl.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Underline);
            this.titlelbl.Location = new System.Drawing.Point(0, 0);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(330, 59);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Initiative";
            this.titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlelbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseDown);
            this.titlelbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseMove);
            this.titlelbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseUp);
            // 
            // characterlistpanel
            // 
            this.characterlistpanel.AutoSize = true;
            this.characterlistpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.characterlistpanel.BackColor = System.Drawing.Color.Transparent;
            this.characterlistpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterlistpanel.Location = new System.Drawing.Point(0, 69);
            this.characterlistpanel.Margin = new System.Windows.Forms.Padding(0);
            this.characterlistpanel.Name = "characterlistpanel";
            this.characterlistpanel.Size = new System.Drawing.Size(330, 298);
            this.characterlistpanel.TabIndex = 1;
            // 
            // leftborder
            // 
            this.leftborder.BackColor = System.Drawing.Color.Transparent;
            this.leftborder.BackgroundImage = global::Choreograph.Properties.Resources.border;
            this.leftborder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftborder.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.leftborder.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftborder.Location = new System.Drawing.Point(0, 10);
            this.leftborder.Margin = new System.Windows.Forms.Padding(0);
            this.leftborder.Name = "leftborder";
            this.leftborder.Size = new System.Drawing.Size(10, 387);
            this.leftborder.TabIndex = 2;
            this.leftborder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizepanel_MouseDown);
            this.leftborder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.leftresizepanel_MouseMove);
            this.leftborder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizepanel_MouseUp);
            // 
            // rightborder
            // 
            this.rightborder.BackColor = System.Drawing.Color.Transparent;
            this.rightborder.BackgroundImage = global::Choreograph.Properties.Resources.border;
            this.rightborder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightborder.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rightborder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightborder.Location = new System.Drawing.Point(340, 10);
            this.rightborder.Margin = new System.Windows.Forms.Padding(0);
            this.rightborder.Name = "rightborder";
            this.rightborder.Size = new System.Drawing.Size(10, 387);
            this.rightborder.TabIndex = 3;
            this.rightborder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizepanel_MouseDown);
            this.rightborder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rightresizepanel_MouseMove);
            this.rightborder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizepanel_MouseUp);
            // 
            // titlepanel
            // 
            this.titlepanel.AutoSize = true;
            this.titlepanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titlepanel.BackColor = System.Drawing.Color.Transparent;
            this.titlepanel.Controls.Add(this.titlelbl);
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlepanel.Location = new System.Drawing.Point(0, 10);
            this.titlepanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(330, 59);
            this.titlepanel.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cosmeticsToolStripMenuItem,
            this.growthDirectionToolStripMenuItem,
            this.lockDisplayToolStripMenuItem,
            this.toolStripSeparator1,
            this.hideDisplayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 130);
            // 
            // cosmeticsToolStripMenuItem
            // 
            this.cosmeticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripMenuItem,
            this.characterToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.borderToolStripMenuItem});
            this.cosmeticsToolStripMenuItem.Name = "cosmeticsToolStripMenuItem";
            this.cosmeticsToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.cosmeticsToolStripMenuItem.Text = "Cosmetics";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titletextbox,
            this.titlefontbtn,
            this.colourToolStripMenuItem});
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.titleToolStripMenuItem.Text = "Title";
            // 
            // titletextbox
            // 
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(100, 31);
            this.titletextbox.Text = "Initiative";
            this.titletextbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titletextbox.ToolTipText = "Title text";
            this.titletextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.titletextbox.TextChanged += new System.EventHandler(this.titletextbox_TextChanged);
            // 
            // titlefontbtn
            // 
            this.titlefontbtn.Name = "titlefontbtn";
            this.titlefontbtn.Size = new System.Drawing.Size(172, 30);
            this.titlefontbtn.Text = "Font";
            this.titlefontbtn.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.colourToolStripMenuItem.Text = "Colour";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click_1);
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersfontbtn,
            this.colourToolStripMenuItem1});
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.characterToolStripMenuItem.Text = "Character Names";
            // 
            // charactersfontbtn
            // 
            this.charactersfontbtn.Name = "charactersfontbtn";
            this.charactersfontbtn.Size = new System.Drawing.Size(149, 30);
            this.charactersfontbtn.Text = "Font";
            this.charactersfontbtn.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // colourToolStripMenuItem1
            // 
            this.colourToolStripMenuItem1.Name = "colourToolStripMenuItem1";
            this.colourToolStripMenuItem1.Size = new System.Drawing.Size(149, 30);
            this.colourToolStripMenuItem1.Text = "Colour";
            this.colourToolStripMenuItem1.Click += new System.EventHandler(this.colourToolStripMenuItem1_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundcolourbtn});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // backgroundcolourbtn
            // 
            this.backgroundcolourbtn.Name = "backgroundcolourbtn";
            this.backgroundcolourbtn.Size = new System.Drawing.Size(149, 30);
            this.backgroundcolourbtn.Text = "Colour";
            this.backgroundcolourbtn.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacityToolStripMenuItem});
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.borderToolStripMenuItem.Text = "Border";
            // 
            // opacityToolStripMenuItem
            // 
            this.opacityToolStripMenuItem.Name = "opacityToolStripMenuItem";
            this.opacityToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.opacityToolStripMenuItem.Text = "Opacity";
            this.opacityToolStripMenuItem.Click += new System.EventHandler(this.opacityToolStripMenuItem_Click);
            // 
            // growthDirectionToolStripMenuItem
            // 
            this.growthDirectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.growdowntoolstripmenuitem,
            this.growuptoolstripmenuitem});
            this.growthDirectionToolStripMenuItem.Name = "growthDirectionToolStripMenuItem";
            this.growthDirectionToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.growthDirectionToolStripMenuItem.Text = "Growth Direction";
            // 
            // growdowntoolstripmenuitem
            // 
            this.growdowntoolstripmenuitem.Name = "growdowntoolstripmenuitem";
            this.growdowntoolstripmenuitem.Size = new System.Drawing.Size(143, 30);
            this.growdowntoolstripmenuitem.Text = "Down";
            this.growdowntoolstripmenuitem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // growuptoolstripmenuitem
            // 
            this.growuptoolstripmenuitem.Name = "growuptoolstripmenuitem";
            this.growuptoolstripmenuitem.Size = new System.Drawing.Size(143, 30);
            this.growuptoolstripmenuitem.Text = "Up";
            this.growuptoolstripmenuitem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // lockDisplayToolStripMenuItem
            // 
            this.lockDisplayToolStripMenuItem.Name = "lockDisplayToolStripMenuItem";
            this.lockDisplayToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.lockDisplayToolStripMenuItem.Text = "Lock Display";
            this.lockDisplayToolStripMenuItem.Click += new System.EventHandler(this.lockDisplayToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // hideDisplayToolStripMenuItem
            // 
            this.hideDisplayToolStripMenuItem.Name = "hideDisplayToolStripMenuItem";
            this.hideDisplayToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.hideDisplayToolStripMenuItem.Text = "Hide Display";
            this.hideDisplayToolStripMenuItem.Click += new System.EventHandler(this.hideDisplayToolStripMenuItem_Click);
            // 
            // topborder
            // 
            this.topborder.BackgroundImage = global::Choreograph.Properties.Resources.border;
            this.topborder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topborder.Dock = System.Windows.Forms.DockStyle.Top;
            this.topborder.Location = new System.Drawing.Point(0, 0);
            this.topborder.Margin = new System.Windows.Forms.Padding(0);
            this.topborder.Name = "topborder";
            this.topborder.Size = new System.Drawing.Size(350, 10);
            this.topborder.TabIndex = 5;
            // 
            // bottomborder
            // 
            this.bottomborder.BackgroundImage = global::Choreograph.Properties.Resources.border;
            this.bottomborder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomborder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomborder.Location = new System.Drawing.Point(10, 387);
            this.bottomborder.Margin = new System.Windows.Forms.Padding(0);
            this.bottomborder.Name = "bottomborder";
            this.bottomborder.Size = new System.Drawing.Size(330, 10);
            this.bottomborder.TabIndex = 6;
            // 
            // mainpanel
            // 
            this.mainpanel.AutoSize = true;
            this.mainpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.Controls.Add(this.characterlistpanel);
            this.mainpanel.Controls.Add(this.titlepanel);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(10, 10);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mainpanel.Size = new System.Drawing.Size(330, 377);
            this.mainpanel.TabIndex = 7;
            // 
            // InitiativeDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 397);
            this.ControlBox = false;
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.bottomborder);
            this.Controls.Add(this.rightborder);
            this.Controls.Add(this.leftborder);
            this.Controls.Add(this.topborder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 85);
            this.Name = "InitiativeDisplayForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InitiativeDisplayForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitiativeDisplayForm_FormClosing);
            this.Load += new System.EventHandler(this.InitiativeDisplayForm_Load);
            this.SizeChanged += new System.EventHandler(this.InitiativeDisplayForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseUp);
            this.titlepanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Panel characterlistpanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lockDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem hideDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosmeticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox titletextbox;
        private System.Windows.Forms.ToolStripMenuItem titlefontbtn;
        private System.Windows.Forms.ToolStripMenuItem charactersfontbtn;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundcolourbtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem1;
        private System.Windows.Forms.Panel leftborder;
        private System.Windows.Forms.Panel rightborder;
        private System.Windows.Forms.Panel bottomborder;
        private System.Windows.Forms.Panel topborder;
        private System.Windows.Forms.Panel titlepanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem growthDirectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem growdowntoolstripmenuitem;
        private System.Windows.Forms.ToolStripMenuItem growuptoolstripmenuitem;
    }
}