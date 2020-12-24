using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (firstname == "ali" && password == "1234")
                {
                    Console.WriteLine("welcome back");
                }
                else
                {
                    Console.WriteLine("check information");
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
