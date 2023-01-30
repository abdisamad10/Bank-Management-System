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
    public partial class Depositeform : Form
    {
        public Depositeform()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection("Data Source=LAPTOP-D5EN7KRG;Initial Catalog=BankDb;Integrated Security=True");
         int Balance;
        private void Getnewbalance()
         {
             //con.Open();
             string Query = "select *from Account where ACNum=" + Accountnum.Text+ "";
             SqlCommand cmd = new SqlCommand(Query, con);
             DataTable dt = new DataTable();
             SqlDataAdapter sda = new SqlDataAdapter(cmd);
             sda.Fill(dt);
             foreach (DataRow dr in dt.Rows)
             {
                 //Balancelebel.Text = "Rs" + dr["ACBalance"].ToString();
                 Balance = Convert.ToInt32(dr["ACBalance"].ToString());
             }
              //con.Close();
         }
           private void Depositebtn_Click(object sender, EventArgs e)
         {
             if (Accountnum.Text == "" || Depositeamount.Text == "")
             {
                 MessageBox.Show("Waa khalad Waxa Aad Samesay");
             }
             else
             {
                 Getnewbalance();
                 int newbal = Balance + Convert.ToInt32(Depositeamount.Text);
                 try
                 {
                     con.Open();
                     SqlCommand cmd = new SqlCommand("Update Account set ACBalance=@AB where ACNum=@Akey", con);
                     cmd.Parameters.AddWithValue("@AB", newbal);
                     cmd.Parameters.AddWithValue("@Akey", Accountnum.Text);
                     ;
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Waxaa Laguu Dhigay Account Kaaga" + " $" + Depositeamount.Text);

                     con.Close();
                     Accountnum.Text = "";
                     Depositeamount.Text = "";
                    // Balancelebel.Text = "Your Balance";
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
         
        }
        
    }

