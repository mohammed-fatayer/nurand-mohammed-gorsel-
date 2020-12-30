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
