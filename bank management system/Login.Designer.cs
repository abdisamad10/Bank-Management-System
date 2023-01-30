namespace bank_management_system
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Role = new System.Windows.Forms.ComboBox();
            this.ALogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LUsername = new System.Windows.Forms.TextBox();
            this.Bank = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 574);
            this.panel1.TabIndex = 0;
            // 
            // Role
            // 
            this.Role.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.ForeColor = System.Drawing.Color.Navy;
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Admin",
            "Agent"});
            this.Role.Location = new System.Drawing.Point(328, 242);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(337, 37);
            this.Role.TabIndex = 27;
            this.Role.Text = "Role";
            // 
            // ALogin
            // 
            this.ALogin.BackColor = System.Drawing.Color.White;
            this.ALogin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALogin.Location = new System.Drawing.Point(404, 462);
            this.ALogin.Name = "ALogin";
            this.ALogin.Size = new System.Drawing.Size(176, 57);
            this.ALogin.TabIndex = 26;
            this.ALogin.Text = "Login";
            this.ALogin.UseVisualStyleBackColor = false;
            this.ALogin.Click += new System.EventHandler(this.ALogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(324, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // LPassword
            // 
            this.LPassword.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassword.Location = new System.Drawing.Point(328, 405);
            this.LPassword.Multiline = true;
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(337, 40);
            this.LPassword.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(324, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Username";
            // 
            // LUsername
            // 
            this.LUsername.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsername.Location = new System.Drawing.Point(328, 320);
            this.LUsername.Multiline = true;
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(337, 40);
            this.LUsername.TabIndex = 22;
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bank.ForeColor = System.Drawing.Color.Navy;
            this.Bank.Location = new System.Drawing.Point(276, 23);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(420, 37);
            this.Bank.TabIndex = 28;
            this.Bank.Text = "Bank Managemant System";
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.BackColor = System.Drawing.Color.Yellow;
            this.Reset.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Navy;
            this.Reset.Location = new System.Drawing.Point(462, 528);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(71, 26);
            this.Reset.TabIndex = 29;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::bank_management_system.Properties.Resources.bank_building2;
            this.pictureBox2.Location = new System.Drawing.Point(445, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::bank_management_system.Properties.Resources.cross_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(714, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::bank_management_system.Properties.Resources.Logo_group_D12;
            this.pictureBox3.Location = new System.Drawing.Point(-33, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(284, 330);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Group D";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(759, 573);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.ALogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.Button ALogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LUsername;
        private System.Windows.Forms.Label Bank;
        private System.Windows.Forms.Label Reset;
        private System.Windows.Forms.Label label1;
    }
}