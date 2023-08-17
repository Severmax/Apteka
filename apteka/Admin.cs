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

        public Medicine() 
        {
                    
        }

        public Medicine(string name, string instruction, int age, List<string> forWhat, List<string> contraindications)
        {
            this.name = name;
            this.instruction = instruction;
            this.age = age;
            this.forWhat = forWhat;
            this.contraindications = contraindications;
        }
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
            Medicines meds = MedicineData.LoadData();
            meds.Data.Add(med);
            MedicineData.SaveData(meds);
        }

        public void DelMedicine(Medicine med)
        {
            MedicineData.DelData(med.name);
        }

        public void ReMedicine(Medicine med)
        {
            MedicineData.DelData(med.name);

            Medicines meds = MedicineData.LoadData();
            meds.Data.Add(med);
            MedicineData.SaveData(meds);
        }
    }
}
