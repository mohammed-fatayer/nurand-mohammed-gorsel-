using System;
using System.Configuration;
using System.Data;

namespace project00.model
{
    public class Payment
    {
        int payingID;
        string payingSelection;
        int amount;
        string status;
        int remain;
        DateTime payingDate;
        int accommodationID;
        int customerID;
        private object connectionString;

        public Payment()
        {
        }

        // def const
        //public Payment()
        //{
        //    connectionString = ConfigurationManager.ConnectionStrings["DBconnectionString"].ConnectionString;
        //}

        public Payment(int payingID, string payingSelection, int amount, string status, int remain,
            DateTime payingDate, int accommodationID, int customerID, object connectionString)
        {
            this.payingID = payingID;
            this.payingSelection = payingSelection;
            this.amount = amount;
            this.status = status;
            this.remain = remain;
            this.payingDate = payingDate;
            this.accommodationID = accommodationID;
            this.customerID = customerID;
            this.connectionString = connectionString;
        }

        public DataTable GetPaymentInfo()
        {
            try
            {
                string query = $"SELECT *from payment";
                return dbHelper.ExecuteQuery(query);  //its static, can call method direcly
            }
            catch (Exception ex)
            {
                throw new Exception("GetPaymentInfo Error: " + ex.Message);
            }
        }
    }
}
