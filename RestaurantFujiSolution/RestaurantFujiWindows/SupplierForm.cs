using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class SupplierForm : Form
    {
        SupplierList supplierList = new SupplierList();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshSupplierList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplierEditForm newForm = new SupplierEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newSupplier.InsertNewSupplier();
            }

            RefreshSupplierList();
        }

        void RefreshSupplierList()
        {
            supplierList = SupplierList.GetDefaultSupplierList();
            supplierListBindingSource.DataSource = null;
            supplierListBindingSource.DataSource = supplierList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int supplierID = (int)supplierListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (SupplierInfo supplier in supplierList)
            {
                if (supplier.ID == supplierID)
                {
                    supplier.DeleteSupplier();
                }
            }
            RefreshSupplierList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int supplierID = (int)supplierListDataGridView.SelectedRows[0].Cells[0].Value;

            SupplierEditForm newForm = new SupplierEditForm();

            foreach (SupplierInfo supplier in supplierList)
            {
                if (supplier.ID == supplierID)
                {
                    supplier.GetSupplier(supplierID);
                    newForm.newSupplier = supplier;

                    if (newForm.ShowDialog() == DialogResult.OK)
                    {
                        newForm.newSupplier.UpdateSupplier();
                    }
                }
            }

            RefreshSupplierList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
