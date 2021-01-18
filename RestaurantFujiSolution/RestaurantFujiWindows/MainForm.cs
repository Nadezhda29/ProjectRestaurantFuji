using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            DeliveryForm newForm = new DeliveryForm();
            if (newForm.ShowDialog() == DialogResult.Abort)
            {
                MainForm mainForm = new MainForm();
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MenuForm newForm = new MenuForm();
            if (newForm.ShowDialog() == DialogResult.Abort)
            {
                MainForm mainForm = new MainForm();
            }
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            WorkerForm newForm = new WorkerForm();
            if (newForm.ShowDialog() == DialogResult.Abort)
            {
                MainForm mainForm = new MainForm();
            }
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm newForm = new CustomerForm();
            if (newForm.ShowDialog() == DialogResult.Abort)
            {
                MainForm mainForm = new MainForm();
            }
        }

        private void buttonSupply_Click(object sender, EventArgs e)
        {
            SupplyForm newForm = new SupplyForm();
            if (newForm.ShowDialog() == DialogResult.Abort)
            {
                MainForm mainForm = new MainForm();
            }
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm newForm = new SupplierForm();
            if (newForm.ShowDialog() == DialogResult.Abort)
            {
                MainForm mainForm = new MainForm();
            }
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            ProductForm newForm = new ProductForm();
            if (newForm.ShowDialog() == DialogResult.Abort)
            {
                MainForm mainForm = new MainForm();
            }
        }
    }
}
