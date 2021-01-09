using project00.model;
using System;
using System.Data;

namespace project00.Models
{
    //a3 ch to public
    public class accommodation
    {
        private int accommodationID;
        private string accommodation_selection;
        private string operation;
        private string details_accommodation;
        private int price;
        private int period;
        private int locationID;
        private int ownerID;
        private int customerID;

        //a2 def const
        public accommodation()
        {

        }

        public accommodation(int accommodationID,
            string accommodation_selection,
            string operation,
            string details_accommodation,
            int price, int period,
            int locationID, int ownerID, int customerID)
        {
            this.AccommodationID = accommodationID;
            this.Accommodation_selection = accommodation_selection;
            this.Operation = operation;
            this.Details_accommodation = details_accommodation;
            this.Price = price;
            this.Period = period;
            this.LocationID = locationID;
            this.OwnerID = ownerID;
            this.CustomerID = customerID;
        }

        public int AccommodationID { get; set; }
        public string Accommodation_selection { get; set; }
        public string Operation { get; set; }
        public string Details_accommodation { get; set; }
        public int Price { get; set; }
        public int Period { get; set; }
        public int LocationID { get; set; }
        public int OwnerID { get; set; }
        public int CustomerID { get; set; }

        public int AccommodationAdd(accommodation obj)
        {
            try
            {
                string query = $"INSERT INTO Accommodation([Accommodation Selection]" +
                    $",Operation,Details,Price,Period,OwnerID,CustomerID)VALUES" +
                    $"('{obj.Accommodation_selection}','{obj.Operation}','{obj.Details_accommodation}',{obj.Price},{obj.Period},{obj.OwnerID},{obj.CustomerID});";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public int AccommodationDelete(Customer obj)
        {
            try
            {

                string query = $"select *from Customer";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public int AccommodationUpdate(Customer obj)
        {
            try
            {

                string query = $"select *from Customer";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //a1
        public DataTable GetAccInfo(int ownerID)
        {
            try
            {
                string query = $"select a.AccommodationID,a.OwnerID,a.[Accommodation Selection],a.Details,a.Operation,a.Price,a.Period from Accommodation a";
                if (ownerID > 0)
                {
                    query += " where a.ownerid = " + ownerID;
                }
                return dbHelper.ExecuteQuery(query);  //its static, can call method direcly
            }
            catch (Exception ex)
            {
                throw new Exception("GetPaymentInfo Error: " + ex.Message);
            }
        }

        public int AccommodationDelete(int eID)
        {
            try
            {
                string query = $"Delete from Accommodation where AccommodationID={eID}; DELETE Accommodation WHERE AccommodationID={eID}";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable GetAccByID(int ID)
        {
            try
            {
                string query = $"select * from Accommodation a where a.AccommodationID=" + ID;
                return dbHelper.ExecuteQuery(query);  //its static, can call method direcly
            }
            catch (Exception ex)
            {
                throw new Exception("GetAccommodationInfo Error: " + ex.Message);
            }
        }

        internal object GetAccInfo()
        {
            throw new NotImplementedException();
        }

        //public accommodation GetAccInfoByID(int aID)
        //{
        //    try
        //    {
        //        accommodation acc = null;
        //        string query = $"select a.AccommodationID,a.OwnerID,a.[Accommodation Selection],a.Details,a.Operation,a.Price,a.Period from Accommodation a";
        //        var dt =  dbHelper.ExecuteQuery(query);  //its static, can call method direcly
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("GetPaymentInfo Error: " + ex.Message);
        //    }
        //}
    }
}
