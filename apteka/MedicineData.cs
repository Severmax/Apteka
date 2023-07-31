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
        private string path;
        public MedicineData(string path) 
        {
            this.path = path;
        } 

        Medicines LoadData()
        {
            try
            {
                if (path.Contains(".xml") || path.Contains(".XML")) 
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Medicines));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    Medicines med = (Medicines)xml.Deserialize(fs);
                    return med;
                }
                if (path.Contains(".json") || path.Contains(".JSON"))
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

        void SaveData(Medicines med) 
        {
            try
            {
                if (path.Contains(".xml") || path.Contains(".XML"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Medicines));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    xml.Serialize(fs, med);
                }
                if (path.Contains(".json") || path.Contains(".JSON"))
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
        Medicine GetOneData(string name)
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

        void DelData(string name) 
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
