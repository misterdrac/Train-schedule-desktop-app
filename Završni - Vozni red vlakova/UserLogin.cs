using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Završni___Vozni_red_vlakova
{
    public partial class UserLogin : Form
    {
        bool uname = false;
        bool upass = false;
        public UserLogin()
        {
            InitializeComponent();
        }
        private void UserLogin_Load_1(object sender, EventArgs e)
        {
            this.UserLogin_LogInButton.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.satSMS.Text = DateTime.Now.ToString("HH:mm:ss");
            this.satGMD.Text = DateTime.Now.ToString("D");
        }
        private void UserLogin_LogInButton_Click(object sender, EventArgs e)
        {

            ZR_VozniRedVlakovaEntities UserDB = new ZR_VozniRedVlakovaEntities();

            var u = UserDB.User_Table.Where(i => i.User_Name == this.userName_Textbox.Text && i.User_Pass == this.userPass_Textbox.Text).FirstOrDefault();

            if (u != null)
            {

                GlobalVar.user = new Korisnik();
                GlobalVar.user.UserName = u.User_Name;
                GlobalVar.user.Status = u.User_Status;

                if (UserLogin.ActiveForm == ActiveForm)
                {
                    this.Hide();
                    var mainForm = new MainForm();
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.Show();
                }
            }
            
        }
        private void userName_Textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string a = userName_Textbox.Text;
                if (a.Length >= 16)
                {
                    uname = false;
                    userName_Textbox.BackColor = Color.LightGray;
                    //MessageBox.Show("Korisničko ime ne smije sadržavati više od 16 znakova !", "Upozorenje !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    uname = true;
                    userName_Textbox.BackColor = Color.LightGoldenrodYellow;
                }
            }
            catch
            {
                 uname = false;
            }
            Validation();

        }
        private void userPass_Textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string a = userPass_Textbox.Text;
                if (a.Length >= 16)
                {
                    upass = false;
                    userPass_Textbox.BackColor = Color.LightGray;
                    //MessageBox.Show("Korisnički password ne smije sadržavati više od 16 znakova !", "Upozorenje !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    upass = true;
                    userPass_Textbox.BackColor = Color.LightGoldenrodYellow;
                }
            }
            catch
            {
                upass = false;
            }
            Validation();
        }
        private void Validation()
        {
            if (uname && upass)
            {
                this.UserLogin_LogInButton.Enabled = true;
            }
            else
            {
                this.UserLogin_LogInButton.Enabled = false;
            }
        }

        private void UserLogin_RegistrationButton_Click(object sender, EventArgs e)
        {
            //Registration registration = new Registration();
            //registration.Show();

            if (UserLogin.ActiveForm == ActiveForm)
            {
                this.Hide();
                var registration = new Registration();
                registration.Closed += (s, args) => this.Close();
                registration.Show();
            }
        }
    }
}
