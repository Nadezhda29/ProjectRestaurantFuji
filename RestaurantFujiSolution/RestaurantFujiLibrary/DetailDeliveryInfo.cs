using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class DetailDeliveryInfo
    {
        int id = 0;
        int requestID = 0;
        string nameFood = "";
        int numberFood = 0;
        int foodID = 0;
        decimal sumFood = 0.00M;


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

        public int RequestID
        {
            get
            {
                return requestID;
            }
            set
            {
                requestID = value;
            }
        }

        public int FoodID
        {
            get
            {
                return foodID;
            }
            set
            {
                foodID = value;
            }
        }

        public int NumberFood
        {
            get
            {
                return numberFood;
            }
            set
            {
                numberFood = value;
            }
        }

        public decimal SumFood
        {
            get
            {
                return sumFood;
            }
            set
            {
                sumFood = value;
            }
        }


        public void InsertDetailDelivery()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertDetailDelivery";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@RequestID", requestID));
            cm.Parameters.Add(new SqlParameter("@FoodID", foodID));
            cm.Parameters.Add(new SqlParameter("@NumberFood", numberFood));
            cm.Parameters.Add(new SqlParameter("@SumFood", sumFood));

            cm.ExecuteNonQuery();
        }


        public void GetDetailDelivery(int requestID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetDetailDelivery";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@RequestID", requestID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["DetailDeliveryID"];
                requestID = (int)dr["RequestID"];
                foodID = (int)dr["FoodID"];
                numberFood = (int)dr["NumberFood"];
                sumFood = (decimal)dr["SumFood"];
            }
        }
    }
}
