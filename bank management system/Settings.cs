using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bank_management_system
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            newpassword.Text = "";
            Thames.SelectedIndex = -1;
        }

        private void applay1_Click(object sender, EventArgs e)
        {
            if (Thames.SelectedIndex == -1)
            {
                MessageBox.Show("Dooro Kalar");
            }
            else if (Thames.SelectedIndex == 0)
            {
                panel1.BackColor = Color.Orange;
            }
            else if (Thames.SelectedIndex == 1)
            {
                panel1.BackColor = Color.Red;
            }
            else if (Thames.SelectedIndex == 2)
            {
                panel1.BackColor = Color.Green;
            }
            else 
            {
                panel1.BackColor = Color.Yellow;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D5EN7KRG;Initial Catalog=BankDb;Integrated Security=True");

        private void applay_Click(object sender, EventArgs e)
        {
            if (newpassword.Text=="")
            {
                MessageBox.Show("Soo Gali Passwordka Cusub");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Admin set AdPassword=@AP where AdId=@Akey", con);
                    cmd.Parameters.AddWithValue("@AP", newpassword.Text);
                    cmd.Parameters.AddWithValue("@Akey", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Waa La Update Gareeyay");
                    con.Close();
                    newpassword.Text = "";
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }

       
    }
}
