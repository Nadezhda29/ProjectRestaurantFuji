using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class DeliveryList: List<DeliveryInfo>
    {
        public static DeliveryList GetDefaultDeliveryList()
        {
            DeliveryList myList = new DeliveryList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True; Connection Timeout=30";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetDeliveryList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                DeliveryInfo newDelivery = new DeliveryInfo();
                newDelivery.ID = (int)dr["DeliveryID"];
                newDelivery.RequestID = (int)dr["RequestID"];
                newDelivery.WorkerID = (int)dr["WorkerID"];
                newDelivery.Surname = dr["Surname"].ToString();
                newDelivery.Name = dr["Name"].ToString();
                newDelivery.CustomerID = (int)dr["CustomerID"];
                newDelivery.AddressCustomer = dr["AddressCustomer"].ToString();
                newDelivery.Phone = dr["Phone"].ToString();
                newDelivery.DateID = (int)dr["DateID"];
                newDelivery.DateValue = (DateTime)dr["DateValue"];
                newDelivery.SumDelivery = (decimal)dr["SumDelivery"]; 

                myList.Add(newDelivery);

            }

            return myList;
        }
    }
}
