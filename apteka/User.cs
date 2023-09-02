using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<string> medicines;

        public User() 
        {
            
        }
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
        public void SetMedicines(List<string> forWhat, List<string> contraindications, int age)
        {
            Medicines meds = MedicineData.LoadData();

            foreach (var med in meds.Data)
            {
                bool canAdd = true;

                foreach (var obg in med.forWhat)
                {
                    if (!forWhat.Contains(obg))
                    {
                        canAdd = false;
                        break; // Якщо хоча б один forWhat не підходить, то не додавати лік
                    }
                }

                if (canAdd)
                {
                    foreach (var obg1 in med.contraindications)
                    {
                        if (contraindications.Contains(obg1))
                        {
                            canAdd = false;
                            break; // Якщо знайдено хоча б одну протипоказану contraindication, то не додавати лік
                        }
                    }
                }

                if (canAdd)
                {
                    this.medicines.Add(med.name);
                    MessageBox.Show("Медикомент додан - " +med.name);
                }
            }
        }
    }
}
