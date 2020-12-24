using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project00.model
{
    public class registeration
    {

        int ownerID;
        int customerID;
        DateTime registrationDate;
        int accommodationID;

        public registeration(int ownerID, int customerID,
            DateTime registrationDate, int accommodationID)
        {
            this.ownerID = ownerID;
            this.customerID = customerID;
            this.registrationDate = registrationDate;
            this.accommodationID = accommodationID;
        }
    }
}
