using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apteka
{
    [Serializable]
    public class Medicines 
    { 
        public List<Medicine> Data = new List<Medicine>();    
    }
    [Serializable]
    public class Medicine
    {
        public string name;
        public string instruction;
        public int age;
        public List<string> forWhat;
        public List<string> contraindications;
    }
    [Serializable]
    public class Admins 
    {
        public List<Admin> Data = new List<Admin>();
    }

    [Serializable]
    public class Admin
    {
        public string login;
        public string password;

        public Admin(string login, string password) 
        {
            this.login = login;
            this.password = login;
        }

        public void AddMedicine(Medicine med) 
        { 
        
        }

        public void DelMedicine(Medicine med)
        {

        }

        public void ReMedicine(Medicine med)
        {

        }
    }
}
