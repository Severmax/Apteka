using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace apteka
{
    public class AdminData
    {
        private static string path;

        public static void path_Set(string newpath)
        {
            path = newpath;
            
            bool fileExist = File.Exists(path);

            if (!fileExist)
            {
                Admins file = new Admins();
                SaveData(file);
            }
        }

        public static void SaveData(Admins admins)
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Admins));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    xml.Serialize(fs, admins);
                    fs.Close();
                }
                else if (path.Contains(".json"))
                {
                    //...//
                }
                else
                {
                    throw new Exception("Ошибка формата файла");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        public static Admins LoadData() //выгружает с файла данные о пользователях
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Admins));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    Admins admins = (Admins)xml.Deserialize(fs);
                    fs.Close();
                    return admins;
                }
                //else if (path.Contains(".json"))
                //{
                // ....
                //}
                else
                {
                    throw new Exception("Ошибка формата файла");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


        public static void DelData(string login)
        {
            try
            {
                Admin current = GetOneData(login);
                Admins admins = LoadData();
                admins.Data.Remove(current);
                SaveData(admins);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public static Admin GetOneData(string login)
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    Admins admins = LoadData();
                    foreach (Admin admin in admins.Data)
                    {
                        if (admin.login == login) return admin;
                    }
                    //throw new Exception("Даного користувача не існує");
                }
                //else if (path.Contains(".json"))
                //{
                // ....
                //}
                else
                {
                    throw new Exception("Ошибка формата файла");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
