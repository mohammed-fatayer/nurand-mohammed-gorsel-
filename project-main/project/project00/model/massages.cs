using project00.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace project00
{
    class massages
    {
        protected string massage { get; set; }


        protected static string connectionString;
        public massages()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DBconnectionString"].ConnectionString;
        }

        public DataTable sendmassage(string massage, string ownerid, string customerid)
        {
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {




                    SqlCommand cmd = new SqlCommand("INSERT INTO massage " + "(massage,OwnerID,CustomerID)" + "values( @massage,@OwnerID,@CustomerID) ", connection);


                    cmd.Parameters.Add("@massage", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@ownerid", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@customerid", System.Data.SqlDbType.NVarChar);


                    cmd.Parameters["@massage"].Value = massage;
                    cmd.Parameters["@ownerid"].Value = ownerid;
                    cmd.Parameters["@customerid"].Value = customerid;






                    int RowsAffected = cmd.ExecuteNonQuery();





                    connection.Close();
                    return null;

                }
                else
                {
                    throw new Exception("can't connect to server");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetMesInfo(int ownerID)
        {
            try
            {
                string query = $"select *from [Massage system]";
                if (ownerID > 0)
                {
                    query += " where a.ownerid = " + ownerID;
                }
                return dbHelper.ExecuteQuery(query);  //its static, can call method direcly
            }
            catch (Exception ex)
            {
                throw new Exception("GetPaymentInfo Error: " + ex.Message);
            }
        }
        public DataTable deletemassage(string ownerid, string customerid)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM [Massage] WHERE ownerid = ownerid and customerid = customerid", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();

                }
                return null;
            }

            catch (Exception)
            {

                throw;
            }

        }
        public String[] getmassage(string ownerid, string customerid)
        {



            try
            {

                var myList = new List<string>();
                string[] str;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command =
  new SqlCommand("select * from massage WHERE CustomerId=customerid and ownerid = ownerid", connection);
                connection.Open();


                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {


                    string massage = (read["massage"].ToString());




                    myList.Add(massage);





                }
                str = myList.ToArray();

                read.Close();
                connection.Close();
                return str;
                ;





            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}







