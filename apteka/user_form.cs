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
    public partial class user_form : Form
    {

        private User user;
        public user_form(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити всі ліки?", "Так чи ні", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ////видаляє
            }
            else if(dialogResult == DialogResult.No) 
            {
               /// не видаляє
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            login_form loginfrm = new login_form();
            this.Close();
            loginfrm.Show();
        }

        private void match_button_Click(object sender, EventArgs e)
        {
            survey_form surveyfrm = new survey_form(user);
            this.Close();
            surveyfrm.Show();
        }

        private void user_form_Load(object sender, EventArgs e)
        {
            this.welcome_label.Text = "Привіт, " + user.firstname+".";
        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }
    }
}
