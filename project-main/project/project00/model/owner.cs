using System;
using System.Data;
using System.Data.SqlClient;
namespace project00.Models
{
    public class owner : Person
    {
        int ownerID;
        public int OwnerID

        {
            get { return ownerID; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("please inter a string");
                }
                ownerID = value;
            }
        }

        public owner()
        {

        }


        
        public owner(int ownerID, string firstname, string lastname, string gendr, string email, string password, string address)
        {
            this.ownerID = ownerID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gendr;
            this.email = email;
            this.password = password;
            this.address = address;
        }

        public int Name { get; private set; }

        public void Display()
        {
            Console.WriteLine($"ID{ownerID},name{firstname}");
        }
        public DataTable advertismet(string comment,string accommodationid)
        {
            try
            {


                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {




                    SqlCommand cmd = new SqlCommand("INSERT INTO advertisment" + "(accommodationid,comment)" + "values(@accommodationid,@comment) ", connection);


                    cmd.Parameters.Add("@comment", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@accommodationid", System.Data.SqlDbType.NVarChar);
                    
                    cmd.Parameters["@comment"].Value = comment;
                  
                    cmd.Parameters["@accommodationid"].Value = accommodationid;


                    int RowsAffected = cmd.ExecuteNonQuery();


                    connection.Close();

                    return null;

                }
                else
                {
                    throw new Exception("can't connect to server");
                }


            }
            catch (Exception ex)
            {

                throw new Exception("error in adding new advertisment"+ ex.Message);


            }
        }

        public DataTable newownerinfo(string firstname, string lastname, string email, string gender, string password, string address)
        {
            try
            {


                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {




                    SqlCommand cmd = new SqlCommand("INSERT INTO owner" + "(Password,firstname,LastName,Gender,Email,Address)" + "values(@Password,@firstname,@LastName,@Gender,@Email,@Address) ", connection);


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

                throw new Exception("error in adding new owner");


            }
        }


        public override Person Login(string firstname, string password)
        {



            try
            {
                //connectionString = ConfigurationManager.connectionStrings["DBconnectionString"].connectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string squery = $"select OwnerID,firstname+' '+lastname name,Gender,Email,Address from owner " +
                        $"where firstname = '{firstname}' and Password = '{password}'";
                    SqlCommand sqlCommand = new SqlCommand(squery, connection);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        owner o = new owner();
                        o.ownerID = int.Parse(dt.Rows[0]["ownerID"].ToString());
                        o.firstname = dt.Rows[0]["name"].ToString();
                        o.Email = dt.Rows[0]["Email"].ToString();
                        o.gender = dt.Rows[0]["Gender"].ToString();
                        o.address = dt.Rows[0]["Address"].ToString();
                        return o;
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
        public DataTable GetownerInfo(int id)
        {
            try
            {
                // string connectionString = "Server=YUK-5CD8282ZY6;Database=SMS;Trusted_Connection=True;";
                SqlConnection Connection = new SqlConnection(connectionString);
                Connection.Open();

                if (Connection.State == ConnectionState.Open)
                {

                    string query = $"select * from owner where ownerID = " + id;

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


    }
}

