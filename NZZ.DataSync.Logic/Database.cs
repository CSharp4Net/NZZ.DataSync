using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NZZ.DataSync.Logic
{
    public class Database : IDisposable
    {
        public Database()
        {
            Folders = new List<Objects.LocalFolder>();

            AppConfig = new Objects.Config();

            Scheduler = new Objects.Schedule();
        }

        public List<Objects.LocalFolder> Folders = null;

        public Objects.Config AppConfig = null;

        public Objects.Schedule Scheduler = null;

        public static Database Load(string dbFileName)
        {
            Database db = null;

            if (File.Exists(dbFileName))
            {
                // lade vorhandene DB
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Database));
                using (TextReader reader = new StreamReader(dbFileName, Encoding.UTF8))
                {
                    db = (Database)xmlSerializer.Deserialize(reader);
                    reader.Close();
                }
            }
            else
            {
                // keine DB-Datei gefunden, erzeuge neue leere DB
                db = new Database();
            }

            return db;
        }

        public static bool Save(string dbFileName, Database db)
        {
            // überschreibe vorhandene DB-Datei
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Database));
            using (TextWriter writer = new StreamWriter(dbFileName, false, Encoding.UTF8))
            {
                xmlSerializer.Serialize(writer, db);
                writer.Close();
            }
            return false;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}