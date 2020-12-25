using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project00.Models
{
   abstract class Person
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
        public abstract Person Login(string firstname, string password);
        
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
