using RestaurantFujiLibrary;
using System;
using System.Windows.Forms;

namespace RestaurantFujiWindows
{
    public partial class SupplyForm : Form
    {
        SupplyList supplyList = new SupplyList();

        public SupplyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshSupplyList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplyEditForm newForm = new SupplyEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newSupply.InsertNewSupply();
            }

            RefreshSupplyList();
        }

        void RefreshSupplyList()
        {
            supplyList = SupplyList.GetDefaultSupplyList();
            supplyListBindingSource.DataSource = null;
            supplyListBindingSource.DataSource = supplyList;
        }

    }
}
