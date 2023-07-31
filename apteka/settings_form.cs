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
    public partial class settings_form : Form
    {
        public settings_form()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            admin_form adminfrm = new admin_form();
            this.Close();
            adminfrm.Show();
        }
    }
}
