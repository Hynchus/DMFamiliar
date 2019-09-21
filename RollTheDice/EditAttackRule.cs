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
    public partial class EditAttackRule : RuleEditor {


        private bool IsNewRule() {
            return starting_rule_name == "";
        }

        private void LoadTextboxes(StructCollection.Rule rule) {
            SetTextboxPrompts();
            starting_rule_name = rule.rule_name;
            if (starting_rule_name != "") {
                NameTextbox.Text = rule.rule_name;
                NameTextbox.ForeColor = Color.Black;
            }
            if (((StructCollection.Damage)rule.results).damage_type != "") {
                DamageTypeTextbox.Text = ((StructCollection.Damage)rule.results).damage_type;
                DamageTypeTextbox.ForeColor = Color.Black;
            }
        }

        private void LoadDice(StructCollection.Rule rule) {
            DiceLayout.Controls.Clear();
            if (IsNewRule()) {
                DiceLayout.Controls.Add(new DieControl(this, 1, 20));
                DamageDiceLayout.Controls.Add(new DieControl(this, 1, 6));
                return;
            }
            foreach (StructCollection.Die die in rule.dice) {
                DiceLayout.Controls.Add(new DieControl(this, die.count, die.faces));
            }
            DamageDiceLayout.Controls.Clear();
            foreach (StructCollection.Die die in ((StructCollection.Damage)rule.results).dice) {
                DamageDiceLayout.Controls.Add(new DieControl(this, die.count, die.faces));
            }
        }

        private void LoadModifiers(StructCollection.Rule rule) {
            ModifierLayout.Controls.Clear();
            foreach (StructCollection.Mod mod in rule.modifiers) {
                ModifierLayout.Controls.Add(new Modifier(this, mod.magnitude, mod.reason));
            }
            DamageModifiersLayout.Controls.Clear();
            foreach (StructCollection.Mod mod in ((StructCollection.Damage)rule.results).modifiers) {
                DamageModifiersLayout.Controls.Add(new Modifier(this, mod.magnitude, mod.reason));
            }
        }

        private void LoadFunctionalities(StructCollection.Rule rule) {
            StructCollection.Damage result = (StructCollection.Damage)rule.results;
            criticalSuccessToolStripMenuItem.Checked = result.crit_success;
            CriticalSuccessThresholdTextbox.Text = result.crit_success_threshold.ToString();
            criticalFailureToolStripMenuItem.Checked = result.crit_fail;
            CriticalFailThresholdTextbox.Text = result.crit_fail_threshold.ToString();
        }

        private void LoadRule(StructCollection.Rule rule) {
            loading = true;
            current_rule = rule;
            LoadTextboxes(rule);
            LoadDice(rule);
            LoadModifiers(rule);
            LoadFunctionalities(rule);
        }

        public EditAttackRule(StructCollection.Rule rule) {
            InitializeComponent();
            LoadRule(rule);
        }

        public override void RemoveDie(DieControl die) {
            DiceLayout.Controls.Remove(die);
            DamageDiceLayout.Controls.Remove(die);
        }

        public override void RemoveModifier(Modifier modifier) {
            ModifierLayout.Controls.Remove(modifier);
            DamageModifiersLayout.Controls.Remove(modifier);
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void StoreDice(ref StructCollection.Rule rule) {
            rule.dice = new List<StructCollection.Die>();
            foreach (DieControl die in DiceLayout.Controls) {
                rule.dice.Add(die.GetDie());
            }
            // Store damage dice
            ((StructCollection.Damage)current_rule.results).dice = new List<StructCollection.Die>();
            foreach (DieControl die in DamageDiceLayout.Controls) {
                ((StructCollection.Damage)current_rule.results).dice.Add(die.GetDie());
            }
        }

        private void StoreModifiers(ref StructCollection.Rule rule) {
            rule.modifiers.Clear();
            foreach (Modifier modifier in ModifierLayout.Controls) {
                rule.modifiers.Add(modifier.GetMod());
            }
            // Store damage modifiers
            ((StructCollection.Damage)current_rule.results).modifiers = new List<StructCollection.Mod>();
            foreach (Modifier modifier in DamageModifiersLayout.Controls) {
                ((StructCollection.Damage)current_rule.results).modifiers.Add(modifier.GetMod());
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (SaveRule()) {
                this.Close();
            }
        }

        private void AddDieButton_Click(object sender, EventArgs e) {
            AddDie(DiceLayout, new DieControl(this, 1, 20));
        }

        private void NameTextbox_Enter(object sender, EventArgs e) {
            if (NameTextbox.Text == "Rule Name") {
                NameTextbox.Text = "";
                NameTextbox.ForeColor = TEXTBOX_TEXT_COLOR;
            }
        }

        private void DamageTypeTextbox_Enter(object sender, EventArgs e) {
            if (DamageTypeTextbox.Text == "Damage Type") {
                DamageTypeTextbox.Text = "";
                DamageTypeTextbox.ForeColor = TEXTBOX_TEXT_COLOR;
            }
        }

        private void SetDamageTypeTextboxPrompt() {
            DamageTypeTextbox.Text = "Damage Type";
            DamageTypeTextbox.ForeColor = Color.Gray;
        }

        private void SetTextboxPrompts() {
            SetNameTextboxPrompt();
            SetDamageTypeTextboxPrompt();
        }

        private void NameTextbox_Change(object sender, EventArgs e) {
            this.Text = NameTextbox.Text;
            if (Secretary.RuleExists(NameTextbox.Text)) {
                NameTextbox.ForeColor = Color.Red;
            }
            else {
                NameTextbox.ForeColor = Color.Black;
            }
        }

        private void SetNameTextboxPrompt() {
            NameTextbox.Text = "Rule Name";
            NameTextbox.ForeColor = Color.Gray;
            this.Text = "Rule";
        }

        private void NameTextbox_Leave(object sender, EventArgs e) {
            if (NameTextbox.Text == "") {
                SetNameTextboxPrompt();
            }
        }

        private void DamageTypeTextbox_Leave(object sender, EventArgs e) {
            if (DamageTypeTextbox.Text == "") {
                SetDamageTypeTextboxPrompt();
            }
        }

        private void AddModifierButton_Click(object sender, EventArgs e) {
            AddModifier(ModifierLayout, new Modifier(this, 0, ""));
        }

        private void AddDamageDieButton_Click(object sender, EventArgs e) {
            AddDie(DamageDiceLayout, new DieControl(this,1, 6));
        }

        private void AddDamageModifier_Click(object sender, EventArgs e) {
            AddModifier(DamageModifiersLayout, new Modifier(this, 0, ""));
        }

        private void TypeTextbox_Leave(object sender, EventArgs e) {
            if (DamageTypeTextbox.Text == "") {
                SetTextboxPrompts();
            }
        }

        private void TypeTextbox_Enter(object sender, EventArgs e) {
            if (DamageTypeTextbox.Text == "Damage Type") {
                DamageTypeTextbox.Text = "";
                DamageTypeTextbox.ForeColor = TEXTBOX_TEXT_COLOR;
            }
        }

        private void EditAttackRule_Load(object sender, EventArgs e) {
            this.RuleForm_Load(sender, e);
        }

        private void EditAttackRule_FormClosing(object sender, FormClosingEventArgs e) {
            this.RuleForm_Closing(sender, e);
        }

        private void StoreFunctionalities(ref StructCollection.Rule rule) {
            StructCollection.Damage result = (StructCollection.Damage)rule.results;
            result.crit_success = criticalSuccessToolStripMenuItem.Checked;
            result.crit_success_threshold = Convert.ToInt16(CriticalSuccessThresholdTextbox.Text);
            result.crit_fail = criticalFailureToolStripMenuItem.Checked;
            result.crit_fail_threshold = Convert.ToInt16(CriticalFailThresholdTextbox.Text);
        }

        private bool SaveRule() {
            if (NameTextbox.Text == "Rule Name") {
                NameTextbox.ForeColor = Color.Red;
                MessageBox.Show("Please give this rule a name", "Name Rule");
                return false;
            }
            if (NameTextbox.Text != starting_rule_name && Secretary.RuleExists(NameTextbox.Text)) {
                MessageBox.Show("A rule with the name '" + NameTextbox.Text + "' already exists.", "Rename Rule");
                return false;
            }
            current_rule.rule_name = NameTextbox.Text;
            ((StructCollection.Damage)current_rule.results).damage_type = DamageTypeTextbox.Text != "Damage Type" ? DamageTypeTextbox.Text : "";
            StoreDice(ref current_rule);
            StoreModifiers(ref current_rule);
            StoreFunctionalities(ref current_rule);
            Secretary.SaveRule(starting_rule_name, current_rule);
            return true;
        }

        private void CriticalSuccessToolStripMenuItem_Click(object sender, EventArgs e) {
            criticalSuccessToolStripMenuItem.Checked = !criticalSuccessToolStripMenuItem.Checked;
        }

        private void CriticalFailureToolStripMenuItem_Click(object sender, EventArgs e) {
            criticalFailureToolStripMenuItem.Checked = !criticalFailureToolStripMenuItem.Checked;
        }

        private void CriticalSuccessThresholdTextbox_Leave(object sender, EventArgs e) {
            if (Convert.ToInt16(CriticalSuccessThresholdTextbox.Text) <= Convert.ToInt16(CriticalFailThresholdTextbox.Text)) {
                CriticalSuccessThresholdTextbox.Text = (Convert.ToInt16(CriticalFailThresholdTextbox.Text) + 1).ToString();
            }
        }

        private void CriticalFailThresholdTextbox_Leave(object sender, EventArgs e) {
            if (Convert.ToInt16(CriticalFailThresholdTextbox.Text) >= Convert.ToInt16(CriticalSuccessThresholdTextbox.Text)) {
                CriticalFailThresholdTextbox.Text = (Convert.ToInt16(CriticalSuccessThresholdTextbox.Text) - 1).ToString();
            }
        }
    }
}
