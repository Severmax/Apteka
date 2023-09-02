using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apteka
{
    
    public partial class survey_form : Form
    {
        private User user;
        private Questions qs = QuestionData.LoadData();
        private Question quest;
        private int i = 0;

        private List<string> forWhat;
        private List<string> contraindication;

        public survey_form(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void survey_form_Load(object sender, EventArgs e)
        {
            quest = qs.data[i];
            this.qestion_label.Text = quest.text;
            contraindication = new List<string>();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            user_form userfrm = new user_form(user);
            this.Close();
            userfrm.Show();
        }

        private void qestion_label_Click(object sender, EventArgs e)
        {

        }

        private void yes_button_Click(object sender, EventArgs e)
        {

            if (quest.type == "forWhat") 
            {
                forWhat = quest.ret;
                for (; i < qs.data.Count; i++)
                {
                    if (qs.data[i+1].type== "contraindication") break;
                }
            }
            if (quest.type == "contraindication") 
            {
                foreach (string obg in quest.ret) 
                {
                    contraindication.Add(obg);  
                }
            } 

            if (quest.last)
            {
                UserData.DelData(user.login);
                Users users = UserData.LoadData();
                if (forWhat != null) user.SetMedicines(forWhat, contraindication, user.age);
                users.Data.Add(user);
                UserData.SaveData(users);
                user_form userfrm = new user_form(user);
                this.Close();
                userfrm.Show();
            }
            if (i < qs.data.Count-1)
            {
                i++;
                quest = qs.data[i];
                this.qestion_label.Text = quest.text;
            }
            
            
           
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            if (quest.last)
            {                
                UserData.DelData(user.login);
                Users users = UserData.LoadData();
                if (forWhat != null) user.SetMedicines(forWhat, contraindication, user.age);
                users.Data.Add(user);
                UserData.SaveData(users);
                user_form userfrm = new user_form(user);
                this.Close();
                userfrm.Show();
            }
            if (i < qs.data.Count-1)
            {
                i++;
                quest = qs.data[i];
                this.qestion_label.Text = quest.text;
            }
            

        }
    }
}
