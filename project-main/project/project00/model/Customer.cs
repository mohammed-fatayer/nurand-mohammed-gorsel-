using project00.model;
using System;
using System.Data;
using System.Data.SqlClient;
namespace project00.Models
{
    public class Customer : Person
    {


        public int customerID { get; set; }
        public int CustomerID
        {
            get { return customerID; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("please inter a string");
                }
                customerID = value;
            }
        }

        public Customer()
        {

        }
        //public Customer(Person p)
        //{
        //    this.customerID = p.;
        //    this.firstname = p.Firstname;
        //    this.lastname = p.Lastname;
        //    this.gender = p.Gender;
        //    this.email =p.Email;
        //    this.password = p.Password;
        //    this.address = p.Address;            
        //}


        public Customer(int customerID, string firstname, string lastname, string gender,
            string email, string password, string address, int phoneNumber)
        {
            this.customerID = customerID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.email = email;
            this.password = password;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
        public override Person Login(string firstname, string password)
        {
            try
            {
                //string connectionString = "Server = DESKTOP-IPUP7LB; Database = sms; Trusted_Connection = True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string squery = $"select customerID,firstname+' '+lastname name,Gender,Email,Address from customer " +
                        $"where firstname = '{firstname}' and Password = '{password}'";
                    SqlCommand sqlCommand = new SqlCommand(squery, connection);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Customer c = new Customer();
                        c.customerID = int.Parse(dt.Rows[0][customerID].ToString());
                        c.firstname = dt.Rows[0]["name"].ToString();
                        c.Email = dt.Rows[0]["Email"].ToString();
                        c.gender = dt.Rows[0]["Gender"].ToString();
                        c.address = dt.Rows[0]["Address"].ToString();
                        return c;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    throw new Exception("cant connect to sql database");

                }

            }
            catch (Exception)
            {

                throw new Exception("error in login.");
            }
        }
        public int CustomerAdd(Customer obj)
        {
            try
            {

                string query = $"INSERT INTO Customer([Gender]" +
                    $",FirstName,LastName,Email,Password,CustomerID)VALUES" +
                    $"('{obj.gender}','{obj.firstname}'," +
                    $"'{obj.lastname}',{obj.email},{obj.password},{obj.CustomerID});";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public int CustomerDelete(Customer obj)
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
        public int CustomerUpdate(Customer obj)
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

        public DataTable GetCustomerInfo(int id)
        {
            try
            {
                // string connectionString = "Server=YUK-5CD8282ZY6;Database=SMS;Trusted_Connection=True;";
                SqlConnection Connection = new SqlConnection(connectionString);
                Connection.Open();

                if (Connection.State == ConnectionState.Open)
                {
                    //$"select c.CustomerID,c.firstname,c.LastName,c.Gender,c.Email,c.Address from customer c = " + id;
                    string query = $"select * from customer where customerID = " + id;

                    SqlCommand sqlCommand = new SqlCommand(query, Connection);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);

                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Log In Error: " + ex.Message);
            }
        }
        public DataTable newcustomerinfo(string firstname, string lastname, string email, string gender, string password, string address)
        {
            try
            {


                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {




                    SqlCommand cmd = new SqlCommand("INSERT INTO customer" + "(Password,firstname,LastName,Gender,Email,Address)"
                        + "values(@Password,@firstname,@LastName,@Gender,@Email,@Address) ", connection);


                    cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@firstname", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@lastname", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@gender", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@address", System.Data.SqlDbType.NVarChar);

                    cmd.Parameters["@password"].Value = password;
                    cmd.Parameters["@firstname"].Value = firstname;
                    cmd.Parameters["@lastname"].Value = lastname;
                    cmd.Parameters["@email"].Value = email;
                    cmd.Parameters["@gender"].Value = gender;

                    cmd.Parameters["@address"].Value = address;





                    int RowsAffected = cmd.ExecuteNonQuery();





                    connection.Close();

                    return null;

                }
                else
                {
                    throw new Exception("can't connect to server");
                }


            }
            catch (Exception)
            {

                throw new Exception("error in adding new customer");


            }

        }
    }
}
