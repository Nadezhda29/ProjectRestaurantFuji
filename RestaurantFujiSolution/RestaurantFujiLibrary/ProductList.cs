using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace RestaurantFujiLibrary
{
    public class ProductList: List<ProductInfo>
    {
        public static ProductList GetDefaultProductList()
        {
            ProductList myList = new ProductList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetProductList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ProductInfo newProduct = new ProductInfo();
                newProduct.ID = (int)dr["ProductID"];
                newProduct.NameProduct = dr["NameProduct"].ToString();
                newProduct.PriceProduct = (decimal)dr["PriceProduct"];

                myList.Add(newProduct);

            }

            return myList;
        }
    }
}
