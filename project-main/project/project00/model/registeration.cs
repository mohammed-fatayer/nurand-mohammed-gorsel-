using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace project00.model
{
    public class registeration
    {

        int ownerID;
        int customerID;
        string firstname;
        string password;

        public registeration(int ownerID, int customerID, string firstname, string password)
        {
            this.ownerID = ownerID;
            this.customerID = customerID;
            this.firstname = firstname;
            this.password = password;
        }
    }
}
