using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class SupplyInfo
    {
        int id = 0;
        int supplierID = 0;
        string nameSupplier = "";
        string phone = "";
        int dateID = 0;
        DateTime dateValue = DateTime.Today;
        int productID = 0;
        string nameProduct = "";
        int numberProduct = 0;
        decimal sumSupply = 0.00M;


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

        public int SupplierID
        {
            get
            {
                return supplierID;
            }
            set
            {
                supplierID = value;
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

        public int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }

        public decimal SumSupply
        {
            get
            {
                return sumSupply;
            }
            set
            {
                sumSupply = value;
            }
        }

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


        public string NameProduct
        {
            get
            {
                return nameProduct;
            }
            set
            {
                nameProduct = value;
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

        public int NumberProduct
        {
            get
            {
                return numberProduct;
            }
            set
            {
                numberProduct = value;
            }
        }

        public void InsertNewSupply()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertSupply";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@SupplierID", supplierID));
            cm.Parameters.Add(new SqlParameter("@DateID", dateID));
            cm.Parameters.Add(new SqlParameter("@ProductID", productID));
            cm.Parameters.Add(new SqlParameter("@NumberProduct", numberProduct));
            cm.Parameters.Add(new SqlParameter("@SumSupply", sumSupply));

            cm.ExecuteNonQuery();
        }

        public void GetSupply(int supplyID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetSupply";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@SupplyID", supplyID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["SupplyID"];
                supplierID = (int)dr["SupplierID"];
                nameSupplier = dr["NameSupplier"].ToString();
                phone = dr["Phone"].ToString();
                dateID = (int)dr["DateID"];
                dateValue = (DateTime)dr["DateValue"];
                productID = (int)dr["ProductID"];
                nameProduct = dr["NameProduct"].ToString();
                numberProduct = (int)dr["NumberProduct"];
                sumSupply = (decimal)dr["SumSupply"];
            }
        }
    }
}
