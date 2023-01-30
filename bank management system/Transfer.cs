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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-D5EN7KRG;Initial Catalog=BankDb;Integrated Security=True");
        int Balance;
        private void Checkavialable()
        {
            //  con.Open();
            string Query = "select *from Account where ACNum=" + From.Text + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                balancele.Text = "$" + dr["ACBalance"].ToString();
                Balance = Convert.ToInt32(dr["ACBalance"].ToString());
            }

            // con.Close();
        }
        private void Getnewbalance()
        {
            con.Open();
            string Query = "select *from Account where ACNum=" +From.Text+ "";
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (From.Text == "")
            {
                MessageBox.Show(" Soo Gali Account Number ka ");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Account where ACNum='" + From.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Checkavialable();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Account Aad Galisay Ma,aha Mid Jira ");
                    From.Text = "";

                }
                con.Close();
            }
        }
            private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (To.Text == "")
            {
                MessageBox.Show(" Soo Gali Account Number Aad U Rabtit ");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Account where ACNum='" + To.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Checkavialable();
                    MessageBox.Show("Account Gan Waa Mid Jira ");
                    con.Close();
                    if (To.Text == From.Text)
                    {
                        MessageBox.Show("Account Kan Wax Diraya Iyo Kan Kale Waa Isku Mid");
                        To.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Account Aad Galisay Ma,aha Mid Jira ");
                    To.Text = "";

                }
                con.Close();
            }
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Addbal()
        {
            Getnewbalance();
            int newbal = Balance + Convert.ToInt32(TransferAmnt.Text);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Account set ACBalance=@AB where ACNum=@Akey", con);
                cmd.Parameters.AddWithValue("@AB", newbal);
                cmd.Parameters.AddWithValue("@Akey", To.Text);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        private void substracbal()
        {
            Getnewbalance();
            int newbal = Balance - Convert.ToInt32(TransferAmnt.Text);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Account set ACBalance=@AB where ACNum=@Akey", con);
                cmd.Parameters.AddWithValue("@AB", newbal);
                cmd.Parameters.AddWithValue("@Akey", From.Text);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        private void Transfer1()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Transfer (TrSrc,TrDest,TrAmnt,TrDate)values(@TS,@TD,@TA,@TDA)", con);
                cmd.Parameters.AddWithValue("@TS", From.Text);
                cmd.Parameters.AddWithValue("@TD", To.Text);
                cmd.Parameters.AddWithValue("@TA", TransferAmnt.Text);
                cmd.Parameters.AddWithValue("@TDA", DateTime.Now.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Waxaa  Loo Wareejiye Account kan" + " $" + TransferAmnt.Text);
                con.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                con.Close();
            }
        }
        private void transfer12_Click(object sender, EventArgs e)
        {

            if (To.Text == "" || From.Text == "" || TransferAmnt.Text == "")
            {
                MessageBox.Show("Wax Baa Khaldaysaa !");
            }
            else if (Convert.ToInt16(TransferAmnt.Text) > Balance)
            {
                MessageBox.Show(" Balance Kaaga Kugu Mafilno");
            }
            else
            {
                Transfer1();
                substracbal();
                Addbal();

            }
            From.Text = "";
            To.Text = "";
            TransferAmnt.Text = "";
        }

    }
}
