using project00.model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace project00.Models
{
    //a3 ch to public
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

        //a2 def const
        public accommodation()
        {

        }

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

        //a1
        public DataTable GetAccInfo()
        {
            try
            {
                string query = $"select a.AccommodationID,a.OwnerID,a.[Accommodation Selection],a.Details,a.Operation,a.Price,a.Period from Accommodation a";
                return dbHelper.ExecuteQuery(query);  //its static, can call method direcly
            }
            catch (Exception ex)
            {
                throw new Exception("GetPaymentInfo Error: " + ex.Message);
            }
        }
    }
}
