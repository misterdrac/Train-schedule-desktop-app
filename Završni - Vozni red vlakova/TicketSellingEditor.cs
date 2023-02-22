using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Završni___Vozni_red_vlakova
{
    public partial class TicketSellingEditor : Form
    {
        ZR_VozniRedVlakovaEntities trainLines = new ZR_VozniRedVlakovaEntities();
        public TicketSellingEditor()
        {
            InitializeComponent();
        }

        private void TicketSellingEditor_Load(object sender, EventArgs e)
        {
            trainLines.Train_Lines.Load();
            dataGridView1.DataSource = trainLines.Train_Lines.Local.ToBindingList();
            dataGridView1.Size = new System.Drawing.Size(1144, 308);
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            arrivalTimePicker.Format = DateTimePickerFormat.Time;
            arrivalTimePicker.ShowUpDown = true;
            arrivalTimePicker.CustomFormat = "HH:mm";
            arrivalTimePicker.MaxDate = DateTime.Today.AddDays(1).AddSeconds(-1); 
            arrivalTimePicker.ShowCheckBox = true;
            departureTimePicker.Format = DateTimePickerFormat.Time;
            departureTimePicker.ShowUpDown = true;
            departureTimePicker.CustomFormat = "HH:mm";
            departureTimePicker.MaxDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            departureTimePicker.ShowCheckBox = true;
            List<string> yesNo = new List<string>() { "Da", "Ne"};
            fastTrainComboBox.DataSource = yesNo;
            fastTrainComboBox.SelectedIndex = 0;

        }

        private void promjenaPutničkeLinije_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (promjenaPutničkeLinije.Text.Length == 0 && (e.KeyChar == '-' || e.KeyChar == '0'))
            {
                e.Handled = true;
            }
            if (promjenaPutničkeLinije.Text.Length >= 4 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void promjenaBrojaLokomotive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (promjenaBrojaLokomotive.Text.Length == 0 && (e.KeyChar == '-' || e.KeyChar == '0'))
            {
                e.Handled = true;
            }
            if (promjenaBrojaLokomotive.Text.Length >= 4 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void peronTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (peronTextbox.Text.Length == 0 && (e.KeyChar == '-' || e.KeyChar == '0'))
            {
                e.Handled = true;
            }
            if (peronTextbox.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void kolosijekTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (kolosijekTextBox.Text.Length == 0 && (e.KeyChar == '-' || e.KeyChar == '0'))
            {
                e.Handled = true;
            }
            if (kolosijekTextBox.Text.Length >= 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void delayTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(delayTimeTextBox.Text, out int val))
            {
                if (val < 0 || val >= 40)
                {
                    MessageBox.Show("Vlak ne može kasniti više od 40 minuta.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    delayTimeTextBox.Text = "";
                }
                else
                {
                    string min = val.ToString("00") + "min";
                }
            }
            else if (!string.IsNullOrEmpty(delayTimeTextBox.Text))
            {
                delayTimeTextBox.Text = "";
            }
        }
    }
}
