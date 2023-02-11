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
    }
}
