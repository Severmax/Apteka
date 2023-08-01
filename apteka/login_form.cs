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
            if (logintext.Text == "admin")

            {
                admin_form adminfrm = new admin_form();
                this.Hide();
                adminfrm.Show();
            }
            else
            {
                user_form userfrm = new user_form();
                this.Hide();
                userfrm.Show();
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

