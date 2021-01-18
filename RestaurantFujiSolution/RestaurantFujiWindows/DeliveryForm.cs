using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class DeliveryForm : Form
    {
        DeliveryList deliveryList = new DeliveryList();
        public static int requestID;
        public static int flag = 0;
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDeliveryList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeliveryEditForm newForm = new DeliveryEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newDelivery.InsertDelivery();
            }

            RefreshDeliveryList();
        }

        void RefreshDeliveryList()
        {
            deliveryList = DeliveryList.GetDefaultDeliveryList();
            deliveryListBindingSource.DataSource = null;
            deliveryListBindingSource.DataSource = deliveryList;
            requestID = (int)(deliveryListDataGridView.Rows.Count + 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            requestID = (int)deliveryListDataGridView.SelectedRows[0].Cells[1].Value;
            DetailDeliveryForm newForm = new DetailDeliveryForm();
            flag = 0;

            if (newForm.ShowDialog() == DialogResult.Cancel)
            {
                newForm.Close();
            }         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
