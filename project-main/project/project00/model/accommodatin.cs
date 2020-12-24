using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project00.Model
{
    public class accommodation
    {
        private int accommodationID;
        private string accommodation_selection;
        private string details_accommodation;
        private string price;
        private string period;
        private int locationID;
        private int ownerID;
        private int customerID;

        public accommodation(int accommodationID,
            string accommodation_selection,
            string details_accommodation,
            string price, string period,
            int locationID, int ownerID, int customerID)
        {
            this.AccommodationID = accommodationID;
            this.Accommodation_selection = accommodation_selection;
            this.Details_accommodation = details_accommodation;
            this.Price = price;
            this.Period = period;
            this.LocationID = locationID;
            this.OwnerID = ownerID;
            this.CustomerID = customerID;
        }

        public int AccommodationID { get => accommodationID; set => accommodationID = value; }
        public string Accommodation_selection { get => accommodation_selection; set => accommodation_selection = value; }
        public string Details_accommodation { get => details_accommodation; set => details_accommodation = value; }
        public string Price { get => price; set => price = value; }
        public string Period { get => period; set => period = value; }
        public int LocationID { get => locationID; set => locationID = value; }
        public int OwnerID { get => ownerID; set => ownerID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
    }
}
