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
    public partial class RuleEditor : Form {
        protected Color TEXTBOX_TEXT_COLOR = Color.Black;
        protected string starting_rule_name = "";
        protected StructCollection.Rule current_rule;
        protected bool loading = true;

        public virtual void RemoveDie(DieControl die) { }

        public virtual void RemoveModifier(Modifier modifier) { }

        public virtual void DieChanged() {
            if (loading) {
                return;
            }
        }


        protected virtual void RuleForm_Load(object sender, EventArgs e) {
            if (Properties.Settings.Default.LoadRuleFormSettings)
            {
                this.Location = Properties.Settings.Default.RuleFormLocation;
                this.Size = Properties.Settings.Default.RuleFormSize;
                if (Properties.Settings.Default.RuleFormState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
            loading = false;
        }

        protected virtual void RuleForm_Closing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.RuleFormState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal) {
                Properties.Settings.Default.RuleFormLocation = this.Location;
                Properties.Settings.Default.RuleFormSize = this.Size;
            }
            else {
                Properties.Settings.Default.RuleFormLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.RuleFormSize = this.RestoreBounds.Size;
            }
            Properties.Settings.Default.LoadRuleFormSettings = true;
            Properties.Settings.Default.Save();
        }

        protected StructCollection.Rule GetRule() {
            return current_rule;
        }

        protected void AddDie(FlowLayoutPanel layout, DieControl die) {
            layout.Controls.Add(die);
            DieChanged();
        }

        protected void AddModifier(FlowLayoutPanel layout, Modifier modifier) {
            layout.Controls.Add(modifier);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleEditor));
            this.SuspendLayout();
            // 
            // RuleEditor
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RuleEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }
    }
}
