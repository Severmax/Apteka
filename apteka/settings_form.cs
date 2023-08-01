using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            StreamReader sr = new StreamReader("pathfile.json");
            userdata_textbox.Text = sr.ReadLine();
            meddata_textbox.Text = sr.ReadLine();
            admindata_textbox.Text = sr.ReadLine();
            sr.Close();

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            admin_form adminfrm = new admin_form();
            this.Close();
            adminfrm.Show();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("pathfile.json");
            sw.WriteLine(userdata_textbox.Text);
            sw.WriteLine(meddata_textbox.Text);
            sw.WriteLine(admindata_textbox.Text);

            UserData.path_Set(userdata_textbox.Text);
            MedicineData.path_Set(meddata_textbox.Text);
            AdminData.path_Set(admindata_textbox.Text);

            sw.Close();
        }
    }
}
