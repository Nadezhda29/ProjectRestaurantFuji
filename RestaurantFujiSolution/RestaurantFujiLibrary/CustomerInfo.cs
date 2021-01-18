using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class CustomerInfo
    {
        int id = 0;
        string nameCustomer = "";
        string phone = "";
        string addressCustomer = "";


        public string NameCustomer
        {
            get
            {
                return nameCustomer;
            }
            set
            {
                nameCustomer = value;
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

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string AddressCustomer
        {
            get
            {
                return addressCustomer;
            }
            set
            {
                addressCustomer = value;
            }
        }

        public void InsertNewCustomer()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertCustomer";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@NameCustomer", nameCustomer));
            cm.Parameters.Add(new SqlParameter("@Phone", phone));
            cm.Parameters.Add(new SqlParameter("@AddressCustomer", addressCustomer));

            cm.ExecuteNonQuery();
        }

        public string GetCustomer(int customerID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetCustomer";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@CustomerID", customerID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["CustomerID"];
                nameCustomer = dr["NameCustomer"].ToString();
                phone = dr["Phone"].ToString();
                addressCustomer = dr["AddressCustomer"].ToString();
            }

            return addressCustomer;
        }
    }
}
