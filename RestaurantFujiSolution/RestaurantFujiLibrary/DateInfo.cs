using System;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class DateInfo
    {
        int id = 0;
        DateTime dateValue = DateTime.Today;
        int year = 0;
        int month = 0;
        string monthName = "";
        int day = 0;
        string weekDay = "";

        public string MonthName
        {
            get
            {
                return monthName;
            }
            set
            {
                monthName = value;
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

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public string WeekDay
        {
            get
            {
                return weekDay;
            }
            set
            {
                weekDay = value;
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

        public int GetDate(DateTime dt)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetDate";

            cm.Connection = cn;

            cm.Parameters.Add(new SqlParameter("@DateValue", dt));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                id = (int)dr["DateID"];
            }

            return id;
        }

    }
}
