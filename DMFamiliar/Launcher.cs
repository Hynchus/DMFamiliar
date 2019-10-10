using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Deployment.Application;


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

        private void update_version()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                if (ApplicationDeployment.CurrentDeployment.CurrentVersion != ApplicationDeployment.CurrentDeployment.UpdatedVersion)
                {
                    Application.Restart();
                }
            }
        }

        private void check_update(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                if (ApplicationDeployment.CurrentDeployment.CurrentVersion != ApplicationDeployment.CurrentDeployment.UpdatedVersion)
                {
                    update_version();
                }
            }
        }

        private void setup()
        {
            Application.ApplicationExit += new EventHandler(handle_closing);

            menu = new ContextMenuStrip();
            tray = new NotifyIcon();

            menu.Items.Clear();
            menu.Items.Add(new ToolStripMenuItem("Choreograph", null, open_choreograph));
            menu.Items.Add(new ToolStripMenuItem("Roll The Dice", null, open_rtd));
            menu.Items.Add(new ToolStripSeparator());
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                if (ApplicationDeployment.CurrentDeployment.UpdatedVersion != ApplicationDeployment.CurrentDeployment.CurrentVersion)
                {
                    menu.Items.Add(new ToolStripMenuItem("Update Available", null, check_update));
                }
                else
                {
                    // Not actually showing the balloontip, but putting this here anyways
                    tray.BalloonTipText = string.Join("", "v.", ApplicationDeployment.CurrentDeployment.CurrentVersion);
                }
            }
            menu.Items.Add(new ToolStripMenuItem("Quit", null, close_all));
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
            try
            {
                tray.Visible = false;
                tray = null;
            }
            catch { }
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
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
