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
        public user_form()
        {
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
    }
}