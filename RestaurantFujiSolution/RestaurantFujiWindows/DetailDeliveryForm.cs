using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class DetailDeliveryForm : Form
    {
        DetailDeliveryList detailDeliveryList = new DetailDeliveryList();

        public int requestID;
        public DetailDeliveryForm()
        {
            InitializeComponent();
        }

        private void DetailDeliveryForm_Load(object sender, EventArgs e)
        {
            requestID = DeliveryForm.requestID;
            if (DeliveryForm.flag == 0)
            {
                button1.Enabled = false;
            }
            else if (DeliveryForm.flag == 1)
            {
                button1.Enabled = true;
            }
            detailDeliveryList = DetailDeliveryList.GetDetailDeliveryList(requestID);
            detailDeliveryListBindingSource.DataSource = null;
            detailDeliveryListBindingSource.DataSource = detailDeliveryList;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            DetailDeliveryEditForm newForm = new DetailDeliveryEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newDetailDelivery.InsertDetailDelivery();
                RefreshList();
            }
        }

        public void RefreshList()
        {
            detailDeliveryList = DetailDeliveryList.GetDetailDeliveryList(DeliveryForm.requestID);
            detailDeliveryListBindingSource.DataSource = null;
            detailDeliveryListBindingSource.DataSource = detailDeliveryList;
        }
    }
}
