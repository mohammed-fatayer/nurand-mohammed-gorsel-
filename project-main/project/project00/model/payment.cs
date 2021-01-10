using System;
using System.Data;

namespace project00.model
{
    public class Payment
    {
        int paymentID;
        DateTime paymentDate;
        int ownerID;
        int accommodationID;
        int customerID;
        string paymentSelection;
        decimal amount;
        string status;
        decimal remain;

        public Payment()
        {
        }

        public Payment(int paymentID, DateTime paymentDate, int ownerID, int accommodationID, int customerID,
            string paymentSelection, int amount, string status, int remain)
        {
            this.PaymentID = paymentID;
            this.PaymentDate = paymentDate;
            this.OwnerID = ownerID;
            this.AccommodationID = accommodationID;
            this.CustomerID = customerID;
            this.PaymentSelection = paymentSelection;
            this.Amount = amount;
            this.Status = status;
            this.Remain = remain;
        }

        public int PaymentID { get => paymentID; set => paymentID = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }
        public int OwnerID { get => ownerID; set => ownerID = value; }
        public int AccommodationID { get => accommodationID; set => accommodationID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public string PaymentSelection { get => paymentSelection; set => paymentSelection = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string Status { get => status; set => status = value; }
        public decimal Remain { get => remain; set => remain = value; }

        public DataTable GetPaymentInfo(int id)
        {
            try
            {
                string query = $"select TOP(7) e.CustomerID,d.AccommodationID,d.[Accommodation Selection],d.Details,d.Price as Price_TL, d.Operation,p.PaymentSelection,p.Status,p.Remain from customer e JOIN Accommodation d ON d.AccommodationID = d.AccommodationID JOIN payment p ON p.PaymentID = p.PaymentID where CustomersID = " + id;
                return dbHelper.ExecuteQuery(query);  //its static, can call method direcly
            }
            catch (Exception ex)
            {
                throw new Exception("GetPaymentInfo Error: " + ex.Message);
            }
        }
        public int PaymentAdd(Payment obj)
        {
            try
            {
                string query = $"INSERT INTO payment(" +
                    $" [Paymentdate]," +
                    $" [CustomersID]," +
                    $" [OwnerID], " +
                    $" [AccommodationID], " +
                    $" [PaymentSelection]," +
                    $" [Amount]," +
                    $" [Status]," +
                    $" [Remain])VALUES(" +
                    $"'{obj.PaymentDate}'," +
                    $"'{obj.CustomerID}'," +
                    $"'{obj.OwnerID}'," +
                    $"{obj.AccommodationID}," +
                    $"'{obj.paymentSelection}'," +
                    $"{obj.Amount}," +
                    $"'{obj.Status}'," +
                    $"{obj.Remain});";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
