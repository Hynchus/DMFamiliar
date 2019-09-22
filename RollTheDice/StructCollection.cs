using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Drawing;

namespace RollTheDice {
    public static class StructCollection {
        public struct Rule {
            public string rule_name;
            public ResultCollection results;
            public int minimum;
            public int maximum;
            public List<Mod> modifiers;
            public List<Die> dice;

            public Rule(string name, ResultCollection initial_possible_results, int initial_minimum, int initial_maximum, List<Mod> initial_modifiers, List<StructCollection.Die> initial_dice) {
                this.rule_name = name;
                this.results = initial_possible_results;
                this.minimum = initial_minimum;
                this.maximum = initial_maximum;
                this.modifiers = initial_modifiers;
                this.dice = initial_dice;
            }

            public void Rename(string new_name) {
                this.rule_name = new_name;
            }

            public void LoadXML(ref XmlReader xml) {
                if (xml.IsStartElement()) {
                    if (xml.Name == "rule") {
                        this.rule_name = xml["name"];
                        xml.Read();
                        while (true) {
                            if (xml.IsStartElement()) {
                                if (xml.Name == "dice") {
                                    ReadDiceXML(ref xml, ref this.dice);
                                    continue;
                                }
                                else if (xml.Name == "modifiers") {
                                    ReadModifiersXML(ref xml, ref this.modifiers);
                                    continue;
                                }
                                else if (xml.Name == "results") {
                                    if (xml["type"] == ResultCollection.Type.Event.ToString()) {
                                        results = new Events();
                                    }
                                    else if (xml["type"] == ResultCollection.Type.Damage.ToString()) {
                                        results = new Damage();
                                    }
                                    results.LoadXML(ref xml);
                                    continue;
                                }
                                else {
                                    break;
                                }
                            }
                            if (!xml.Read()) {
                                break;
                            }
                        }
                    }
                }
            }

            public void WriteXML(ref XmlWriter xml) {
                xml.WriteStartElement("rule");
                xml.WriteAttributeString("name", this.rule_name);
                WriteDiceXML(ref xml, this.dice);
                WriteModifiersXML(ref xml, this.modifiers);
                results.WriteXML(ref xml);
                xml.WriteEndElement();
            }
        }

        private static void WriteDiceXML(ref XmlWriter xml, List<Die> dice) {
            if (dice == null) {
                return;
            }
            if (dice.Count <= 0) {
                return;
            }
            xml.WriteStartElement("dice");
            foreach (StructCollection.Die die in dice) {
                xml.WriteStartElement("die");
                xml.WriteAttributeString("count", die.count.ToString());
                xml.WriteAttributeString("faces", die.faces.ToString());
                xml.WriteEndElement();
            }
            xml.WriteEndElement();
        }

        private static void WriteModifiersXML(ref XmlWriter xml, List<Mod> modifiers) {
            if (modifiers == null) {
                return;
            }
            if (modifiers.Count <= 0) {
                return;
            }
            xml.WriteStartElement("modifiers");
            foreach (StructCollection.Mod modifier in modifiers) {
                xml.WriteStartElement("modifier");
                xml.WriteAttributeString("magnitude", modifier.magnitude.ToString());
                xml.WriteAttributeString("reason", modifier.reason);
                xml.WriteEndElement();
            }
            xml.WriteEndElement();
        }

        private static void ReadDiceXML(ref XmlReader xml, ref List<Die> dice) {
            if (dice == null) {
                dice = new List<Die>();
            }
            while (xml.Read()) {
                if (xml.Name == "die") {
                    dice.Add(new Die(Convert.ToInt16(xml["count"]), Convert.ToInt16(xml["faces"])));
                }
                else {
                    break;
                }
            }
        }

        private static void ReadModifiersXML(ref XmlReader xml, ref List<Mod> modifiers) {
            if (modifiers == null) {
                modifiers = new List<Mod>();
            }
            if (xml.Name == "modifiers") {
                while (xml.Read()) {
                    if (xml.Name == "modifier") {
                        modifiers.Add(new Mod(Convert.ToInt16(xml["magnitude"]), xml["reason"]));
                    }
                    else {
                        break;
                    }
                }
            }
        }

        public class Profile {
            public string profile_name;
            public List<string> rule_names;

            public Profile(string profile_name, List<string> rule_names) {
                this.profile_name = profile_name;
                this.rule_names = rule_names;
            }

            public Profile() {
                this.profile_name = "";
                this.rule_names = new List<string>();
            }

            public void AddRuleName(string rule_name) {
                rule_names.Add(rule_name);
            }

            public void RemoveRuleName(string rule_name) {
                rule_names.Remove(rule_name);
            }

            public void LoadXML(ref XmlReader xml) {
                if (xml.IsStartElement()) {
                    if (xml.Name == "profile") {
                        this.profile_name = xml["profile_name"];
                        this.rule_names.Clear();
                        xml.Read();
                        while (true) {
                            if (xml.IsStartElement()) {
                                if (xml.Name == "rule_names") {
                                    xml.Read();
                                    while (true) {
                                        if (xml.IsStartElement()) {
                                            if (xml.Name == "rule_name") {
                                                this.rule_names.Add(xml["name"]);
                                            }
                                            else {
                                                break;
                                            }
                                        }
                                        if (!xml.Read()) {
                                            break;
                                        }
                                    }
                                    continue;
                                }
                                else {
                                    break;
                                }
                            }
                            if (!xml.Read()) {
                                break;
                            }
                        }
                    }
                }
            }

            public void WriteXML(ref XmlWriter xml) {
                xml.WriteStartElement("profile");
                xml.WriteAttributeString("profile_name", profile_name);
                if (rule_names.Count > 0) {
                    xml.WriteStartElement("rule_names");
                    foreach (string rule_name in rule_names) {
                        xml.WriteStartElement("rule_name");
                        xml.WriteAttributeString("name", rule_name);
                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
            }
        }

        public partial class ResultCollection {
            public enum Type { Event, Damage };
            public Type type;

            public virtual (string roll, string result, Color colour) Display(int roll_number, int roll_modifier) { return (roll: "", result: "", colour: Color.Yellow); }

            public virtual void LoadXML(ref XmlReader xml) { }

            protected virtual void WriteResultXML(ref XmlWriter xml) { }

            public void WriteXML(ref XmlWriter xml) {
                xml.WriteStartElement("results");
                xml.WriteAttributeString("type", this.type.ToString());
                WriteResultXML(ref xml);
                xml.WriteEndElement();
            }
        }

        public class Damage : ResultCollection {
            public string damage_type;
            public bool crit_success;
            public bool crit_fail;
            public int crit_success_threshold;
            public int crit_fail_threshold;
            public List<Die> dice;
            public List<Mod> modifiers;

            public Damage() {
                this.type = Type.Damage;
                this.damage_type = "";
                this.crit_success = true;
                this.crit_fail = true;
                this.crit_success_threshold = 20;
                this.crit_fail_threshold = 1;
                this.dice = new List<Die> ();
                this.modifiers = new List<Mod>();
            }

            public override (string roll, string result, Color colour) Display(int roll_number, int roll_modifier) {
                if (crit_success && roll_number >= crit_success_threshold) {
                    return (roll: ("Natural " + roll_number.ToString()), result: "Critical Hit!\n" + (DiceTower.RollDice(dice) + DiceTower.RollDice(dice) + DiceTower.SumModifiers(modifiers)).ToString() + " " + damage_type + " damage!", colour: Color.Blue);
                }
                else if (crit_fail && roll_number <= crit_fail_threshold) {
                    return (roll: ("Natural " + roll_number.ToString()), result: "Critical Fail!", colour: Color.Red);
                }
                return (roll: (roll_number + roll_modifier).ToString(), result: DiceTower.RollDice(dice, modifiers).ToString() + " " + damage_type + " damage", colour: Color.Green);
            }

            public override void LoadXML(ref XmlReader xml) {
                base.LoadXML(ref xml);
                this.damage_type = xml["damage_type"];
                if (xml["critical_success"] != null) {
                    crit_success = Convert.ToBoolean(xml["critical_success"]);
                }
                else {
                    crit_success = true;
                }
                if (xml["critical_fail"] != null) {
                    crit_fail = Convert.ToBoolean(xml["critical_fail"]);
                }
                else {
                    crit_fail = true;
                }
                this.crit_success_threshold = Convert.ToInt16(xml["crit_success_threshold"]);
                this.crit_fail_threshold = Convert.ToInt16(xml["crit_fail_threshold"]);
                
                xml.Read();
                while (true) {
                    if (xml.IsStartElement()) {
                        if (xml.Name == "dice") {
                            ReadDiceXML(ref xml, ref this.dice);
                            continue;
                        }
                        else if (xml.Name == "modifiers") {
                            ReadModifiersXML(ref xml, ref this.modifiers);
                            continue;
                        }
                        else {
                            break;
                        }
                    }
                    if (!xml.Read()) {
                        break;
                    }
                }
            }

            protected override void WriteResultXML(ref XmlWriter xml) {
                base.WriteResultXML(ref xml);
                xml.WriteAttributeString("damage_type", this.damage_type);
                xml.WriteAttributeString("critical_success", this.crit_success.ToString());
                xml.WriteAttributeString("critical_fail", this.crit_fail.ToString());
                xml.WriteAttributeString("crit_success_threshold", this.crit_success_threshold.ToString());
                xml.WriteAttributeString("crit_fail_threshold", this.crit_fail_threshold.ToString());
                WriteDiceXML(ref xml, this.dice);
                WriteModifiersXML(ref xml, this.modifiers);
            }
        }

        public class Events : ResultCollection {
            public List<EventResult> possible_results;

            public Events() {
                this.type = Type.Event;
                this.possible_results = new List<EventResult>();
            }

            public override (string roll, string result, Color colour) Display(int roll_number, int roll_modifier) {
                return (roll: (roll_number + roll_modifier).ToString(), result: possible_results.Find(x => x.roll_number == roll_number + roll_modifier).result_text, colour: Color.Yellow);
            }

            public void StoreResult(EventResult result) {
                int existing_index = possible_results.FindIndex(x => x.roll_number == result.roll_number);
                if (existing_index > -1) {
                    possible_results.RemoveAt(existing_index);
                }
                if (result.result_text != "") {
                    possible_results.Add(result);
                }
            }

            public override void LoadXML(ref XmlReader xml) {
                base.LoadXML(ref xml);
                xml.Read();
                while (true) {
                    if (xml.IsStartElement()) {
                        if (xml.Name == "result") {
                            EventResult new_result = new EventResult();
                            new_result.LoadXML(ref xml);
                            possible_results.Add(new_result);
                        }
                        else {
                            break;
                        }
                    }
                    if (!xml.Read()) {
                        break;
                    }
                }
            }

            protected override void WriteResultXML(ref XmlWriter xml) {
                base.WriteResultXML(ref xml);
                foreach (EventResult result in possible_results) {
                    xml.WriteStartElement("result");
                    result.WriteXML(ref xml);
                    xml.WriteEndElement();
                }
            }
        }

        public struct EventResult {
            public int roll_number;
            public float roll_probability;
            public string result_text;

            public EventResult(int number, float probability, string text) : this() {
                this.roll_number = number;
                this.roll_probability = probability;
                this.result_text = text;
            }

            public void WriteXML(ref XmlWriter xml) {
                xml.WriteAttributeString("roll_number", roll_number.ToString());
                xml.WriteAttributeString("roll_probability", roll_probability.ToString());
                xml.WriteAttributeString("result_text", result_text);
            }

            public void LoadXML(ref XmlReader xml) {
                roll_number = Convert.ToInt16(xml["roll_number"]);
                roll_probability = Convert.ToInt16(xml["roll_probability"]);
                result_text = xml["result_text"];
            }
        }

        public struct Die {
            public int count;
            public int faces;

            public Die(int count, int faces) {
                this.count = count;
                this.faces = faces;
            }
        }

        public struct Mod {
            public int magnitude;
            public string reason;

            public Mod(int value, string reason) {
                this.magnitude = value;
                this.reason = reason;
            }
        }
    }
}
