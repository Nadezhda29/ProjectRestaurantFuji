using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class DeliveryEditForm : Form
    {
        public DeliveryInfo newDelivery = new DeliveryInfo();

        public DeliveryEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dateValueDateTimePicker.Value.Date;
            DateInfo dateInfo = new DateInfo();
            int id = dateInfo.GetDate(dt);
            newDelivery.DateID = id;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerEditForm newForm = new CustomerEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newCustomer.InsertNewCustomer();
                customerListBindingSource.DataSource = CustomerList.GetDefaultCustomerList();
                customerIDComboBox.SelectedIndex = customerListBindingSource.Count - 1;           
                addressCustomerTextBox.Text = newForm.newCustomer.AddressCustomer;
                newDelivery.AddressCustomer = newForm.newCustomer.AddressCustomer;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetailDeliveryForm newForm = new DetailDeliveryForm();
            newDelivery.InsertRequest();
            DeliveryForm.flag = 1;

            if (newForm.ShowDialog() == DialogResult.Cancel)
            {
                newForm.Close();
            }
        }


        private void customerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerInfo customer = new CustomerInfo();
            string address = customer.GetCustomer(customerIDComboBox.SelectedIndex + 1);
            addressCustomerTextBox.Text = address;
            customer.AddressCustomer = address;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int requestID = Convert.ToInt32(requestIDTextBox.Text);
            DetailDeliveryList detailDeliveryList = DetailDeliveryList.GetDetailDeliveryList(requestID);
            decimal sumDelivery = 0;
            foreach (DetailDeliveryInfo id in detailDeliveryList)
            {
                sumDelivery += id.SumFood;
            }

            sumDeliveryTextBox.Text = sumDelivery.ToString();
            newDelivery.SumDelivery = decimal.Parse(sumDeliveryTextBox.Text);

        }

        private void DeliveryEditForm_Load(object sender, EventArgs e)
        {
            WorkerList workerList = WorkerList.GetDefaultWorkerList();
            workerListBindingSource.DataSource = workerList; 

            CustomerList customerList = CustomerList.GetDefaultCustomerList();
            customerListBindingSource.DataSource = customerList;

            deliveryInfoBindingSource.DataSource = newDelivery;

            requestIDTextBox.Text = DeliveryForm.requestID.ToString();
            newDelivery.RequestID = DeliveryForm.requestID;
        }

        private void workerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkerInfo worker = new WorkerInfo();
            string name = worker.GetWorker(workerIDComboBox.SelectedIndex + 1);
            nameTextBox.Text = name;
            newDelivery.Name = name;
        }
    }
}
