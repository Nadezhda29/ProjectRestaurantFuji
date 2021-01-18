using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class MenuForm : Form
    {
        MenuList menuList = new MenuList();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshMenuList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuEditForm newForm = new MenuEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newMenu.InsertNewMenu();
            }

            RefreshMenuList();
        }

        void RefreshMenuList()
        {
            menuList = MenuList.GetDefaultMenuList();
            menuListBindingSource.DataSource = null;
            menuListBindingSource.DataSource = menuList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int menuID = (int)menuListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (MenuInfo menu in menuList)
            {
                if (menu.ID == menuID)
                {
                    menu.DeleteMenu();
                }
            }
            RefreshMenuList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int menuID = (int)menuListDataGridView.SelectedRows[0].Cells[0].Value;

            MenuEditForm newForm = new MenuEditForm();

            foreach (MenuInfo menu in menuList)
            {
                if (menu.ID == menuID)
                {
                    menu.GetMenu(menuID);
                    newForm.newMenu = menu;

                    if (newForm.ShowDialog() == DialogResult.OK)
                    {
                        newForm.newMenu.UpdateMenu();
                    }
                }
            }

            RefreshMenuList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
