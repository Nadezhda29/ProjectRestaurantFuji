using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class SupplierEditForm : Form
    {
        public SupplierInfo newSupplier = new SupplierInfo();

        public SupplierEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SupplierEditForm_Load(object sender, EventArgs e)
        {
            supplierInfoBindingSource.DataSource = newSupplier;
        }
    }
}
