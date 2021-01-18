using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantFujiLibrary
{
    public class DateList: List<DateInfo>
    {
        public static DateList GetDefaultDateList()
        {
            DateList myList = new DateList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-T5S647EI; Initial Catalog=RestaurantFuji; Integrated Security=True";
            cn.Open();

            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetDateList";

            cm.Connection = cn;

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                DateInfo newDate = new DateInfo();
                newDate.ID = (int)dr["DateID"];
                newDate.DateValue = (DateTime)dr["DateValue"];
                newDate.Year = (Int16)dr["Year"];
                newDate.Month = (Byte)dr["Month"];
                newDate.MonthName = dr["MonthName"].ToString();
                newDate.Day = (Byte)dr["Day"];
                newDate.WeekDay = dr["WeekDay"].ToString();

                myList.Add(newDate);

            }

            return myList;
        }
    }
}
