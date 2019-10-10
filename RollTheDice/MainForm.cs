using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollTheDice {
    public partial class MainForm : Form {
        public Color DEFAULT_RULE_COLOUR = Color.LightGray;
        bool hold_profiles_dropdown = false;
        ResultsDisplayForm results_display = null;

        public MainForm() {
            InitializeComponent();
        }

        private void RefreshRuleButtons() {
            RuleLayout.Controls.Clear();
            foreach (string rule_name in Secretary.GetActiveProfile().rule_names) {
                RuleLayout.Controls.Add(new RuleButton(this, rule_name, Secretary.GetRule(rule_name).colour));
            }
        }

        private void ShowEditEventRule(StructCollection.Rule rule) {
            RuleEditor new_rule_editor = new EditEventRule(rule);
            this.Enabled = false;
            new_rule_editor.ShowDialog();
            this.Enabled = true;
            RefreshRuleButtons();
        }

        private void ShowEditAttackRule(StructCollection.Rule rule) {
            RuleEditor new_rule_editor = new EditAttackRule(rule);
            this.Enabled = false;
            new_rule_editor.ShowDialog();
            this.Enabled = true;
            RefreshRuleButtons();
        }

        private void CreateNewRule(StructCollection.ResultCollection.Type type) {
            if (type == StructCollection.ResultCollection.Type.Event) {
                ShowEditEventRule(new StructCollection.Rule("", new StructCollection.Events(), -1, -1, new List<StructCollection.Mod>(), new List<StructCollection.Die>(), DEFAULT_RULE_COLOUR));
            }
            else if (type == StructCollection.ResultCollection.Type.Damage) {
                ShowEditAttackRule(new StructCollection.Rule("", new StructCollection.Damage(), -1, -1, new List<StructCollection.Mod>(), new List<StructCollection.Die>(), DEFAULT_RULE_COLOUR));
            }
        }

        public void EditRule(string rule_name) {
            StructCollection.Rule rule = Secretary.GetRule(rule_name);
            if (rule.results.type == StructCollection.ResultCollection.Type.Event) {
                ShowEditEventRule(rule);
            }
            else if (rule.results.type == StructCollection.ResultCollection.Type.Damage) {
                ShowEditAttackRule(rule);
            }
        }

        private void AddProfileToDropdown(string profile_name) {
            int index = 0;
            foreach (ToolStripItem item in ProfilesMenuItem.DropDownItems) {
                if (item.GetType() == typeof(ToolStripSeparator)) {
                    index = ProfilesMenuItem.DropDownItems.IndexOf(item);
                    break;
                }
            }
            ToolStripMenuItem new_profile = new ToolStripMenuItem(profile_name);
            new_profile.Name = profile_name;
            new_profile.Click += Profile_Click;
            new_profile.MouseDown += Profile_MouseDown;
            ProfilesMenuItem.DropDownItems.Insert(index, new_profile);
        }

        private void ProfilesDropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e) {
            if (hold_profiles_dropdown) {
                e.Cancel = true;
                hold_profiles_dropdown = false;
            }
        }

        private void SetupProfiles() {
            ProfilesMenuItem.DropDown.Closing += ProfilesDropDown_Closing;
            foreach (StructCollection.Profile profile in Secretary.GetProfiles()) {
                if (profile.profile_name != "Default") {
                    AddProfileToDropdown(profile.profile_name);
                }
            }
            ActivateProfile(Secretary.GetActiveProfile().profile_name);
        }

        private void Main_Load(object sender, EventArgs e) {
            if (Properties.Settings.Default.LoadMainFormSettings)
            {
                this.Location = Properties.Settings.Default.MainFormLocation;
                this.Size = Properties.Settings.Default.MainFormSize;
                if (Properties.Settings.Default.MainFormState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
            SetupProfiles();
            RefreshRuleButtons();
        }

        private void ReorderRules() {
            List<string> rule_name_order = new List<string>();
            foreach (RuleButton rule in RuleLayout.Controls) {
                rule_name_order.Add(rule.GetRuleName());
            }
            Secretary.ReorderRules(rule_name_order);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            ReorderRules();
            Secretary.WriteRulesToFile();

            Properties.Settings.Default.MainFormState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal) {
                Properties.Settings.Default.MainFormLocation = this.Location;
                Properties.Settings.Default.MainFormSize = this.Size;
            }
            else {
                Properties.Settings.Default.MainFormLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.MainFormSize = this.RestoreBounds.Size;
            }
            Properties.Settings.Default.LoadMainFormSettings = true;
            Properties.Settings.Default.Save();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                try
                {
                    results_display.Close();
                }
                catch (Exception) { }
            }
        }

        private void OpenDisplay()
        {
            if (results_display == null)
            {
                results_display = new ResultsDisplayForm(this);
                results_display.Show();
            }
            results_display.BringToFront();
            this.BringToFront();
        }

        public void DisplayDieRoll(int count, int faces) {
            OpenDisplay();
            results_display.AddRollDisplay(new RollDisplay(DiceTower.RollDie(count, faces), 0, count.ToString() + "d" + faces.ToString()));
            this.Focus();
        }

        public void DisplayRuleRoll(string rule_name) {
            StructCollection.Rule rule = Secretary.GetRule(rule_name);
            OpenDisplay();
            results_display.AddRollDisplay(new RollDisplay(DiceTower.RollDice(rule.dice), DiceTower.SumModifiers(rule.modifiers), rule));
            this.Focus();
        }

        public void NullResultsDisplay() {
            results_display = null;
        }

        public void RemoveRuleButton(RuleButton rule_button) {
            Secretary.RemoveRuleFromProfile(rule_button.GetRuleName());
            RuleLayout.Controls.Remove(rule_button);
        }

        public void DeleteRuleButton(RuleButton rule_button) {
            Secretary.DeleteRule(Secretary.GetRule(rule_button.GetRuleName()));
            RuleLayout.Controls.Remove(rule_button);
        }

        private void EventRuleToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateNewRule(StructCollection.ResultCollection.Type.Event);
        }

        private void attackToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateNewRule(StructCollection.ResultCollection.Type.Damage);
        }

        private void button1_Click(object sender, EventArgs e) {
            DisplayDieRoll(1, 4);
        }

        private void button2_Click(object sender, EventArgs e) {
            DisplayDieRoll(1, 6);
        }

        private void button3_Click(object sender, EventArgs e) {
            DisplayDieRoll(1, 8);
        }

        private void button4_Click(object sender, EventArgs e) {
            DisplayDieRoll(1, 10);
        }

        private void button5_Click(object sender, EventArgs e) {
            DisplayDieRoll(1, 12);
        }

        private void button6_Click(object sender, EventArgs e) {
            DisplayDieRoll(1, 20);
        }

        private void button7_Click(object sender, EventArgs e) {
            DisplayDieRoll(1, 100);
        }

        private void RuleLayout_DragDrop(object sender, DragEventArgs e) {
            RuleButton button = (RuleButton)e.Data.GetData(typeof(RuleButton));
            FlowLayoutPanel destination = (FlowLayoutPanel)sender;
            Point target_spot = destination.PointToClient(new Point(e.X, e.Y));
            int target_index = destination.Controls.GetChildIndex(destination.GetChildAtPoint(target_spot));
            destination.Controls.SetChildIndex(button, target_index);
            destination.Refresh();
        }

        private void RuleLayout_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Text)) {
                if (Control.ModifierKeys == Keys.Shift) {
                    e.Effect = DragDropEffects.Copy;
                }
                else {
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void ActivateProfile(string profile_name) {
            Secretary.SetActiveProfile(profile_name);
            RefreshRuleButtons();
            foreach (ToolStripItem profile in ProfilesMenuItem.DropDownItems) {
                if (profile.GetType() != typeof(ToolStripMenuItem)) {
                    continue;
                }
                if (profile.Text == profile_name) {
                    ((ToolStripMenuItem)profile).Checked = true;
                }
                else {
                    ((ToolStripMenuItem)profile).Checked = false;
                }
            }
            if (profile_name == "Default") {
                importToolStripMenuItem.Visible = false;
                ProfilesMenuItem.Text = "Profiles";
            }
            else {
                importToolStripMenuItem.Visible = true;
                ProfilesMenuItem.Text = profile_name;
            }
        }

        private void NewProfileTextbox_Enter(object sender, EventArgs e) {
            NewProfileTextbox.Text = "";
            NewProfileTextbox.ForeColor = Color.Black;
        }

        private void ToolStripTextBox1_Leave(object sender, EventArgs e) {

            NewProfileTextbox.Text = "New Profile";
            NewProfileTextbox.ForeColor = Color.Gray;
        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e) {
            ToolStripTextBox sender_menuitem = (ToolStripTextBox)sender;
            if (Secretary.ProfileExists(sender_menuitem.Text)) {
                sender_menuitem.ForeColor = Color.Red;
            }
            else {
                sender_menuitem.ForeColor = Color.Black;
            }
        }

        private void Profile_Click(object sender, EventArgs e) {
            ToolStripMenuItem sender_menuitem = (ToolStripMenuItem)sender;
            ActivateProfile(sender_menuitem.Text);
        }

        private void Profile_MouseDown(object sender, EventArgs e) {
            hold_profiles_dropdown = true;
            MouseEventArgs mouse_args = (MouseEventArgs)e;
            if (mouse_args.Button == MouseButtons.Right) {
                ProfileRightClickMenu.Tag = ((ToolStripMenuItem)sender).Text;
                ProfileRightClickMenu.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void CreateProfile(string profile_name) {
            Secretary.CreateProfile(profile_name);
            AddProfileToDropdown(profile_name);
        }

        private void DeleteProfile(string profile_name) {
            if (Secretary.GetActiveProfile().profile_name == profile_name) {
                ActivateProfile("Default");
            }
            Secretary.DeleteProfile(profile_name);
            ProfilesMenuItem.DropDownItems.Remove(ProfilesMenuItem.DropDownItems.Find(profile_name, false)[0]);
        }

        private void NewProfileTextbox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                if (Secretary.ProfileExists(NewProfileTextbox.Text)) {
                    return;
                }
                if (NewProfileTextbox.Text.Trim() != "") {
                    CreateProfile(NewProfileTextbox.Text.Trim());
                    ActivateProfile(NewProfileTextbox.Text.Trim());
                }
                NewProfileTextbox.Text = "";
            }
        }

        private void DeleteProfileButton_Click(object sender, EventArgs e) {
            ToolStripItem button = (ToolStripItem)sender;
            ContextMenuStrip menu = (ContextMenuStrip)button.Owner;
            DeleteProfile((string)menu.Tag);
        }

        private void ruleToProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            new ImportRules(Secretary.GetActiveProfile()).ShowDialog();
            RefreshRuleButtons();
        }
    }
}
