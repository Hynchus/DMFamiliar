using System;
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

namespace Choreograph
{
    [Serializable()]
    public struct Character {
        public string id { get; }
        public string name { get; set; }
        public int mod { get; set; }
        public int roll { get; set; }
        public bool locked { get; set; }

        public Character(string name = "", int mod = 0, int roll = 0, bool locked = false)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
            this.mod = mod;
            this.roll = roll;
            this.locked = locked;
        }
    }

    

    static class Storage
    {
        private static string SAVE_FOLDER = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Choreograph");
        private static string CHARACTERS_SAVE_FILE = System.IO.Path.Combine(SAVE_FOLDER, "characters.dmf");
        private static string ACTIVES_SAVE_FILE = System.IO.Path.Combine(SAVE_FOLDER, "actives.dmf");

        public static DataTable characters;

        public static BindingList<string> active_ids { get; set; }


        private static object read_file(string filename)
        {
            if (!File.Exists(filename))
            {
                return null;
            }
            using (var stream = new StreamReader(filename))
            {
                var formatter = new BinaryFormatter();
                var contents = formatter.Deserialize(stream.BaseStream);
                return contents;
            }
        }

        private static bool write_file(string filename, object contents)
        {
            try
            {
                Directory.CreateDirectory(Directory.GetParent(filename).FullName);
                using (var stream = new StreamWriter(filename))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream.BaseStream, contents);
                }
                return true;
            }
            catch (Exception ex) {

            }
            return false;
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
            try
            {
                DataSet tmp = new DataSet();
                tmp.Tables.Add(table.Copy());
                tmp.WriteXml(filename);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static void load_storage()
        {
            characters = read_datatable(CHARACTERS_SAVE_FILE);
            active_ids = (BindingList<string>)read_file(ACTIVES_SAVE_FILE);
            if (active_ids == null)
            {
                active_ids = new BindingList<string>();
            }
        }

        public static void purge_characters()
        {
            characters.AcceptChanges();
            DataView tmp = new DataView(characters);
            tmp.RowFilter = string.Format("Trim({0}) <> '{1}'", "name", "");
            characters = tmp.ToTable();

            BindingList<string> remaining_actives = new BindingList<string>();
            foreach(DataRow character in characters.Rows)
            {
                if (active_ids.Contains(character["id"]))
                {
                    remaining_actives.Add((string)character["id"]);
                }
            }
            active_ids = remaining_actives;
        }

        public static bool save_storage()
        {
            purge_characters();
            if (!write_datatable(CHARACTERS_SAVE_FILE, characters))
            {
                return false;
            }
            if (!write_file(ACTIVES_SAVE_FILE, active_ids))
            {
                return false;
            }
            return true;
        }
    }
}
