using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace apteka
{
    public class MedicineData
    {
        private static string path;

        public static void path_Set(string newpath)
        {
            path = newpath;
        }

        public static Medicines LoadData()
        {
            try
            {
                if (path.Contains(".xml") || path.Contains(".XML")) 
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Medicines));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    Medicines med = (Medicines)xml.Deserialize(fs);
                    fs.Close();
                    return med;
                }
                else if (path.Contains(".json") || path.Contains(".JSON"))
                {
                    //....//
                }
                else throw new Exception("Ошибка формата");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static void SaveData(Medicines med) 
        {
            try
            {
                if (path.Contains(".xml") || path.Contains(".XML"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Medicines));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    xml.Serialize(fs, med);
                    fs.Close();
                }
                else if (path.Contains(".json") || path.Contains(".JSON"))
                {
                    //....//
                }
                else throw new Exception("Ошибка формата");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        public static Medicine GetOneData(string name)
        {
            try
            {
                Medicines meds = LoadData();
                foreach (Medicine med in meds.Data) 
                {
                    if (name == med.name)
                    {
                        return med;
                    }
                    else throw new Exception("Данного препарата не существует.");
                } 
                SaveData(meds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static void DelData(string name) 
        {
            try
            {
                Medicine current = GetOneData(name);
                Medicines meds = LoadData();
                meds.Data.Remove(current);
                SaveData(meds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
            
        }

        
    }
}
