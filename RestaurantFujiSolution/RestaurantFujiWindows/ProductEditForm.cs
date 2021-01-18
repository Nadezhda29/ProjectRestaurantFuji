using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class ProductEditForm : Form
    {
        public ProductInfo newProduct = new ProductInfo();
        public ProductEditForm()
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

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            productInfoBindingSource.DataSource = newProduct;
        }
    }
}
