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
    public partial class EditEventRule : RuleEditor {
        ColorDialog colour_dialog = new ColorDialog();
        private int current_minimum = -1;
        private int current_maximum = -1;



        private void LoadRule(StructCollection.Rule rule) {
            loading = true;
            current_rule = rule;
            colourbtn.BackColor = current_rule.colour;
            LoadTextboxes(rule);
            LoadDice(rule);
            LoadModifiers(rule);
            RefreshResults();
        }

        public EditEventRule(StructCollection.Rule rule) {
            InitializeComponent();
            LoadRule(rule);
        }

        private void LoadDice(StructCollection.Rule rule) {
            DiceLayout.Controls.Clear();
            foreach (StructCollection.Die die in rule.dice) {
                DiceLayout.Controls.Add(new DieControl(this, die.count, die.faces));
            }
        }

        protected virtual void LoadModifiers(StructCollection.Rule rule) {
            ModifierLayout.Controls.Clear();
            foreach (StructCollection.Mod mod in rule.modifiers) {
                ModifierLayout.Controls.Add(new Modifier(this, mod.magnitude, mod.reason));
            }
        }

        private void LoadResults(int minimum, int maximum) {
            if (minimum == current_minimum && maximum == current_maximum) {
                return;
            }
            ResultsLayout.SuspendLayout();
            current_minimum = minimum;
            current_maximum = maximum;
            ResultsLayout.Controls.Clear();
            for (int i = minimum; i < maximum + 1; i++) {
                StructCollection.EventResult new_result = ((StructCollection.Events)current_rule.results).possible_results.Find(x => x.roll_number == i);
                if (new_result.roll_number != i) {
                    ResultsLayout.Controls.Add(new EventResultControl(i, 0, ""));
                }
                else {
                    ResultsLayout.Controls.Add(new EventResultControl(new_result.roll_number, new_result.roll_probability, new_result.result_text));
                }
            }
            ResultsLayout.ResumeLayout(true);
        }

        private void RefreshResults() {
            int minimum = 0;
            int maximum = 0;
            if (DiceLayout.Controls.Count <= 0) {
                ResultsLayout.Controls.Clear();
                return;
            }
            foreach (DieControl dice in DiceLayout.Controls) {
                StructCollection.Die die = dice.GetDie();
                minimum += die.count;
                maximum += die.count * die.faces;
            }
            StoreEventResults(ref current_rule);
            LoadResults(minimum, maximum);
        }

        public override void DieChanged() {
            base.DieChanged();
            RefreshResults();
        }

        public override void RemoveDie(DieControl die) {
            DiceLayout.Controls.Remove(die);
            DieChanged();
        }

        public override void RemoveModifier(Modifier modifier) {
            ModifierLayout.Controls.Remove(modifier);
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void StoreDice(ref StructCollection.Rule rule) {
            rule.dice = new List<StructCollection.Die>();
            foreach (DieControl die in DiceLayout.Controls) {
                rule.dice.Add(die.GetDie());
            }
        }

        private void StoreModifiers(ref StructCollection.Rule rule) {
            rule.modifiers.Clear();
            foreach (Modifier modifier in ModifierLayout.Controls) {
                rule.modifiers.Add(modifier.GetMod());
            }
        }

        private void StoreEventResults(ref StructCollection.Rule rule) {
            foreach (EventResultControl result in ResultsLayout.Controls) {
                ((StructCollection.Events)rule.results).StoreResult(result.GetData());
            }
        }

        private bool SaveRule() {
            if (NameTextbox.Text == "Rule Name") {
                MessageBox.Show("Please give this rule a name", "Name Rule");
                return false;
            }
            if (NameTextbox.Text != starting_rule_name && Secretary.RuleExists(NameTextbox.Text)) {
                MessageBox.Show("A rule with the name '" + NameTextbox.Text + "' already exists.", "Rename Rule");
                return false;
            }
            current_rule.rule_name = NameTextbox.Text;
            StoreDice(ref current_rule);
            StoreModifiers(ref current_rule);
            StoreEventResults(ref current_rule);
            Secretary.SaveRule(starting_rule_name, current_rule);
            return true;
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

        private void SetTextboxPrompts() {
            SetNameTextboxPrompt();
        }

        private void LoadTextboxes(StructCollection.Rule rule) {
            SetTextboxPrompts();
            starting_rule_name = rule.rule_name;
            if (starting_rule_name != "") {
                NameTextbox.Text = rule.rule_name;
                NameTextbox.ForeColor = Color.Black;
            }
        }

        private void NameTextbox_Leave(object sender, EventArgs e) {
            if (NameTextbox.Text == "") {
                SetNameTextboxPrompt();
            }
        }

        private void AddModifierButton_Click(object sender, EventArgs e) {
            AddModifier(ModifierLayout, new Modifier(this, 0, ""));
        }

        protected override void RuleForm_Load(object sender, EventArgs e) {
            base.RuleForm_Load(sender, e);
        }

        protected override void RuleForm_Closing(object sender, FormClosingEventArgs e) {
            base.RuleForm_Closing(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colour_dialog.Color = current_rule.colour;
            if (colour_dialog.ShowDialog() == DialogResult.OK)
            {
                current_rule.colour = colour_dialog.Color;
                colourbtn.BackColor = colour_dialog.Color;
            }
        }
    }
}
