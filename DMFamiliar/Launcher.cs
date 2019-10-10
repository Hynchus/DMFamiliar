using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace DMFamiliar
{
    class Launcher : ApplicationContext
    {
        private ToolStripMenuItem choreograph = null;
        private ToolStripMenuItem rtd = null;
        private ToolStripMenuItem exit = null;
        private ContextMenuStrip menu = null;
        private NotifyIcon tray = null;

        Choreograph.MainForm choreograph_form = null;
        RollTheDice.MainForm rtd_form = null;


        private void show_menu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // silliness; menu.show() gives weird behaviour, apparently this is the way to do it...
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(sender, null);
            }
        }

        private void setup()
        {
            Application.ApplicationExit += new EventHandler(handle_closing);

            choreograph = new ToolStripMenuItem("Choreograph", null, open_choreograph);
            rtd = new ToolStripMenuItem("Roll The Dice", null, open_rtd);
            exit = new ToolStripMenuItem("Close All", null, close_all);
            menu = new ContextMenuStrip();
            tray = new NotifyIcon();

            menu.Items.Clear();
            menu.Items.Add(choreograph);
            menu.Items.Add(rtd);
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add(exit);
            tray.ContextMenuStrip = menu;
            tray.MouseClick += show_menu;
            tray.Icon = DMFamiliar.Properties.Resources.tray;
            tray.Text = "DMFamiliar";
            tray.Visible = true;
        }

        public Launcher()
        {
            setup();
        }

        private void handle_closing(object sender, EventArgs e)
        {
            tray.Visible = false;
            tray = null;
        }

        private void open_choreograph(object sender, EventArgs e)
        {
            if (choreograph_form == null)
            {
                choreograph_form = new Choreograph.MainForm();
            }
            try
            {
                choreograph_form.Show();
                choreograph_form.BringToFront();
            }
            catch (ObjectDisposedException)
            {
                choreograph_form = null;
                open_choreograph(sender, e);
            }
        }

        private void open_rtd(object sender, EventArgs e)
        {
            if (rtd_form == null)
            {
                rtd_form = new RollTheDice.MainForm();
            }
            try
            {
                rtd_form.Show();
                rtd_form.BringToFront();
            }
            catch (ObjectDisposedException)
            {
                rtd_form = null;
                open_rtd(sender, e);
            }
        }

        private void close_all(object sender, EventArgs e)
        {
            try
            {
                choreograph_form.Terminate();
            }
            catch { }
            try
            {
                rtd_form.Close();
            }
            catch { }
            Application.Exit();
        }
    }
}
