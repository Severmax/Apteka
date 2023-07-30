using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apteka
{

    public struct medicine
    {
        string name;
        string instruction;
        int age;
        List<string> forWhat;
        List<string> contraindications;
    }
    public class Admin
    {
        public string login;
        public string password;

        public Admin(string login, string password) 
        {
            this.login = login;
            this.password = login;
        }

        public void AddMedicine(medicine med) 
        { 
        
        }

        public void DelMedicine(medicine med)
        {

        }

        public void ReMedicine(medicine med)
        {

        }
    }
}
