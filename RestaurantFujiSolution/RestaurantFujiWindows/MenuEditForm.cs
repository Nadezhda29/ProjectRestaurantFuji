using RestaurantFujiLibrary;
using System;
using System.Windows.Forms;

namespace RestaurantFujiWindows
{
    public partial class MenuEditForm : Form
    {
        public MenuInfo newMenu = new MenuInfo();

        public MenuEditForm()
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

        private void MenuEditForm_Load(object sender, EventArgs e)
        {
            MenuList menuList = MenuList.GetTypeFoodList();
            menuListBindingSource.DataSource = menuList;

            menuInfoBindingSource.DataSource = newMenu;
        }
    }
}
