﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;


namespace Choreograph
{

    [Serializable]
    class DisplaySettings : INotifyPropertyChanged
    {
        string _title_text = "Initiative";
        Font _title_font = new Font("Verdana", 24);
        Color _title_font_colour = Color.Black;
        Font _characters_font = new Font("Trebuchet MS", 20);
        Color _characters_font_colour = Color.Black;
        Color _background_colour = Color.White;
        float _border_opacity = 0.5f;
        Direction _growth_direction = Direction.DOWN;

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        [field: NonSerialized]
        private void notify_property_changed([CallerMemberName] string property_name = "")
        {
            PropertyChangedEventHandler tmp = PropertyChanged;   // StackOverflow said this was a good idea to prevent race condition
            if (tmp != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property_name));
            }
        }

        [field: NonSerialized]
        public string TitleText {
            get { return _title_text; }
            set {
                _title_text = value;
                notify_property_changed();
            }
        }

        [field: NonSerialized]
        public Color TitleFontColour {
            get { return _title_font_colour; }
            set {
                _title_font_colour = value;
                notify_property_changed();
            }
        }

        [field: NonSerialized]
        public Font TitleFont {
            get { return _title_font; }
            set {
                _title_font = value;
                notify_property_changed();
            }
        }

        [field: NonSerialized]
        public Color CharactersFontColour {
            get { return _characters_font_colour; }
            set {
                _characters_font_colour = value;
                notify_property_changed();
            }
        }

        [field: NonSerialized]
        public Font CharactersFont {
            get { return _characters_font; }
            set {
                _characters_font = value;
                notify_property_changed();
            }
        }

        [field: NonSerialized]
        public Color BackgroundColour {
            get { return _background_colour; }
            set {
                _background_colour = value;
                notify_property_changed();
            }
        }

        [field: NonSerialized]
        public float BorderOpacity {
            get { return _border_opacity; }
            set {
                _border_opacity = value;
                notify_property_changed();
            }
        }

        [field: NonSerialized]
        public Direction GrowthDirection {
            get { return _growth_direction; }
            set {
                _growth_direction = value;
                notify_property_changed();
            }
        }
    }

    [Serializable]
    class HotkeyDictionary
    {
        // Just realized this is unnecessary, but leaving in for now
    }


    static class Storage
    {
        private static string SAVE_FOLDER = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Choreograph");
        private static string CHARACTERS_SAVE_FILE = System.IO.Path.Combine(SAVE_FOLDER, "characters.dmf");
        private static string ACTIVES_SAVE_FILE = System.IO.Path.Combine(SAVE_FOLDER, "actives.dmf");
        private static string SETTINGS_SAVE_FILE = System.IO.Path.Combine(SAVE_FOLDER, "display_settings.dmf");
        //private static string HOTKEYS_SAVE_FILE = System.IO.Path.Combine(SAVE_FOLDER, "hotkeys.dmf");

        public static DataTable characters;

        public static BindingList<string> active_ids { get; set; }

        public static DisplaySettings settings;


        private static object read_file(string filename)
        {
            try
            {
                using (var stream = new StreamReader(filename))
                {
                    var formatter = new BinaryFormatter();
                    var contents = formatter.Deserialize(stream.BaseStream);
                    return contents;
                }
            }
            catch
            {
                // Missing or corrupted file, we'll ignore
            }
            return null;
        }

        private static bool write_file(string filename, object contents)
        {
            string tmp_filename = string.Join("", filename, "_tmp");
            Directory.CreateDirectory(Directory.GetParent(filename).FullName);
            if (File.Exists(filename))
            {
                File.Move(filename, tmp_filename);
            }
            try
            {
                using (var stream = new StreamWriter(filename))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream.BaseStream, contents);
                }
            }
            catch (Exception ex) {
                File.Delete(filename);
                File.Move(tmp_filename, filename);
                throw ex;
            }
            File.Delete(tmp_filename);
            return true;
        }

        private static DataTable create_characters_table()
        {
            DataTable new_table = new DataTable();
            DataColumn id_column = new DataColumn("id", typeof(string));
            new_table.Columns.Add(id_column);
            DataColumn name_column = new DataColumn("name", typeof(string));
            name_column.DefaultValue = "";
            new_table.Columns.Add(name_column);
            DataColumn mod_column = new DataColumn("mod", typeof(int));
            mod_column.DefaultValue = 0;
            new_table.Columns.Add(mod_column);
            DataColumn roll_column = new DataColumn("roll", typeof(int));
            roll_column.DefaultValue = 0;
            new_table.Columns.Add(roll_column);
            DataColumn locked_column = new DataColumn("locked", typeof(bool));
            locked_column.DefaultValue = false;
            new_table.Columns.Add(locked_column);

            DataColumn[] primary_key = new DataColumn[1];
            primary_key[0] = id_column;
            new_table.PrimaryKey = primary_key;

            return new_table;
        }

        private static DataTable read_datatable(string filename)
        {
            try
            {
                DataSet tmp = new DataSet();
                tmp.ReadXml(filename);
                DataTable table = create_characters_table();
                table.Load(tmp.Tables[0].CreateDataReader());
                return table;
            }
            catch (Exception ex)
            {
                return create_characters_table();
            }
        }

        private static bool write_datatable(string filename, DataTable table)
        {
            string tmp_filename = string.Join("", filename, "_tmp");
            Directory.CreateDirectory(Directory.GetParent(filename).FullName);
            if (File.Exists(filename))
            {
                File.Move(filename, tmp_filename);
            }
            try
            {
                DataSet tmp = new DataSet();
                tmp.Tables.Add(table.Copy());
                tmp.WriteXml(filename);
            }
            catch (Exception ex)
            {
                File.Delete(filename);
                File.Move(tmp_filename, filename);
                throw ex;
            }
            File.Delete(tmp_filename);
            return true;
        }

        public static void load_storage()
        {
            characters = read_datatable(CHARACTERS_SAVE_FILE);
            active_ids = (BindingList<string>)read_file(ACTIVES_SAVE_FILE);
            if (active_ids == null)
            {
                active_ids = new BindingList<string>();
            }
            settings = (DisplaySettings)read_file(SETTINGS_SAVE_FILE);
            if (settings == null)
            {
                settings = new DisplaySettings();
            }
        }

        public static void purge_characters()
        {
            characters.AcceptChanges();
            DataView filter_view = new DataView(characters);
            filter_view.RowFilter = string.Format("Trim({0}) <> '{1}'", "name", "");
            DataTable purged_table = filter_view.ToTable();
            characters.Clear();
            characters.Load(purged_table.CreateDataReader());
            for (int i = active_ids.Count - 1; i >= 0; i--)
            {
                bool exists = false;
                foreach (DataRow character in characters.Rows)
                {
                    if ((string)character["id"] == active_ids[i])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    active_ids.RemoveAt(i);
                }
            }
        }

        public static bool save_storage()
        {
            purge_characters();
            try
            {
                write_datatable(CHARACTERS_SAVE_FILE, characters);
                write_file(ACTIVES_SAVE_FILE, active_ids);
                write_file(SETTINGS_SAVE_FILE, settings);
            }
            catch (Exception ex)
            {
                // Need to log here
                return false;
            }
            return true;
        }
    }
}
