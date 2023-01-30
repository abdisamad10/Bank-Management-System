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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D5EN7KRG;Initial Catalog=BankDb;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            LUsername.Text = "";
            LPassword.Text = "";
            Role.SelectedIndex = -1;
            Role.Text = "Role";
        }

        private void ALogin_Click(object sender, EventArgs e)
        {
            if (Role.SelectedIndex == -1)
            {
                MessageBox.Show("Dooro Role");
            }
            else if (Role.SelectedIndex == 0)
            {
                if (LUsername.Text == "" || LPassword.Text == "")
                {
                    MessageBox.Show(" Soo Gali Username Iyo Passwordka ");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Admin where AdName='" + LUsername.Text + "' and AdPassword='" + LPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Agents obj = new Agents();
                        obj.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Waa Khalad Usernameka  Ama Passwordka  Aad Galisay ");
                        LUsername.Text = "";
                        LPassword.Text = "";
                    }
                    con.Close();
                }
            }
            else
            {
                if (LUsername.Text == "" || LPassword.Text == "")
                {
                    MessageBox.Show(" Soo Gali Username Iyo Passwordka ");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from  Agents where AName='" + LUsername.Text + "' and APassword='" + LPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        
                        MainMenu obj = new MainMenu();
                        obj.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Waa Khalad Usernameka  Ama Passwordka  Adminka ");
                        LUsername.Text = "";
                        LPassword.Text = "";
                    }
                    con.Close();
                }

             }

            }
        }
    }
