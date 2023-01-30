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
    public partial class AddAccounts : Form
    {
        public AddAccounts()
        {
            InitializeComponent();
            Displayaccounts();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D5EN7KRG;Initial Catalog=BankDb;Integrated Security=True");
        private void Displayaccounts()
        {
            con.Open();
            string Quary = "select * from  Account ";
            SqlDataAdapter sda = new SqlDataAdapter(Quary,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var sd = new DataSet();
            sda.Fill(sd);
            accountW.DataSource = sd.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            ACName.Text = "";
            ACPhone.Text = "";
            ACAddress.Text = "";
            ACGender.SelectedIndex = -1;
            ACOccupation.Text = "";
            ACEducation.SelectedIndex = -1;
            ACIncome.Text = "";
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            if (ACName.Text == "" || ACPhone.Text == "" || ACAddress.Text == "" || ACOccupation.Text == "" || ACGender.SelectedIndex == -1 || ACEducation.SelectedIndex == -1 || ACIncome.Text == "")
            {
                MessageBox.Show("Waa khalad Waxa Aad Samesay");
            } 
            else 
            {
              try{
                  con.Open();
              SqlCommand cmd = new SqlCommand ("insert into Account(ACName,ACPhone,ACAddress,ACOccupation,ACEducation,ACGender,ACIncome,ACBalance)values(@AN,@AP,@AA,@AO,@AE,@AG,@AI,@AB)", con);
                  cmd.Parameters.AddWithValue("@AN",ACName.Text);
                  cmd.Parameters.AddWithValue("@AP",ACPhone.Text);
                  cmd.Parameters.AddWithValue("@AA",ACAddress.Text);
                  cmd.Parameters.AddWithValue("@AO",ACOccupation.Text);
                  cmd.Parameters.AddWithValue("@AE",ACEducation.SelectedItem.ToString());
                  cmd.Parameters.AddWithValue("@AG",ACGender.SelectedItem.ToString());
                  cmd.Parameters.AddWithValue("@AI",ACIncome.Text);
                  cmd.Parameters.AddWithValue("@AB",0);
                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Akoonka waa la Abuuray");
                  con.Close();
                  Reset();
                  Displayaccounts();
             } catch(Exception EX)
              {
                 MessageBox.Show(EX.Message);
             }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cencel_Click(object sender, EventArgs e)
        {

            if ( key == 0)
            {
                MessageBox.Show("Dooro Account");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Account where ACNum=@ACkey", con);
                    cmd.Parameters.AddWithValue("@ACkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account waa la Delete Garayey");
                    con.Close();
                    Reset();
                    Displayaccounts();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }
      

        private void Edit_Click(object sender, EventArgs e)
        {
              if (ACName.Text == "" || ACPhone.Text == "" || ACAddress.Text == "" || ACOccupation.Text == "" || ACGender.SelectedIndex == -1 || ACEducation.SelectedIndex == -1 || ACIncome.Text == "")
            {
                MessageBox.Show("Waa khalad Waxa Aad Samesay");
            } 
            else 
            {
              try{
                  con.Open();
              SqlCommand cmd = new SqlCommand ("Update Account set ACName=@AN,ACPhone=@AP,ACAddress=@AA,ACOccupation=@AO,ACEducation=@AE,ACGender=@AG,ACIncome=@AI  where ACNum=@ACkey", con);
                  cmd.Parameters.AddWithValue("@AN",ACName.Text);
                  cmd.Parameters.AddWithValue("@AP",ACPhone.Text);
                  cmd.Parameters.AddWithValue("@AA",ACAddress.Text);
                  cmd.Parameters.AddWithValue("@AO",ACOccupation.Text);
                  cmd.Parameters.AddWithValue("@AE",ACEducation.SelectedItem.ToString());
                  cmd.Parameters.AddWithValue("@AG",ACGender.SelectedItem.ToString());
                  cmd.Parameters.AddWithValue("@AI",ACIncome.Text);
                  cmd.Parameters.AddWithValue("@ACkey",key);
                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Waa La Update Gareeyay");
                  con.Close();
                  Reset();
                  Displayaccounts();
             } catch(Exception EX)
              {
                 MessageBox.Show(EX.Message);
             }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

      
              int key = 0;
        private void accountW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ACName.Text = accountW.SelectedRows[0].Cells[1].Value.ToString();
            ACPhone.Text = accountW.SelectedRows[0].Cells[2].Value.ToString();
            ACAddress.Text = accountW.SelectedRows[0].Cells[3].Value.ToString();
            ACOccupation.Text = accountW.SelectedRows[0].Cells[4].Value.ToString();
            ACEducation.SelectedItem = accountW.SelectedRows[0].Cells[5].Value.ToString();
            ACGender.SelectedItem = accountW.SelectedRows[0].Cells[6].Value.ToString();
            ACIncome.Text = accountW.SelectedRows[0].Cells[7].Value.ToString();
            if (ACName.Text == "" )
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(accountW.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        }
 }
 
    
