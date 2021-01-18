using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class CustomerEditForm : Form
    {
        public CustomerInfo newCustomer = new CustomerInfo();

        public CustomerEditForm()
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

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {
            customerInfoBindingSource.DataSource = newCustomer;
        }
    }
}
