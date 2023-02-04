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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            dateTimePicker_Registration.Value = DateTime.Now;
            dateTimePicker_Registration.MinDate = DateTime.Now;
            dateTimePicker_Registration.MaxDate = DateTime.Now;
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
    }
}
