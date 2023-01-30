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
    public partial class Withdrawform : Form
    {
        public Withdrawform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-D5EN7KRG;Initial Catalog=BankDb;Integrated Security=True");
        int Balance;
        private void Getnewbalance()
        {
            con.Open();
            string Query = "select *from Account where ACNum=" + Accountwd.Text + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //Balancelebel.Text = "Rs" + dr["ACBalance"].ToString();
                Balance = Convert.ToInt32(dr["ACBalance"].ToString());
            }

            con.Close();
        }
        private void Withdraw()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Transaction (TName,TDate,TAmnt,TACNum)values(@TN,@TD,@TA,@TAC)", con);
                cmd.Parameters.AddWithValue("@TN", "Withdraw");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", Amountwd.Text);
                cmd.Parameters.AddWithValue("@TAC", Accountwd.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Waa La Deposite Gareeyey");
                con.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                con.Close();
            }
        }
        private void Depositebtn_Click(object sender, EventArgs e)
        {

            if (Accountwd.Text == "" || Amountwd.Text == "")
            {
                MessageBox.Show("Waa khalad Waxa Aad Samesay");
            }
            else
            {
                Getnewbalance();
                if (Balance < Convert.ToInt32(Amountwd.Text))
                {
                    MessageBox.Show("Balance Kaaga Kugu Mafilno");
                }
                else
                {
                    int newbal = Balance - Convert.ToInt32(Amountwd.Text);
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update Account set ACBalance=@AB where ACNum=@Akey", con);
                        cmd.Parameters.AddWithValue("@AB", newbal);
                        cmd.Parameters.AddWithValue("@Akey", Accountwd.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Wxaad  Kala Baxdey Account Kaaga " + " $" + Amountwd.Text);
                        con.Close();
                        Accountwd.Text = "";
                        Amountwd.Text = "";
                       

                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
