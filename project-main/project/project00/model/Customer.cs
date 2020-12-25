using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using project00.Model;
using System.Data;

namespace project00.Model
{
    class Customer:Person
    {
        int customerID;
        public Customer()
        {

        }
       
      

        public Customer(int customerID, string firstname, string lastname, string gender, string email, string password, string address)
        {
            this.customerID = customerID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.email = email;
            this.password = password;
            this.address = address;
        }
        public override void login(string firstname, string password)
        {

            try
            {
                string connectionstring = "Server = DESKTOP-QB99BRD; Database = sms; Trusted_Connection = True;";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string squery = $"select *from customer where firstname = {firstname}and Password = {password}";
                    SqlCommand sqlCommand = new SqlCommand(squery, connection);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                    if (dt.Rows.Count>0)
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

        }

    }
}
