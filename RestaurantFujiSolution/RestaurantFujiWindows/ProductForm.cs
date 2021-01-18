using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class ProductForm : Form
    {
        ProductList productList = new ProductList();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshProductList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void RefreshProductList()
        {
            productList = ProductList.GetDefaultProductList();
            productListBindingSource.DataSource = null;
            productListBindingSource.DataSource = productList;
        }
    }
}
