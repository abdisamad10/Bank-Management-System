using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_management_system
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Transaction obj = new Transaction();
            obj.Show();
            this.Hide();
        }

        private void Accounts_Click(object sender, EventArgs e)
        {
           
            AddAccounts obj = new AddAccounts();
            obj.Show();
            this.Hide();

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            obj.Show();
           // this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
