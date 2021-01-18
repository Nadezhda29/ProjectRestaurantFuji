using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class SupplierInfo
    {
        int id = 0;
        string nameSupplier = "";
        string phone = "";

        public string NameSupplier
        {
            get
            {
                return nameSupplier;
            }
            set
            {
                nameSupplier = value;
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

        public void InsertNewSupplier()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertSupplier";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@NameSupplier", nameSupplier));
            cm.Parameters.Add(new SqlParameter("@Phone", phone));

            cm.ExecuteNonQuery();
        }

        public string GetSupplier(int supplierID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetSupplier";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@SupplierID", supplierID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["SupplierID"];
                nameSupplier = dr["NameSupplier"].ToString();
                phone = dr["Phone"].ToString();
            }

            return Phone;
        }

        public void DeleteSupplier()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteSupplier";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@SupplierID", id));

            cm.ExecuteNonQuery();
        }

        public void UpdateSupplier()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateSupplier";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@SupplierID", id));
            cm.Parameters.Add(new SqlParameter("@NameSupplier", nameSupplier));
            cm.Parameters.Add(new SqlParameter("@Phone", phone));

            cm.ExecuteNonQuery();
        }
    }
}
