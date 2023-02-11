using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Završni___Vozni_red_vlakova
{
    public partial class TicketSelling : Form
    {
        ZR_VozniRedVlakovaEntities trainLines = new ZR_VozniRedVlakovaEntities();
        bool startLocationBool, destinationLocationBool, startDateBool, passengerNumBool, discountBoxBool, ticketFormatBool, confirmationCheckBoxBool, oneWayButtonBool, bothWaysButtonBool;
        public TicketSelling()
        {
            InitializeComponent();
        }
        private void TicketSelling_Load(object sender, EventArgs e)
        {
            this.continueButton.Enabled = false;
            this.placanjePanel.Enabled = false;
            this.returningLocation.Enabled = false;
            this.returningDate.Enabled = false;
            paymentMethodBox.SelectedIndexChanged += new EventHandler(paymentMethodBox_SelectedIndexChanged);
            this.creditCardsBox.Enabled = false;
            this.kioskBox.Enabled = false;
            trainLines.Train_Lines.Load();
            dataGridView1.DataSource = trainLines.Train_Lines.Local.ToBindingList();
            dataGridView1.Size = new System.Drawing.Size(1144, 308);
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }
        private void oneWayButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (oneWayButton.Checked) 
                {
                    oneWayButtonBool = true;
                }
                else 
                {
                    oneWayButtonBool = false;
                }
            }
            catch 
            {
                oneWayButtonBool = false;
            }
            Continuation();
        }
        private void bothWaysButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (bothWaysButton.Checked)
                {
                    bothWaysButtonBool = true;
                }
                else
                {
                    bothWaysButtonBool = false;
                }
            }
            catch
            {
                bothWaysButtonBool = false;
            }
            Continuation(); enableCheck();
        }
        private void startLocation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(startLocation.Text))
                {
                    MessageBox.Show("Morate upisati polazišni kolodvor");
                    startLocationBool = false;
                }
                else
                {
                    startLocationBool = true;
                }
            }
            catch
            {
                startLocationBool = false;
            }
            Continuation();
        }
        private void destinationLocation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(destinationLocation.Text))
                {
                    MessageBox.Show("Potreban je unos");
                    destinationLocationBool = false;
                }
                else
                {
                    destinationLocationBool = true;
                }
            }
            catch
            {
                destinationLocationBool = false;
            }
            Continuation();
        }
        private void paymentMethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentMethodBox.SelectedItem != null)
            {
                string odabranaOpcija = paymentMethodBox.SelectedItem.ToString();
                if (odabranaOpcija == "Kartica")
                {
                    paymentLabel.Text = "Ako se odabrali karticu kao način plaćanja, odaberite sljedeće banke:";
                    creditCardsBox.Enabled = true;
                    kioskBox.Enabled = true;
                }
                else if (odabranaOpcija == "Gotovina")
                {
                    paymentLabel.Text = "Ako ste odabrali gotovinu kao način plaćanja, odaberite sljedeće naplatne kućice za preuzimanje karte:";
                    creditCardsBox.Enabled = false;
                    kioskBox.Enabled = true;
                }
            }
        }
        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = startDate.Value;

                if (selectedDate.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("The selected date cannot be in the past.");
                    startDateBool = false;
                }
                else
                {
                    startDateBool = true;
                }
            }
            catch
            {
                startDateBool = false;
            }
            Continuation();
        }
        private void passengerNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (passengerNum.SelectedIndex == -1)
                {
                    MessageBox.Show("No option has been selected.");
                    passengerNumBool = false;
                }
                else
                {
                    passengerNumBool = true;
                }
            }
            catch
            {
                passengerNumBool = false;
            }
            Continuation();
        }
        private void discountBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (discountBox.SelectedIndex == -1)
                {
                    MessageBox.Show("No option has been selected.");
                    discountBoxBool = false;
                }
                else
                {
                    discountBoxBool = true;
                }
            }
            catch
            {
                discountBoxBool = false;
            }
            Continuation();
        }
        private void ticketFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ticketFormat.SelectedIndex == -1)
                {
                    MessageBox.Show("No option has been selected.");
                    ticketFormatBool = false;

                }
                else
                {
                    ticketFormatBool = true;
                }
            }

            catch
            {
                ticketFormatBool = false;
            }
            Continuation();
        }
        private void confirmationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (confirmationCheckBox.Checked)
                {
                    MessageBox.Show("Ako ste zadovoljni potvrdite te kliknite gumb 'Nastavi'.", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    confirmationCheckBoxBool = true;
                }
                else
                {
                    MessageBox.Show("Morate sva polja kod kojih se nalazi znak * ispuniti te ponovno kliknuti na ovaj gumb inače ne može nastaviti dalje ", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    confirmationCheckBoxBool = false;
                }
            }
            catch
            {
                ticketFormatBool = false;
            }
            Continuation();
        }
        private void Continuation()
        {
            if (startLocationBool && destinationLocationBool && startDateBool && passengerNumBool && discountBoxBool && ticketFormatBool && confirmationCheckBoxBool && (oneWayButtonBool || bothWaysButtonBool))
            {
                this.continueButton.Enabled = true;
            }
            else
            {
                this.continueButton.Enabled = false;
                this.placanjePanel.Enabled = false;
            }
            if (bothWaysButtonBool)
            {
                this.returningLocation.Enabled = true;
                this.returningDate.Enabled = true;
            }
            else
            {
                this.returningLocation.Enabled = false;
                this.returningDate.Enabled = false;
            }
        }
        private void enableCheck() 
        {
            if (bothWaysButton.Checked)
            {
                this.returningDate.Enabled = true;
                this.returningLocation.Enabled = true;
            }
            else
            {
                this.returningLocation.Enabled = false;
                this.returningDate.Enabled = false;

            }
        }
        private void continueButton_Click(object sender, EventArgs e)
        {
            this.placanjePanel.Enabled = true;
        }
    }
}