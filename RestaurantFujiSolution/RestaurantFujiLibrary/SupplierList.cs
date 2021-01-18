using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class SupplierList: List<SupplierInfo>
    {
        public static SupplierList GetDefaultSupplierList()
        {
            SupplierList myList = new SupplierList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetSupplierList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                SupplierInfo newSupplier = new SupplierInfo();
                newSupplier.ID = (int)dr["SupplierID"];
                newSupplier.NameSupplier = dr["NameSupplier"].ToString();
                newSupplier.Phone = dr["Phone"].ToString();

                myList.Add(newSupplier);

            }

            return myList;
        }
    }
}
