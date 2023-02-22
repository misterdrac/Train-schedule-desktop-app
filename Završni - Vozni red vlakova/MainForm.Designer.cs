namespace Završni___Vozni_red_vlakova
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.satGMD = new System.Windows.Forms.Label();
            this.satSMS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TicketSelling = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_PersonelTransportChange = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Logistics = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TransportLinesChange = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Contact = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Information = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(301, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vozni red vlakova";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.satGMD);
            this.panel2.Controls.Add(this.satSMS);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1159, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 116);
            this.panel2.TabIndex = 2;
            // 
            // satGMD
            // 
            this.satGMD.AutoSize = true;
            this.satGMD.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.3F, System.Drawing.FontStyle.Bold);
            this.satGMD.Location = new System.Drawing.Point(20, 77);
            this.satGMD.Name = "satGMD";
            this.satGMD.Size = new System.Drawing.Size(0, 22);
            this.satGMD.TabIndex = 2;
            // 
            // satSMS
            // 
            this.satSMS.AutoSize = true;
            this.satSMS.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.3F, System.Drawing.FontStyle.Bold);
            this.satSMS.Location = new System.Drawing.Point(20, 51);
            this.satSMS.Name = "satSMS";
            this.satSMS.Size = new System.Drawing.Size(0, 22);
            this.satSMS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.3F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vrijeme :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Home,
            this.ToolStripMenuItem_TicketSelling,
            this.ToolStripMenuItem_PersonelTransportChange,
            this.ToolStripMenuItem_Logistics,
            this.ToolStripMenuItem_TransportLinesChange,
            this.ToolStripMenuItem_Contact,
            this.ToolStripMenuItem_Information,
            this.ToolStripMenuItem_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 916);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Izbornik";
            // 
            // ToolStripMenuItem_Home
            // 
            this.ToolStripMenuItem_Home.AutoSize = false;
            this.ToolStripMenuItem_Home.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItem_Home.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_Home.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Home.Image")));
            this.ToolStripMenuItem_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_Home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Home.Margin = new System.Windows.Forms.Padding(0, 120, 0, 60);
            this.ToolStripMenuItem_Home.Name = "ToolStripMenuItem_Home";
            this.ToolStripMenuItem_Home.Size = new System.Drawing.Size(224, 40);
            this.ToolStripMenuItem_Home.Text = "Home";
            this.ToolStripMenuItem_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolStripMenuItem_Home.Click += new System.EventHandler(this.ToolStripMenuItem_Home_Click);
            // 
            // ToolStripMenuItem_TicketSelling
            // 
            this.ToolStripMenuItem_TicketSelling.AutoSize = false;
            this.ToolStripMenuItem_TicketSelling.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItem_TicketSelling.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_TicketSelling.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_TicketSelling.Image")));
            this.ToolStripMenuItem_TicketSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_TicketSelling.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_TicketSelling.Margin = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.ToolStripMenuItem_TicketSelling.Name = "ToolStripMenuItem_TicketSelling";
            this.ToolStripMenuItem_TicketSelling.Size = new System.Drawing.Size(224, 40);
            this.ToolStripMenuItem_TicketSelling.Text = "Kupnja karata";
            this.ToolStripMenuItem_TicketSelling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolStripMenuItem_TicketSelling.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolStripMenuItem_TicketSelling.Click += new System.EventHandler(this.ToolStripMenuItem_TicketSelling_Click);
            // 
            // ToolStripMenuItem_PersonelTransportChange
            // 
            this.ToolStripMenuItem_PersonelTransportChange.AutoSize = false;
            this.ToolStripMenuItem_PersonelTransportChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItem_PersonelTransportChange.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_PersonelTransportChange.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_PersonelTransportChange.Image")));
            this.ToolStripMenuItem_PersonelTransportChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_PersonelTransportChange.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_PersonelTransportChange.Margin = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.ToolStripMenuItem_PersonelTransportChange.Name = "ToolStripMenuItem_PersonelTransportChange";
            this.ToolStripMenuItem_PersonelTransportChange.Padding = new System.Windows.Forms.Padding(4, 0, 4, 40);
            this.ToolStripMenuItem_PersonelTransportChange.Size = new System.Drawing.Size(224, 46);
            this.ToolStripMenuItem_PersonelTransportChange.Text = "Promjena putnih linija";
            this.ToolStripMenuItem_PersonelTransportChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolStripMenuItem_PersonelTransportChange.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripMenuItem_PersonelTransportChange.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolStripMenuItem_PersonelTransportChange.Click += new System.EventHandler(this.ToolStripMenuItem_PersonelTransportChange_Click);
            // 
            // ToolStripMenuItem_Logistics
            // 
            this.ToolStripMenuItem_Logistics.AutoSize = false;
            this.ToolStripMenuItem_Logistics.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItem_Logistics.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_Logistics.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Logistics.Image")));
            this.ToolStripMenuItem_Logistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_Logistics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Logistics.Margin = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.ToolStripMenuItem_Logistics.Name = "ToolStripMenuItem_Logistics";
            this.ToolStripMenuItem_Logistics.Size = new System.Drawing.Size(224, 36);
            this.ToolStripMenuItem_Logistics.Text = "Logistika";
            this.ToolStripMenuItem_Logistics.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolStripMenuItem_Logistics.Click += new System.EventHandler(this.ToolStripMenuItem_Logistics_Click);
            // 
            // ToolStripMenuItem_TransportLinesChange
            // 
            this.ToolStripMenuItem_TransportLinesChange.AutoSize = false;
            this.ToolStripMenuItem_TransportLinesChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItem_TransportLinesChange.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_TransportLinesChange.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_TransportLinesChange.Image")));
            this.ToolStripMenuItem_TransportLinesChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_TransportLinesChange.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_TransportLinesChange.Margin = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.ToolStripMenuItem_TransportLinesChange.Name = "ToolStripMenuItem_TransportLinesChange";
            this.ToolStripMenuItem_TransportLinesChange.Padding = new System.Windows.Forms.Padding(4, 0, 4, 40);
            this.ToolStripMenuItem_TransportLinesChange.Size = new System.Drawing.Size(224, 46);
            this.ToolStripMenuItem_TransportLinesChange.Text = "Promjena transportnih l.";
            this.ToolStripMenuItem_TransportLinesChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolStripMenuItem_TransportLinesChange.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolStripMenuItem_TransportLinesChange.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // ToolStripMenuItem_Contact
            // 
            this.ToolStripMenuItem_Contact.AutoSize = false;
            this.ToolStripMenuItem_Contact.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItem_Contact.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_Contact.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Contact.Image")));
            this.ToolStripMenuItem_Contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_Contact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Contact.Margin = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.ToolStripMenuItem_Contact.Name = "ToolStripMenuItem_Contact";
            this.ToolStripMenuItem_Contact.Size = new System.Drawing.Size(224, 36);
            this.ToolStripMenuItem_Contact.Text = "Kontakt";
            this.ToolStripMenuItem_Contact.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolStripMenuItem_Contact.Click += new System.EventHandler(this.ToolStripMenuItem_Contact_Click);
            // 
            // ToolStripMenuItem_Information
            // 
            this.ToolStripMenuItem_Information.AutoSize = false;
            this.ToolStripMenuItem_Information.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItem_Information.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_Information.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Information.Image")));
            this.ToolStripMenuItem_Information.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_Information.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Information.Margin = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.ToolStripMenuItem_Information.Name = "ToolStripMenuItem_Information";
            this.ToolStripMenuItem_Information.Size = new System.Drawing.Size(224, 36);
            this.ToolStripMenuItem_Information.Text = "Informacije";
            this.ToolStripMenuItem_Information.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolStripMenuItem_Information.Click += new System.EventHandler(this.ToolStripMenuItem_Information_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.AutoSize = false;
            this.ToolStripMenuItem_Exit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripMenuItem_Exit.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Exit.Image")));
            this.ToolStripMenuItem_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(224, 36);
            this.ToolStripMenuItem_Exit.Text = "EXIT";
            this.ToolStripMenuItem_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            this.ToolStripMenuItem_Exit.DoubleClick += new System.EventHandler(this.ToolStripMenuItem_Exit_DoubleClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(55, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Izbornik";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.Transparent;
            this.FormPanel.Location = new System.Drawing.Point(781, 491);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(355, 105);
            this.FormPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1484, 916);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozni red vlakova";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label satGMD;
        private System.Windows.Forms.Label satSMS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Home;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TicketSelling;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_PersonelTransportChange;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Logistics;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TransportLinesChange;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Contact;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Information;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel FormPanel;
    }
}