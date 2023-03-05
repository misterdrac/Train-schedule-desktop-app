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

namespace Završni___Vozni_red_vlakova
{
    public partial class LogisticsEditor : Form
    {
        ZR_VozniRedVlakovaEntities cargoTrainLines = new ZR_VozniRedVlakovaEntities();
        public LogisticsEditor()
        {
            InitializeComponent();
        }

        private void LogisticsEditor_Load(object sender, EventArgs e)
        {
            cargoTrainLines.CargoTrain_Lines.Load();
            dataGridView1.DataSource = cargoTrainLines.CargoTrain_Lines.Local.ToBindingList();
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
        }
    }
}
