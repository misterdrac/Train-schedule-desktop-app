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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            satSMS.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.satSMS.Text = DateTime.Now.ToString("HH:mm:ss");
            this.satGMD.Text = DateTime.Now.ToString("D");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckLogin();
            
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        public void CheckLogin()
        {   //napravit if petlju koja provjerava je li admin ili user pa enableat odredene buttone MenuStripa
            //napravit SQL Server bazu s ID, username, userpass, statusom dje rucno mijenjam vrijednosti, promjenit u app.configu connection string i dodat svoj model za DATA
              

            if (GlobalVar.user.Status == "A")
            {
                this.ToolStripMenuItem_Home.Visible = true;
                this.ToolStripMenuItem_TicketSelling.Visible = true;
                this.ToolStripMenuItem_Logistics.Visible = true;
                this.ToolStripMenuItem_Contacts.Visible = true;
                this.ToolStripMenuItem_Information.Visible = true;
                this.ToolStripMenuItem_Exit.Visible = true;
                //this.ToolStripMenuItem_Exit.Margin = new System.Windows.Forms.Padding(0, 310, 5, 0);
                this.ToolStripMenuItem_Information.Margin = new System.Windows.Forms.Padding(0, 505, 5, -280);
            }
            else
            {

                this.ToolStripMenuItem_Home.Visible = false;
                this.ToolStripMenuItem_TicketSelling.Visible = false;
                this.ToolStripMenuItem_Logistics.Visible = false;
                this.ToolStripMenuItem_Contacts.Visible = false;
                this.ToolStripMenuItem_Exit.Margin = new System.Windows.Forms.Padding(0, 310, 5, 0);
                this.ToolStripMenuItem_Information.Margin = new System.Windows.Forms.Padding(0, 535, 5, -280);
            }


        }
    }
}
