using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class MenuList: List<MenuInfo>
    {
        public static MenuList GetDefaultMenuList()
        {
            MenuList myList = new MenuList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetMenuList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                MenuInfo newMenu = new MenuInfo();
                newMenu.ID = (int)dr["FoodID"];
                newMenu.NameFood = dr["NameFood"].ToString();
                newMenu.Price = (decimal)dr["Price"];
                newMenu.TypeFood = dr["TypeFood"].ToString();

                myList.Add(newMenu);

            }

            return myList;
        }

        public static MenuList GetTypeFoodList()
        {
            MenuList myList = new MenuList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetTypeFoodList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                MenuInfo newMenu = new MenuInfo();
                newMenu.TypeFood = dr["TypeFood"].ToString();

                myList.Add(newMenu);

            }

            return myList;
        }
    }
}
