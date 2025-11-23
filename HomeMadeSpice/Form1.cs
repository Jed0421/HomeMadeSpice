using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeMadeSpice
{
    public partial class HomeSpiceForm : Form
    {
        public HomeSpiceForm()
        {
            InitializeComponent();
        }

        private void HomeSpiceForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryUC inventoryPage = new InventoryUC();

            LoadUserControl(inventoryPage);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadUserControl(UserControl uc)
        {
            pnlContentContainer.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            pnlContentContainer.Controls.Add(uc);

            uc.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardUC dashboardPage = new DashboardUC();

            LoadUserControl(dashboardPage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            POSUC posPage = new POSUC();
            LoadUserControl(posPage);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportUC reportPage = new ReportUC();
            LoadUserControl(reportPage);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
