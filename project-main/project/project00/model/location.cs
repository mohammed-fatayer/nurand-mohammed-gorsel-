using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project00.Model
{
    class location
    {
        int locationID;
        string address;
        int accommodationID;

        public location(int locationID,
            string address, int accommodationID)
        {
            this.locationID = locationID;
            this.address = address;
            this.accommodationID = accommodationID;
        }
    }
}
