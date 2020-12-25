using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project00.Models
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

        public int Name { get; private set; }

        public void display()
        {
            Console.WriteLine($"ID{ownerID},name{firstname}");
        }
        public override Person Login(string firstname, string password)
        {



            try
            {
                string connectionstring = "Server = DESKTOP-QB99BRD; Database = sms; Trusted_Connection = True;";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string squery = $"select OwnerID,firstname+' '+lastname name,Gender,Email,Address from owner " +
                        $"where firstname = '{firstname}' and Password = '{password}'";
                    SqlCommand sqlCommand = new SqlCommand(squery, connection);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        owner o = new owner();
                        o.ownerID = int.Parse( dt.Rows[0][ownerID].ToString());
                        o.firstname = dt.Rows[0]["name"].ToString();
                        o.Email = dt.Rows[0]["Email"].ToString();
                        o.gender = dt.Rows[0]["Gender"].ToString();
                        o.address = dt.Rows[0]["Address"].ToString();
                        return o;
                    }
                    else
                    {
                        return null;
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
      
    