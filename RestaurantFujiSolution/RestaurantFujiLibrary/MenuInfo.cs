using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class MenuInfo
    {
        int id = 0;
        string nameFood = "";
        decimal price = 0.00M;
        string typeFood = "";


        public string NameFood
        {
            get
            {
                return nameFood;
            }
            set
            {
                nameFood = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string TypeFood
        {
            get
            {
                return typeFood;
            }
            set
            {
                typeFood = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public void InsertNewMenu()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertMenu";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@NameFood", nameFood));
            cm.Parameters.Add(new SqlParameter("@Price", price));
            cm.Parameters.Add(new SqlParameter("@TypeFood", typeFood));

            cm.ExecuteNonQuery();
        }

        public decimal GetMenu(int foodID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetMenu";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@FoodID", foodID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["FoodID"];
                nameFood = dr["NameFood"].ToString();
                price = (decimal)dr["Price"];
                typeFood = dr["TypeFood"].ToString();
            }

            return price;
        }

        public void DeleteMenu()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteMenu";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@FoodID", id));

            cm.ExecuteNonQuery();
        }

        public void UpdateMenu()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateMenu";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@FoodID", id));
            cm.Parameters.Add(new SqlParameter("@NameFood", nameFood));
            cm.Parameters.Add(new SqlParameter("@Price", price));
            cm.Parameters.Add(new SqlParameter("@TypeFood", typeFood));

            cm.ExecuteNonQuery();
        }

    }
}
