namespace Završni___Vozni_red_vlakova
{
    partial class UserLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserLogin_LogInButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPass_Textbox = new System.Windows.Forms.TextBox();
            this.userName_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelVrijeme = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.satGMD = new System.Windows.Forms.Label();
            this.satSMS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UserLogin_RegistrationButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelVrijeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vozni red vlakova";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.UserLogin_RegistrationButton);
            this.panel2.Controls.Add(this.UserLogin_LogInButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.userPass_Textbox);
            this.panel2.Controls.Add(this.userName_Textbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(176, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 241);
            this.panel2.TabIndex = 1;
            // 
            // UserLogin_LogInButton
            // 
            this.UserLogin_LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserLogin_LogInButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogin_LogInButton.Location = new System.Drawing.Point(194, 154);
            this.UserLogin_LogInButton.Name = "UserLogin_LogInButton";
            this.UserLogin_LogInButton.Size = new System.Drawing.Size(129, 30);
            this.UserLogin_LogInButton.TabIndex = 8;
            this.UserLogin_LogInButton.Text = "Prijavi se !";
            this.UserLogin_LogInButton.UseVisualStyleBackColor = true;
            this.UserLogin_LogInButton.Click += new System.EventHandler(this.UserLogin_LogInButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // userPass_Textbox
            // 
            this.userPass_Textbox.Location = new System.Drawing.Point(179, 128);
            this.userPass_Textbox.Name = "userPass_Textbox";
            this.userPass_Textbox.PasswordChar = '*';
            this.userPass_Textbox.Size = new System.Drawing.Size(165, 20);
            this.userPass_Textbox.TabIndex = 6;
            this.userPass_Textbox.TextChanged += new System.EventHandler(this.userPass_Textbox_TextChanged);
            // 
            // userName_Textbox
            // 
            this.userName_Textbox.Location = new System.Drawing.Point(179, 73);
            this.userName_Textbox.Name = "userName_Textbox";
            this.userName_Textbox.Size = new System.Drawing.Size(165, 20);
            this.userName_Textbox.TabIndex = 5;
            this.userName_Textbox.TextChanged += new System.EventHandler(this.userName_Textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Korisnička lozinka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Korisničko ime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prijava korisnika";
            // 
            // PanelVrijeme
            // 
            this.PanelVrijeme.BackColor = System.Drawing.Color.Moccasin;
            this.PanelVrijeme.Controls.Add(this.label5);
            this.PanelVrijeme.Controls.Add(this.satGMD);
            this.PanelVrijeme.Controls.Add(this.satSMS);
            this.PanelVrijeme.Location = new System.Drawing.Point(577, 132);
            this.PanelVrijeme.Name = "PanelVrijeme";
            this.PanelVrijeme.Size = new System.Drawing.Size(175, 116);
            this.PanelVrijeme.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.3F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vrijeme :";
            // 
            // satGMD
            // 
            this.satGMD.AutoSize = true;
            this.satGMD.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.satGMD.Location = new System.Drawing.Point(14, 74);
            this.satGMD.Name = "satGMD";
            this.satGMD.Size = new System.Drawing.Size(13, 19);
            this.satGMD.TabIndex = 7;
            this.satGMD.Text = " ";
            // 
            // satSMS
            // 
            this.satSMS.AutoSize = true;
            this.satSMS.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satSMS.Location = new System.Drawing.Point(14, 51);
            this.satSMS.Name = "satSMS";
            this.satSMS.Size = new System.Drawing.Size(13, 19);
            this.satSMS.TabIndex = 1;
            this.satSMS.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserLogin_RegistrationButton
            // 
            this.UserLogin_RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserLogin_RegistrationButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogin_RegistrationButton.Location = new System.Drawing.Point(194, 190);
            this.UserLogin_RegistrationButton.Name = "UserLogin_RegistrationButton";
            this.UserLogin_RegistrationButton.Size = new System.Drawing.Size(129, 30);
            this.UserLogin_RegistrationButton.TabIndex = 9;
            this.UserLogin_RegistrationButton.Text = "Registriraj se !";
            this.UserLogin_RegistrationButton.UseVisualStyleBackColor = true;
            this.UserLogin_RegistrationButton.Click += new System.EventHandler(this.UserLogin_RegistrationButton_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelVrijeme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozni red vlakova - prijava korisnika";
            this.Load += new System.EventHandler(this.UserLogin_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelVrijeme.ResumeLayout(false);
            this.PanelVrijeme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox userPass_Textbox;
        private System.Windows.Forms.TextBox userName_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UserLogin_LogInButton;
        private System.Windows.Forms.Panel PanelVrijeme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label satGMD;
        private System.Windows.Forms.Label satSMS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button UserLogin_RegistrationButton;
    }
}