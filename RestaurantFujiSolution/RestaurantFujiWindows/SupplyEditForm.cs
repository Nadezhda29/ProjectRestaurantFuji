using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class SupplyEditForm : Form
    {
        public SupplyInfo newSupply = new SupplyInfo();
        public DateTime dt;

        public SupplyEditForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductEditForm newForm = new ProductEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newProduct.InsertNewProduct();
                productListBindingSource.DataSource = ProductList.GetDefaultProductList();
                productIDComboBox.SelectedIndex = productListBindingSource.Count - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierEditForm newForm = new SupplierEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newSupplier.InsertNewSupplier();
                supplierListBindingSource.DataSource = SupplierList.GetDefaultSupplierList();
                supplierIDComboBox.SelectedIndex = supplierListBindingSource.Count - 1;
                phoneTextBox.Text = newForm.newSupplier.Phone;  
            }
        }

        private void SupplyEditForm_Load(object sender, EventArgs e)
        {
            SupplierList supplierList = SupplierList.GetDefaultSupplierList();
            supplierListBindingSource.DataSource = supplierList;

            ProductList productList = ProductList.GetDefaultProductList();
            productListBindingSource.DataSource = productList;

            DateList dateList = DateList.GetDefaultDateList();
            dateListBindingSource.DataSource = dateList;

            supplyInfoBindingSource.DataSource = newSupply;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductInfo product = new ProductInfo();
            decimal price = product.GetProduct(productIDComboBox.SelectedIndex + 1);
            sumSupplyTextBox.Text = (price * int.Parse(numberProductTextBox.Text)).ToString();
            newSupply.SumSupply = decimal.Parse(sumSupplyTextBox.Text); 
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = dateValueDateTimePicker.Value.Date;
            DateInfo dateInfo = new DateInfo();
            int id = dateInfo.GetDate(dt);
            newSupply.DateID = id;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void supplierIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierInfo supplier = new SupplierInfo();
            string phone = supplier.GetSupplier(supplierIDComboBox.SelectedIndex + 1);
            phoneTextBox.Text = phone;
        }
    }
}
