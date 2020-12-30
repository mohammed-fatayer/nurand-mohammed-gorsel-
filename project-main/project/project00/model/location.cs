namespace project00.Models
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
