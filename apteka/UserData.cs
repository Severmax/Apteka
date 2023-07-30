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
        private string path;
        public UserData(string path) 
        {
            this.path = path;
        }

        void SaveData(Users users) 
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Users));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    xml.Serialize(fs, users);
                }
                if (path.Contains(".json"))
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
        Users LoadData() //выгружает с файла данные о пользователях
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Users));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    Users users = (Users)xml.Deserialize(fs);
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


        void DelData(string login) 
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

        
        User GetOneData(string login) 
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
