using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class WorkerList: List<WorkerInfo>
    {
        public static WorkerList GetDefaultWorkerList()
        {
            WorkerList myList = new WorkerList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetWorkerDeliveryList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                WorkerInfo newWorker = new WorkerInfo();
                newWorker.ID = (int)dr["WorkerID"];
                newWorker.Surname = dr["Surname"].ToString();
                newWorker.Name = dr["Name"].ToString();
                newWorker.Phone = dr["Phone"].ToString();

                myList.Add(newWorker);

            }

            return myList;
        }
    }
}
