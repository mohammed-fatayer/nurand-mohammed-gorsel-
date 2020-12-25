using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project00.Model
{
    internal class owner : Person
    {
        int ownerID;
        public owner()
        {

        }


        public owner(int ownerID, string firstname, string lastname, string gendr, string email, string password, string address)
        {
            this.ownerID = ownerID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gendr;
            this.email = email;
            this.password = password;
            this.address = address;
        }



        public void display()
        {
            Console.WriteLine($"ID{ownerID},name{firstname}");
        }
        public override void login(string firstname, string password)
        {

            /*  try
              {
                  string connectionstring = "Server = DESKTOP-QB99BRD; Database = sms; Trusted_Connection = True;";
                  SqlConnection connection = new SqlConnection(connectionstring);
                  connection.Open();
                  if (connection.State == System.Data.ConnectionState.Open)
                  {
                      string squery = $"select *from owner where firstname = {firstname}and Password = {password}";
                      SqlCommand sqlCommand = new SqlCommand(squery, connection);
                      DataTable dt = new DataTable();
                      SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                      adapter.Fill(dt);
                      if (dt.Rows.Count > 0)
                      {

                      }
                      else
                      {

                      }
                  }
                  else
                  {
                      throw new Exception("cant connect to sql database");
                  }

              }
              catch (Exception ex)
              {

                  throw new Exception("error in login.");
              }
          
            */

        }

       
    }
}
      
    