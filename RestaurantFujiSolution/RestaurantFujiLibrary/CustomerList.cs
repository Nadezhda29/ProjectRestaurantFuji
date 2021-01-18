using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class CustomerList: List<CustomerInfo>
    {
        public static CustomerList GetDefaultCustomerList()
        {
            CustomerList myList = new CustomerList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetCustomerList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                CustomerInfo newCustomer = new CustomerInfo();
                newCustomer.ID = (int)dr["CustomerID"];
                newCustomer.NameCustomer = dr["NameCustomer"].ToString();
                newCustomer.Phone = dr["Phone"].ToString();
                newCustomer.AddressCustomer = dr["AddressCustomer"].ToString();

                myList.Add(newCustomer);

            }

            return myList;
        }
    }
}
