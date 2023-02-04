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

namespace Završni___Vozni_red_vlakova
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private const int WS_CAPTION = 0x00C00000;

        // Removes the close button in the caption bar
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;

                // This disables the close button
                // myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;

                // this appears to completely remove the close button
                myCp.Style &= WS_CAPTION;

                return myCp;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckLogin();
            //var sm = GetSystemMenu(Handle, false);
            //EnableMenuItem(sm, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);
            //[DllImport("user32")]
            //static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
            //[DllImport("user32")]
            //static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

            //const int MF_BYCOMMAND = 0;
            //const int MF_DISABLED = 2;
            //const int SC_CLOSE = 0xF060;
        }
        public void CheckLogin()
        {  
            if (GlobalVar.user.Status != "Korisnik")
            {
                this.ToolStripMenuItem_Home.Visible = true;
                this.ToolStripMenuItem_TicketSelling.Visible = true;
                this.ToolStripMenuItem_PersonelTransportChange.Visible = true;
                this.ToolStripMenuItem_Logistics.Visible = true;
                this.ToolStripMenuItem_TransportLinesChange.Visible = true;
                this.ToolStripMenuItem_Contact.Visible = true;
                this.ToolStripMenuItem_Information.Visible = true;
                this.ToolStripMenuItem_Exit.Visible = true;
            }
            else
            {
                this.ToolStripMenuItem_Home.Visible = true;
                this.ToolStripMenuItem_TicketSelling.Visible = true;
                this.ToolStripMenuItem_PersonelTransportChange.Visible = false;
                this.ToolStripMenuItem_Logistics.Visible = true;
                this.ToolStripMenuItem_TransportLinesChange.Visible = false;
                this.ToolStripMenuItem_Contact.Visible = true;
                this.ToolStripMenuItem_Information.Visible = true;
                this.ToolStripMenuItem_Exit.Visible = true;
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.satSMS.Text = DateTime.Now.ToString("HH:mm:ss");
            this.satGMD.Text = DateTime.Now.ToString("D");

        }

        private void ToolStripMenuItem_Home_Click(object sender, EventArgs e)
        {
            MainForm mainForm1 = new MainForm();
            this.Hide();
            mainForm1.Show();
            
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_Exit_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_Contact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.TopLevel = false;
            this.FormPanel.Controls.Add(contact);
            this.FormPanel.Location = new Point(269, 80);
            this.FormPanel.Size = new Size(1229, 870);
            contact.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            contact.Dock = DockStyle.Fill;
            contact.Show();
        }

        private void ToolStripMenuItem_Information_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.TopLevel = false;
            this.FormPanel.Controls.Add(information);
            this.FormPanel.Location = new Point(269, 80);
            this.FormPanel.Size = new Size(1229, 870);
            information.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            information.Dock = DockStyle.Fill;
            information.Show();
        }

        private void ToolStripMenuItem_TicketSelling_Click(object sender, EventArgs e)
        {
            TicketSelling ticketSelling = new TicketSelling();
            ticketSelling.TopLevel = false;
            this.FormPanel.Controls.Add(ticketSelling);
            this.FormPanel.Location = new Point(269, 80);
            this.FormPanel.Size = new Size(1229, 870);
            ticketSelling.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ticketSelling.Dock = DockStyle.Fill;
            ticketSelling.Show();
        }
    }
}
