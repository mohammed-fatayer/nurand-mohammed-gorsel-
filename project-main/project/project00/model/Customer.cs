using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (firstname == "ali" && password == "1234")
                {
                    Console.WriteLine("welcome customer");
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
    }
}
