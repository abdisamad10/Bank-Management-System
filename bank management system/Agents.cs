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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();
        } 
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D5EN7KRG;Initial Catalog=BankDb;Integrated Security=True");
        private void DisplayAgents()
        {
            con.Open();
            string Quary = "select * from Agents ";
            SqlDataAdapter sda = new SqlDataAdapter(Quary, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var sd = new DataSet();
            sda.Fill(sd);
            Manageagents.DataSource = sd.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            AName.Text = "";
            APassword.Text = "";
            AAddress.Text = "";
            APhone.Text = "";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || APassword.Text == "" || APhone.Text == "" || AAddress.Text == "")
            {
                MessageBox.Show("Waa khalad Waxa Aad Samesay");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Agents(AName,APassword,APhone,AAddress)values(@AN,@APa,@APh,@AA)", con);
                    cmd.Parameters.AddWithValue("@AN", AName.Text);
                    cmd.Parameters.AddWithValue("@APa", APassword.Text);
                    cmd.Parameters.AddWithValue("@APh", APhone.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddress.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Waa Lagu Soo Daray Agentska");
                    con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void Cencel_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Dooro Agent");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Agents where AId=@Akey", con);
                    cmd.Parameters.AddWithValue("@Akey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent gan waa la Delete Garayey");
                    con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || APassword.Text == "" || AAddress.Text == "" || APhone.Text == "")
            {
                MessageBox.Show("Waa khalad Waxa Aad Samesay");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Agents set AName=@AN,APassword=@APa,AAddress=@AA,APhone=@APh where AId=@Akey", con);
                    cmd.Parameters.AddWithValue("@AN", AName.Text);
                    cmd.Parameters.AddWithValue("@APa", APassword.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddress.Text);
                    cmd.Parameters.AddWithValue("@APh", APhone.Text);
                    cmd.Parameters.AddWithValue("@Akey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Waa La Update Gareeyay");
                    con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            obj.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
          int key = 0;
        private void Manageagents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
       
            AName.Text = Manageagents.SelectedRows[0].Cells[1].Value.ToString();
            APassword.Text = Manageagents.SelectedRows[0].Cells[2].Value.ToString();
            AAddress.Text = Manageagents.SelectedRows[0].Cells[3].Value.ToString();
            APhone.Text = Manageagents.SelectedRows[0].Cells[4].Value.ToString();
            if (AName.Text == "" )
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Manageagents.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        }

        }

