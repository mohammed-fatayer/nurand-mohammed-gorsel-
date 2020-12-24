using System;
using System.Collections.Generic;
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
        public  void display()
        {
            Console.WriteLine($"ID{ownerID},name{firstname}");
        }
       /* public override void login(string firstname, string password)
        {

            try
            {
                if (firstname == "ali" && password == "1234")
                {
                    Console.WriteLine("welcome owner");
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
       */
    }
}