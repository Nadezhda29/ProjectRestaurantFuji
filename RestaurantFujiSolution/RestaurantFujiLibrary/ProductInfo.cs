using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class ProductInfo
    {
        int id = 0;
        string nameProduct = "";
        decimal priceProduct = 0.00M;


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

        public decimal PriceProduct
        {
            get
            {
                return priceProduct;
            }
            set
            {
                priceProduct = value;
            }
        }

        public void InsertNewProduct()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertProduct";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@NameProduct", nameProduct));
            cm.Parameters.Add(new SqlParameter("@PriceProduct", priceProduct));

            cm.ExecuteNonQuery();
        }

        public decimal GetProduct(int productID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetProduct";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@ProductID", productID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["ProductID"];
                nameProduct = dr["NameProduct"].ToString();
                priceProduct = (decimal)dr["PriceProduct"];
            }

            return priceProduct;
        }

        public void DeleteProduct()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteProduct";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@ProductID", id));

            cm.ExecuteNonQuery();
        }

        public void UpdateProduct()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateProduct";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@ProductID", id));
            cm.Parameters.Add(new SqlParameter("@NameProduct", nameProduct));
            cm.Parameters.Add(new SqlParameter("@PriceProduct", priceProduct));

            cm.ExecuteNonQuery();
        }
    }
}
