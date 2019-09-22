﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollTheDice {
    public partial class ImportRules : Form {
        StructCollection.Profile profile;

        public ImportRules(StructCollection.Profile profile) {
            InitializeComponent();
            this.profile = profile;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            ListBox.SelectedObjectCollection selected_rules = RulesListbox.SelectedItems;
            if (selected_rules.Count <= 0) {
                MessageBox.Show("No rule selected for import.");
                return;
            }
            foreach (string selected_rule in selected_rules) {
                Secretary.AddRuleToProfile(selected_rule, profile.profile_name);
            }
            this.Close();
        }

        private void ImportRules_Load(object sender, EventArgs e) {
            this.Location = Properties.Settings.Default.ImportRuleFormLocation;
            this.Size = Properties.Settings.Default.ImportRuleFormSize;
            if (Properties.Settings.Default.ImportRuleFormState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }

            this.Text = "Import Rules to " + profile.profile_name;

            foreach (StructCollection.Rule rule in Secretary.GetRules()) {
                if (!profile.rule_names.Contains(rule.rule_name)) {
                    RulesListbox.Items.Add(rule.rule_name);
                }
            }
        }

        private void ImportRules_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.ImportRuleFormState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal) {
                Properties.Settings.Default.ImportRuleFormLocation = this.Location;
                Properties.Settings.Default.ImportRuleFormSize = this.Size;
            }
            else {
                Properties.Settings.Default.ImportRuleFormLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.ImportRuleFormSize = this.RestoreBounds.Size;
            }
            Properties.Settings.Default.Save();
        }
    }
}
