using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class DetailDeliveryList: List<DetailDeliveryInfo>
    {
        public static DetailDeliveryList GetDetailDeliveryList(int reqID)
        {
            DetailDeliveryList myList = new DetailDeliveryList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetDetailDeliveryList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                DetailDeliveryInfo newDetailDelivery = new DetailDeliveryInfo();
                newDetailDelivery.ID = (int)dr["DetailDeliveryID"];
                newDetailDelivery.RequestID = (int)dr["RequestID"];
                newDetailDelivery.FoodID = (int)dr["FoodID"];
                newDetailDelivery.NameFood = dr["NameFood"].ToString();
                newDetailDelivery.NumberFood = (int)dr["NumberFood"];
                newDetailDelivery.SumFood = (decimal)dr["SumFood"];

                if (reqID == (int)dr["RequestID"])
                {
                    myList.Add(newDetailDelivery);
                }
            }

            return myList;
        }
    }
}
