using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Završni___Vozni_red_vlakova
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            dateTimePicker_Registration.Value = DateTime.Now;
            dateTimePicker_Registration.MinDate = DateTime.Now;
            dateTimePicker_Registration.MaxDate = DateTime.Now;
            registrationUserPass_Textbox.PasswordChar = '*';
        }
        //Disableanje close buttona
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);
        //
        private void Registration_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.satSMS.Text = DateTime.Now.ToString("HH:mm:ss");
            this.satGMD.Text = DateTime.Now.ToString("D");

        }

        private void registrationComebackButton_Click(object sender, EventArgs e)
        {
            if (Registration.ActiveForm == ActiveForm)
            {
                this.Hide();
                var userLogin = new UserLogin();
                userLogin.Closed += (s, args) => this.Close();
                userLogin.Show();
            }

        }
        private bool slika = true;
        private void HideShowButton_Click(object sender, EventArgs e)
        {
            if (slika)
            {
                HideShowButton.Image = Image.FromFile(@"C:\Users\User\OneDrive\Desktop\Završni rad - Izrada aplikacije za vozni red\Materijali, slike, itd\hide_eye_icon.png");
                slika = false;
                registrationUserPass_Textbox.PasswordChar = '\0';
            }
            else
            {
                HideShowButton.Image = Image.FromFile(@"C:\Users\User\OneDrive\Desktop\Završni rad - Izrada aplikacije za vozni red\Materijali, slike, itd\see_eye_icon.png");
                slika = true;
                registrationUserPass_Textbox.PasswordChar = '*';

            }
        }
    }
}
