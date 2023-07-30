using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apteka
{

    [Serializable]
    public class Users 
    {
        public List<User> Data = new List<User>(); 
    }

    [Serializable]
    public class User
    {
        public string firstname;
        public string lastname;
        public int age;
        public string login;
        public string password;
        List<string> medicines;

        public User() { }
        public User(string firstname, string lastname, int age, string login, string password) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.login = login;
            this.password = password;
            this.medicines = new List<string>();
        }
        public User(string firstname, string lastname, int age, string login, string password, List<string> medicines)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.login = login;
            this.password = password;
            this.medicines = medicines;
        }
        public void SetMedicines(string forWhat, List<string> contraindication) 
        {
 
        }
    }
}
