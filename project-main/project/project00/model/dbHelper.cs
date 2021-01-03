using System;
using System.Data;
using System.Data.SqlClient;

namespace project00.model
{//d1 static method : using dbhelper mt without creating obj
 // with no static=> dbhelper new..... then can use its method  

    public static class dbHelper
    {   //d2 add static as well, str qurey vececez, give qurey as a parameter i
        // if other obj have qurey so its connect here and no need to update       

        // SELECT
        public static DataTable ExecuteQuery(string query)
        {
            try
            {
                //d3 cnt to DB
                string connectionString = "Server = DESKTOP-IPUP7LB; Database = sms; Trusted_Connection = True";
                SqlConnection Connection = new SqlConnection(connectionString);
                Connection.Open();

                if (Connection.State == ConnectionState.Open)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, Connection);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);

                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Log In Error: " + ex.Message);
            }
        }
        // INSERT DELETE UPDATE 
        public static int ExecuteNonQuery(string query) // use int fow row affect number
        {
            try
            {
                //d3 cnt to DB
                string connectionString = "Server = DESKTOP-IPUP7LB; Database = sms; Trusted_Connection = True";
                SqlConnection Connection = new SqlConnection(connectionString);
                Connection.Open();

                if (Connection.State == ConnectionState.Open)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, Connection);
                    return sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Log In Error: " + ex.Message);
            }
        }
        
    }
}
