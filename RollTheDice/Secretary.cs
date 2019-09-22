using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace RollTheDice {
    public static class Secretary {
        private static string SAVE_FOLDER = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RollTheDice");
        private static string SAVE_FILE = System.IO.Path.Combine(SAVE_FOLDER, "save.xml");
        private static List<StructCollection.Profile> profiles;
        private static string active_profile;
        private static List<StructCollection.Rule> rules = null;


        private static void LoadXMLFile(string file) {
            rules = new List<StructCollection.Rule>();
            profiles = new List<StructCollection.Profile>();
            active_profile = "Default";

            if (!File.Exists(file)) {
                return;
			}
			XmlReader xml = XmlReader.Create(new FileStream(file, FileMode.Open), new XmlReaderSettings() { CloseInput = true });
			try {
				while (xml != null) {
					if (xml.IsStartElement()) {
						if (xml.Name == "rules") {
                            xml.Read();
							while (true) {
                                if (xml.IsStartElement()) {
                                    if (xml.Name == "rule") {
                                        StructCollection.Rule rule = new StructCollection.Rule("", new StructCollection.ResultCollection(), -1, -1, new List<StructCollection.Mod>(), new List<StructCollection.Die>());
                                        rule.LoadXML(ref xml);
                                        rules.Add(rule);
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
                            continue;
						}
                        else if (xml.Name == "profiles") {
                            active_profile = xml["active_profile"];
                            xml.Read();
                            while (true) {
                                if (xml.IsStartElement()) {
                                    if (xml.Name == "profile") {
                                        StructCollection.Profile new_profile = new StructCollection.Profile();
                                        new_profile.LoadXML(ref xml);
                                        profiles.Add(new_profile);
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
                            continue;
                        }
					}
                    if (!xml.Read()) {
                        break;
                    }
                }
			}
			catch {
                xml.Close();
				return;
			}
            xml.Close();
		}

        public static void LoadFile() {
            LoadXMLFile(SAVE_FILE);
        }

        private static void EnsureFileLoaded() {
            if (rules == null || profiles == null) {
                LoadXMLFile(SAVE_FILE);
            }
        }

        private static void WriteProfilesToXMLFile(ref XmlWriter xml) {
            if (profiles == null) {
                return;
            }
            xml.WriteStartElement("profiles");
            xml.WriteAttributeString("active_profile", active_profile);
            foreach(StructCollection.Profile profile in profiles) {
                profile.WriteXML(ref xml);
            }
            xml.WriteEndElement();
        }

        private static void WriteRulesToXMLFile(string file) {
            EnsureFileLoaded();
            System.IO.Directory.CreateDirectory(SAVE_FOLDER);
            XmlWriter xml = XmlWriter.Create(file);
            xml.WriteStartDocument();
            xml.WriteStartElement("save");
            WriteProfilesToXMLFile(ref xml);
            xml.WriteStartElement("rules");
            foreach (StructCollection.Rule rule in GetRules()) {
                rule.WriteXML(ref xml);
            }
            xml.WriteEndElement();
            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Close();
        }

        public static void WriteRulesToFile() {
            EnsureFileLoaded();
            WriteRulesToXMLFile(SAVE_FILE);
        }

        public static void ReorderRules(List<string> rule_name_order) {
            StructCollection.Profile updated_profile = GetActiveProfile();
            updated_profile.rule_names = rule_name_order;
            int profile_index = profiles.FindIndex(x => x.profile_name == updated_profile.profile_name);
            if (profile_index < 0) {
                profiles.Add(updated_profile);
            }
            else {
                profiles[profile_index] = updated_profile;
            }
        }

        public static List<StructCollection.Rule> GetRules() {
            EnsureFileLoaded();
            return rules;
        }

        public static void SaveRule(string previous_name, StructCollection.Rule rule) {
            EnsureFileLoaded();
            int outdated_rule_index = rules.FindIndex(x => x.rule_name == previous_name);
            if (outdated_rule_index < 0) {
                rules.Insert(0, rule);
            }
            else {
                rules[outdated_rule_index] = rule;
                if (active_profile != "Default") {
                    RemoveRuleFromProfile(active_profile, previous_name);
                }
                RemoveRuleFromProfile("Default", previous_name);
            }
            AddRuleToProfile(rule, active_profile);
        }

        public static void SaveRule(StructCollection.Rule rule) {
            SaveRule(rule.rule_name, rule);
        }

        public static void RemoveRuleFromProfile(string profile_name, string rule_name) {
            profiles.Find(x => x.profile_name == profile_name).rule_names.Remove(rule_name);
        }

        public static void RemoveRuleFromProfile(string rule_name) {
            if (active_profile == "Default") {
                return;
            }
            RemoveRuleFromProfile(active_profile, rule_name);
        }

        public static void DeleteRule(StructCollection.Rule rule) {
            foreach (StructCollection.Profile profile in profiles) {
                profile.rule_names.Remove(rule.rule_name);
            }
            rules.Remove(rule);
        }

        public static StructCollection.Rule GetRule(string name) {
            EnsureFileLoaded();
            foreach (StructCollection.Rule rule in rules) {
                if (rule.rule_name == name) {
                    return rule;
                }
            }
            return new StructCollection.Rule();
        }

        public static void RenameRule(string old_name, string new_name) {
            EnsureFileLoaded();
            int outdated_rule_index = rules.FindIndex(x => x.rule_name == old_name);
            if (outdated_rule_index < 0) {
                return;
            }
            else {
                rules[outdated_rule_index].Rename(new_name);
            }
        }

        public static bool RuleExists(string name) {
            EnsureFileLoaded();
            foreach (StructCollection.Rule rule in rules) {
                if (rule.rule_name == name) {
                    return true;
                }
            }
            return false;
        }

        public static void CreateProfile(string profile_name) {
            EnsureFileLoaded();
            if (!ProfileExists(profile_name)) {
                profiles.Add(new StructCollection.Profile(profile_name, new List<string>()));
            }
        }

        public static void AddRuleToProfile(StructCollection.Rule rule, string profile_name) {
            EnsureFileLoaded();
            int profile_index = profiles.FindIndex(x => x.profile_name == profile_name);
            if (profile_index < 0) {
                return;
            }
            StructCollection.Profile updated_profile = profiles[profile_index];
            updated_profile.rule_names.Insert(0, rule.rule_name);
            profiles[profile_index] = updated_profile;
            if (profile_name != "Default") {
                AddRuleToProfile(rule, "Default");
            }
        }

        public static void AddRuleToProfile(string rule_name, string profile_name) {
            EnsureFileLoaded();
            profiles.Find(x => x.profile_name == profile_name).rule_names.Add(rule_name);
        }

        public static void DeleteProfile(string profile_name) {
            EnsureFileLoaded();
            int profile_index = profiles.FindIndex(x => x.profile_name == profile_name);
            profiles.RemoveAt(profile_index);
        }

        public static StructCollection.Profile GetProfile(string profile_name) {
            EnsureFileLoaded();
            StructCollection.Profile profile = profiles.Find(x => x.profile_name == profile_name);
            return (profile ?? new StructCollection.Profile(profile_name, new List<string>()));
        }

        public static List<StructCollection.Profile> GetProfiles() {
            EnsureFileLoaded();
            return profiles;
        }

        public static bool ProfileExists(string profile_name) {
            EnsureFileLoaded();
            return (profiles.FindIndex(x => x.profile_name == profile_name) >= 0);
        }

        public static void SetActiveProfile(string profile_name) {
            EnsureFileLoaded();
            active_profile = profile_name;
        }

        public static StructCollection.Profile GetActiveProfile() {
            EnsureFileLoaded();
            return GetProfile(active_profile);
        }
    }
}
