namespace bank_management_system
{
    partial class Settings
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NewACC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Thames = new System.Windows.Forms.ComboBox();
            this.applay = new System.Windows.Forms.Button();
            this.applay1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 595);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Image = global::bank_management_system.Properties.Resources.folder_management_3525773_29521001;
            this.pictureBox3.Location = new System.Drawing.Point(0, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // NewACC
            // 
            this.NewACC.AutoSize = true;
            this.NewACC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewACC.ForeColor = System.Drawing.Color.Yellow;
            this.NewACC.Location = new System.Drawing.Point(277, 22);
            this.NewACC.Name = "NewACC";
            this.NewACC.Size = new System.Drawing.Size(158, 43);
            this.NewACC.TabIndex = 9;
            this.NewACC.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(156, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Admin New  Password";
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(152, 208);
            this.newpassword.Multiline = true;
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(299, 48);
            this.newpassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(149, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Thames";
            // 
            // Thames
            // 
            this.Thames.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thames.FormattingEnabled = true;
            this.Thames.Items.AddRange(new object[] {
            "Orange",
            "Red",
            "Green",
            "Yellow"});
            this.Thames.Location = new System.Drawing.Point(152, 395);
            this.Thames.Name = "Thames";
            this.Thames.Size = new System.Drawing.Size(299, 45);
            this.Thames.TabIndex = 19;
            // 
            // applay
            // 
            this.applay.BackColor = System.Drawing.Color.Yellow;
            this.applay.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applay.ForeColor = System.Drawing.Color.Navy;
            this.applay.Location = new System.Drawing.Point(489, 212);
            this.applay.Name = "applay";
            this.applay.Size = new System.Drawing.Size(166, 52);
            this.applay.TabIndex = 24;
            this.applay.Text = "Applay";
            this.applay.UseVisualStyleBackColor = false;
            this.applay.Click += new System.EventHandler(this.applay_Click);
            // 
            // applay1
            // 
            this.applay1.BackColor = System.Drawing.Color.Yellow;
            this.applay1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applay1.ForeColor = System.Drawing.Color.Navy;
            this.applay1.Location = new System.Drawing.Point(480, 390);
            this.applay1.Name = "applay1";
            this.applay1.Size = new System.Drawing.Size(166, 50);
            this.applay1.TabIndex = 26;
            this.applay1.Text = "Applay";
            this.applay1.UseVisualStyleBackColor = false;
            this.applay1.Click += new System.EventHandler(this.applay1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.BackgroundImage = global::bank_management_system.Properties.Resources.cross_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(636, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(328, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Reset";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(683, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.applay1);
            this.Controls.Add(this.applay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Thames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.NewACC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label NewACC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Thames;
        private System.Windows.Forms.Button applay;
        private System.Windows.Forms.Button applay1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}