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
    public partial class med_form : Form
    {
        private Admin admin;
        public med_form(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            admin_form adminfrm = new admin_form(admin);
            this.Close();
            adminfrm.Show();
        }

        private void contraindications_label_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
            string name = this.medname_textbox.Text;
            string instruction = this.description_textbox.Text;
            int age;
            if (!(int.TryParse(this.age_textbox.Text, out age)))
            {
                MessageBox.Show("Ви не правильно вказали вік!");
            }
            else
            {
                string fw = this.indication_textbox.Text;
                fw = fw.Replace(", ", "\n"); // заменяем ", " на символ переноса строки
                List<string> forWhat = fw.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string str_c = this.contraindications_textbox.Text;
                str_c = str_c.Replace(", ", "\n");
                List<string> contraindications = str_c.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries).ToList();

                Medicine med = new Medicine(name, instruction, age, forWhat, contraindications); 
                admin.AddMedicine(med);

                admin_form adminfrm = new admin_form(admin);
                this.Close();
                adminfrm.Show();
            }
        }
    }
}
