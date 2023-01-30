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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Depositeform obj = new Depositeform();
            obj.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Withdrawform obj = new Withdrawform();
            obj.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Transfer obj = new Transfer();
            obj.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            checkingform obj = new checkingform();
            obj.Show();
        }



    }
}
  