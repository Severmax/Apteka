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
        public survey_form()
        {
            InitializeComponent();
        }

        private void survey_form_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            user_form userfrm = new user_form();
            this.Close();
            userfrm.Show();
        }
    }
}
