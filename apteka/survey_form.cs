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
    
    public partial class survey_form : Form
    {
        private User user;
       

        public survey_form(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void survey_form_Load(object sender, EventArgs e)
        {
            this.qestion_label.Text = "";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            user_form userfrm = new user_form(user);
            this.Close();
            userfrm.Show();
        }
    }
}
