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
            this.leftresizepanel = new System.Windows.Forms.Panel();
            this.rightresizepanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hideDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.BackColor = System.Drawing.Color.Azure;
            this.titlelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlelbl.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(3, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(324, 69);
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
            this.characterlistpanel.BackColor = System.Drawing.Color.Azure;
            this.characterlistpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.characterlistpanel.Location = new System.Drawing.Point(3, 73);
            this.characterlistpanel.Name = "characterlistpanel";
            this.characterlistpanel.Size = new System.Drawing.Size(324, 0);
            this.characterlistpanel.TabIndex = 1;
            // 
            // leftresizepanel
            // 
            this.leftresizepanel.BackColor = System.Drawing.Color.Azure;
            this.leftresizepanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.leftresizepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftresizepanel.Location = new System.Drawing.Point(0, 0);
            this.leftresizepanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftresizepanel.Name = "leftresizepanel";
            this.leftresizepanel.Size = new System.Drawing.Size(10, 85);
            this.leftresizepanel.TabIndex = 2;
            this.leftresizepanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizepanel_MouseDown);
            this.leftresizepanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.leftresizepanel_MouseMove);
            this.leftresizepanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizepanel_MouseUp);
            // 
            // rightresizepanel
            // 
            this.rightresizepanel.BackColor = System.Drawing.Color.Azure;
            this.rightresizepanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rightresizepanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightresizepanel.Location = new System.Drawing.Point(340, 0);
            this.rightresizepanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightresizepanel.Name = "rightresizepanel";
            this.rightresizepanel.Size = new System.Drawing.Size(10, 85);
            this.rightresizepanel.TabIndex = 3;
            this.rightresizepanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizepanel_MouseDown);
            this.rightresizepanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rightresizepanel_MouseMove);
            this.rightresizepanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizepanel_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.characterlistpanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.titlelbl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 85);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockDisplayToolStripMenuItem,
            this.toolStripSeparator1,
            this.hideDisplayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            // 
            // lockDisplayToolStripMenuItem
            // 
            this.lockDisplayToolStripMenuItem.Name = "lockDisplayToolStripMenuItem";
            this.lockDisplayToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.lockDisplayToolStripMenuItem.Text = "Lock Display";
            this.lockDisplayToolStripMenuItem.Click += new System.EventHandler(this.lockDisplayToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // hideDisplayToolStripMenuItem
            // 
            this.hideDisplayToolStripMenuItem.Name = "hideDisplayToolStripMenuItem";
            this.hideDisplayToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.hideDisplayToolStripMenuItem.Text = "Hide Display";
            this.hideDisplayToolStripMenuItem.Click += new System.EventHandler(this.hideDisplayToolStripMenuItem_Click);
            // 
            // InitiativeDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(350, 85);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.rightresizepanel);
            this.Controls.Add(this.leftresizepanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 85);
            this.Name = "InitiativeDisplayForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InitiativeDisplayForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitiativeDisplayForm_FormClosing);
            this.Load += new System.EventHandler(this.InitiativeDisplayForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InitiativeDisplayForm_MouseUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Panel characterlistpanel;
        private System.Windows.Forms.Panel leftresizepanel;
        private System.Windows.Forms.Panel rightresizepanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lockDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem hideDisplayToolStripMenuItem;
    }
}