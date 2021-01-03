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
        private string operation;
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
            string operation,
            string details_accommodation,
            string price, string period,
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

        public int AccommodationID { get; }
        public string Accommodation_selection { get; }
        public string Operation { get; }
        public string Details_accommodation { get; }
        public string Price { get; }
        public string Period { get; }
        public int LocationID { get; }
        public int OwnerID { get; }
        public int CustomerID { get; }

        //public int AccommodationAdd(Customer obj)
        //{
        //    try
        //    {

        //        //string query = $"INSERT INTO Accommodation([Accommodation Selection]" +
        //        //    $",Operation,Details,Price,Period,OwnerID,CustomerID)VALUES" +
        //        //    $"('{obj.}',{obj.operation}','{obj.}',{obj.price}12,1,21);";
        //        //return dbHelper.ExecuteNonQuery(query);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}
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
