using project00.house;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using project00.Model;


namespace project00
{
    static class Program
    {


    
        [STAThread]

        static void Main(string[] args)
        {

            owner o = new owner();
            Customer c = new Customer();
            Person p = new Person();
            p.Firstname = "ali";
            p.Lastname = "ahmed";
            p.login("ali", "1234");
            Console.WriteLine(p.Firstname);
            
            /////////////
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginform());
           
           
        }
        
    }


}
    

