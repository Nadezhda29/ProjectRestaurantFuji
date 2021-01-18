using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class DetailDeliveryEditForm : Form
    {
        public DetailDeliveryInfo newDetailDelivery = new DetailDeliveryInfo();
        public DetailDeliveryEditForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetailDeliveryEditForm_Load(object sender, EventArgs e)
        {
            MenuList menuList = MenuList.GetDefaultMenuList();
            menuListBindingSource.DataSource = menuList;

            detailDeliveryInfoBindingSource.DataSource = newDetailDelivery;

            requestIDTextBox.Text = DeliveryForm.requestID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuInfo menu = new MenuInfo();
            decimal price = menu.GetMenu(foodIDComboBox.SelectedIndex + 1);
            sumFoodTextBox.Text = (price * int.Parse(numberFoodTextBox.Text)).ToString();
            newDetailDelivery.SumFood = decimal.Parse(sumFoodTextBox.Text);
        }
    }
}
