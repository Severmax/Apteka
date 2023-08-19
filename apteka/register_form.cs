using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginComp;

namespace apteka
{
    public partial class register_form : Form
    {
        public register_form()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            login_form loginfrm = new login_form();
            this.Close();
            loginfrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Login.Cyrillic_check(this.login_textbox.Text))
            {
                MessageBox.Show("Присутня кирилиця в логіні");
            }
            else if (Login.Cyrillic_check(this.password_textbox.Text))
            {
                MessageBox.Show("Присутня кирилиця в паролі");
            }
            else if (!Login.Pass_check(this.password_textbox.Text, this.password2_textbox.Text))
            {
                MessageBox.Show("Паролі не совпадають");
            }
            else
            {
                User user = new User(name_textbox.Text, surname_textbox.Text, int.Parse(age_textbox.Text), login_textbox.Text,
                    password_textbox.Text);
                Users users = UserData.LoadData();
                users.Data.Add(user);
                UserData.SaveData(users);

                login_form loginfrm = new login_form();
                this.Close();
                loginfrm.Show();

            }


        }
    }
}
