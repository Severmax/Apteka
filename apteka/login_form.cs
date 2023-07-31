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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

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
            this.Close();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            register_form registerfrm = new register_form();
            this.Close();
            registerfrm.Show();
        }
    }
    }

