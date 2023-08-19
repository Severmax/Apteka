using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LoginComp;

namespace apteka
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            StreamReader rs = new StreamReader("pathfile.json");
            UserData.path_Set(rs.ReadLine());
            MedicineData.path_Set(rs.ReadLine());
            AdminData.path_Set(rs.ReadLine());

            rs.Close();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Admin adm = AdminData.GetOneData(this.logintext.Text);
            if (!(adm == null) && Login.Pass_check(adm.password, this.password.Text))
            {
                admin_form adminfrm = new admin_form();
                this.Hide();
                adminfrm.Show();
            }
            else
            {
                User user = UserData.GetOneData(this.logintext.Text);
                if (!(user == null)) 
                {
                    if (Login.Pass_check(user.password, this.password.Text))
                    {
                        user_form userfrm = new user_form();
                        this.Hide();
                        userfrm.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Ви ввели невірний пароль.");
                    }
                    
                }
                
            }    
          }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            register_form registerfrm = new register_form();
            this.Hide();
            registerfrm.Show();
        }
    }
    }

