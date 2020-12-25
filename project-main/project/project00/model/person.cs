using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project00.Model
{
    class Person
    {
        protected string firstname;
        protected string lastname;
        protected string gender;
        protected string email;
        protected string password;
        protected string address;


        public string  Firstname

        {
            get { return firstname; }
            set
            {
                if (value == " ")
                {
                    throw new Exception("please inter a string");
                } 
                firstname = value; 
            }
        }

        public string Lastname { get => lastname; set => lastname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }

        public void display()
        {
            Console.WriteLine($"name{firstname},lastname{lastname}");
        }
        public virtual void login(string firstname, string password)
        {


            try
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

        }

        public void logout(Person p)
        {
            try
            {
                if (p is owner)
                {
                    Console.WriteLine($"come back soon owner {p.firstname}");
                }
                if (p is Customer)
               
                {
                    Console.WriteLine($"come back soon student{p.firstname}");
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception("error in logout");
            }
        }
    }

 

}
