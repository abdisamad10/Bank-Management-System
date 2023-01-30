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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int starp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starp += 1;
            progressBG.Value = starp;
            if (progressBG.Value == 100)
            {
                progressBG.Value = 0;
                timer1.Stop();
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
