using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class SupplyList: List<SupplyInfo>
    {
        public static SupplyList GetDefaultSupplyList()
        {
            SupplyList myList = new SupplyList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetSupplyList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                SupplyInfo newSupply = new SupplyInfo();
                newSupply.ID = (int)dr["SupplyID"];
                newSupply.SupplierID = (int)dr["SupplierID"];
                newSupply.NameSupplier = dr["NameSupplier"].ToString();
                newSupply.Phone = dr["Phone"].ToString();
                newSupply.DateID = (int)dr["DateID"];
                newSupply.DateValue = (DateTime)dr["DateValue"];
                newSupply.ProductID = (int)dr["ProductID"];
                newSupply.NameProduct = dr["NameProduct"].ToString();
                newSupply.NumberProduct = (int)dr["NumberProduct"];
                newSupply.SumSupply = (decimal)dr["SumSupply"];

                myList.Add(newSupply);

            }

            return myList;
        }
    }
}
