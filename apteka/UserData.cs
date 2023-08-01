using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace apteka
{
    class UserData
    {
        private static string path;

        public static void path_Set(string newpath) 
        {
            path = newpath;
        }

        public static void SaveData(Users users) 
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Users));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    xml.Serialize(fs, users);
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
        public static Users LoadData() //выгружает с файла данные о пользователях
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Users));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    Users users = (Users)xml.Deserialize(fs);
                    fs.Close();
                    return users;
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
                if (path.Contains(".xml"))
                {
                    Users users = LoadData();
                    foreach (User user in users.Data) 
                    {
                        if (user.login == login) users.Data.Remove(user);
                    }
                    SaveData(users);
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
        
        }


        public static User GetOneData(string login) 
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    Users users = LoadData();
                    foreach (User user in users.Data)
                    {
                        if (user.login == login) return user; 
                    }
                    throw new Exception("Данного пользователя не существует");
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
