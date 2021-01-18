using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class CustomerForm : Form
    {
        CustomerList customerList = new CustomerList();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshCustomerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void RefreshCustomerList()
        {
            customerList = CustomerList.GetDefaultCustomerList();
            customerListBindingSource.DataSource = null;
            customerListBindingSource.DataSource = customerList;
        }
    }
}
