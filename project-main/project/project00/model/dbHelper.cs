using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project00.model
{
    public static class dbHelper
    {
        // select
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                //string connectionString = "Server=YUK-5CD8282ZY6;Database=SMS;Trusted_Connection=True;";
                string connectionString = ConfigurationManager.AppSettings["ConString"];
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection.State == ConnectionState.Open)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }

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
                throw new Exception("GetAllDeparments Error: " + ex.Message);
            }
        }
    }
}
