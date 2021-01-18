using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class DeliveryInfo
    {
        int id = 0;
        int requestID = 0;
        int workerID = 0;
        string surname = "";
        string name = "";
        int customerID = 0;
        string addressCustomer = "";
        string phone = "";
        int dateID = 0;
        DateTime dateValue = DateTime.Today;
        decimal sumDelivery = 0.00M;

        public DateTime DateValue
        {
            get
            {
                return dateValue;
            }
            set
            {
                dateValue = value;
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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
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

        public int WorkerID
        {
            get
            {
                return workerID;
            }
            set
            {
                workerID = value;
            }
        }

        public int DateID
        {
            get
            {
                return dateID;
            }
            set
            {
                dateID = value;
            }
        }

        public decimal SumDelivery
        {
            get
            {
                return sumDelivery;
            }
            set
            {
                sumDelivery = value;
            }
        }


        public void InsertDelivery()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertDelivery";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@RequestID", requestID));
            cm.Parameters.Add(new SqlParameter("@WorkerID", workerID));
            cm.Parameters.Add(new SqlParameter("@CustomerID", customerID));
            cm.Parameters.Add(new SqlParameter("@DateID", dateID));
            cm.Parameters.Add(new SqlParameter("@SumDelivery", sumDelivery));



            cm.ExecuteNonQuery();
        }

        public void InsertRequest()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertRequest";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@RequestID", requestID));

            cm.ExecuteNonQuery();
        }

        public void GetDelivery(int deliveryID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetDelivery";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@DeliveryID", deliveryID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["DeliveryID"];
                requestID = (int)dr["RequestID"];
                workerID = (int)dr["WorkerID"];
                surname = dr["Surname"].ToString();
                name = dr["Name"].ToString();
                customerID = (int)dr["CustomerID"];
                addressCustomer = dr["AddressCustomer"].ToString();
                phone = dr["Phone"].ToString();
                dateID = (int)dr["DateID"];
                dateValue = (DateTime)dr["DateValue"];
                sumDelivery = (decimal)dr["SumDelivery"];
            }
        }
    }
}
