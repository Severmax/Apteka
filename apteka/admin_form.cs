﻿using System;
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
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }


        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            login_form loginfrm = new login_form();
            this.Close();
            loginfrm.Show();
           
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            settings_form settingsfrm = new settings_form();
            this.Close();
            settingsfrm.Show();
        }

    }
}
