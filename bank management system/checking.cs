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
    public partial class checkingform : Form
    {
        public checkingform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-D5EN7KRG;Initial Catalog=BankDb;Integrated Security=True");

        int Balance;
        private void Checkbalance1()
        {
            con.Open();
            string Query = "select *from Account where ACNum=" + Checkbalance.Text + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Balancelebel.Text = "Your Balance Is : $" + dr["ACBalance"].ToString();
                Balance = Convert.ToInt32(dr["ACBalance"].ToString());
            }

            con.Close();
        }
        private void Check_Click(object sender, EventArgs e)
        {

            if (Checkbalance.Text == "")
            {
                MessageBox.Show("Account gaaga Soo Gali");
            }
            else
            {
                  Checkbalance1();
                if (Balancelebel.Text == "Your Balance")
                {
                    MessageBox.Show("Account Kaaga Ma,aha Mid Jira");
                    Checkbalance.Text = "";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
