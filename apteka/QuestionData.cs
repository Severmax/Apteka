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
    public class Questions 
    {
        public List<Question> data = new List<Question>();
    }
    public class Question
    {
        public string text;
        public string type;
        public string ret;

        public Question();
        public Question(string text, string type, string ret)
        {
            this.text = text;
            this.type = type;
            this.ret = ret;
        }
    }

    public static class QuestionData
    {
        private static string path;

        public static void path_Set(string newpath) 
        {
            path = newpath;
        }

        public static void SaveData(Questions qs) 
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Questions));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    xml.Serialize(fs, qs);
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
        public static Questions LoadData() //выгружает с файла данные о пользователях
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Questions));
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    Questions qs = (Questions)xml.Deserialize(fs);
                    fs.Close();
                    return qs;
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


        public static void DelData(string text) 
        {
            try
            {
                if (path.Contains(".xml"))
                {
                    Questions qs = LoadData();
                    foreach (Question q in qs.data) 
                    {
                        if (q.text == text) qs.data.Remove(q);
                    }
                    SaveData(qs);
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


        public static void AddData(string text, string type, string ret) 
        {
            try
            {
                Question q = new Question(text, type, ret);
                Questions qs = LoadData();
                qs.data.Add(q);
                SaveData(qs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
    
}
