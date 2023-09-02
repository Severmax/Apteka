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

            bool fileExist = File.Exists(path);

            if (!fileExist) 
            {
                Users file = new Users();
                SaveData(file);
            }
        }

        public static void SaveData(Users users) 
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Users));
                    FileStream fs = new FileStream(path, FileMode.Create);
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
                    User user = GetOneData(login, users);
                    if (user != null) users.Data.Remove(user);
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


        public static User GetOneData(string login, Users users) 
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    foreach (User user in users.Data)
                    {
                        if (user.login == login) return user; 
                    }
                    throw new Exception("Даного користувача не існує");
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
