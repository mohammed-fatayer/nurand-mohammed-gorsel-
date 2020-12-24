using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project00.Model
{
    class rentalHouse
    {
        int houseID;
        string detailsOfHouse;
        DateTime rentalPeriod;
        int price;
        int locationID;

        public rentalHouse(int houseID,
            string detailsOfHouse,
            DateTime rentalPeriod,
            int price, int locationID)
        {
            this.houseID = houseID;
            this.detailsOfHouse = detailsOfHouse;
            this.rentalPeriod = rentalPeriod;
            this.price = price;
            this.locationID = locationID;
        }
    }
}
