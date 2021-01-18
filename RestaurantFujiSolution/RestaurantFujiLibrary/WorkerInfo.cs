using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class WorkerInfo
    {
        int id = 0;
        string surname = "";
        string name = "";
        string phone = "";


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

        public void InsertNewWorker()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertWorkerDelivery";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@Surname", surname));
            cm.Parameters.Add(new SqlParameter("@Name", name));
            cm.Parameters.Add(new SqlParameter("@Phone", phone));

            cm.ExecuteNonQuery();
        }

        public string GetWorker(int workerID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetWorkerDelivery";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@WorkerID", workerID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["WorkerID"];
                surname = dr["Surname"].ToString();
                name = dr["Name"].ToString();
                phone = dr["Phone"].ToString();
            }

            return Name;
        }

        public void DeleteWorker()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteWorkerDelivery";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@WorkerID", id));

            cm.ExecuteNonQuery();
        }

        public void UpdateWorker()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateWorkerDelivery";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@WorkerID", id));
            cm.Parameters.Add(new SqlParameter("@Surname", surname));
            cm.Parameters.Add(new SqlParameter("@Name", name));
            cm.Parameters.Add(new SqlParameter("@Phone", phone));

            cm.ExecuteNonQuery();
        }
    }
}
