using System;
using System.Data;
using System.Data.SqlClient;  // Use Microsoft.Data.SqlClient instead of System.Data.SqlClient

namespace MyContacts
{
    public class ContactRepository : IContactRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Cantact_DB;Integrated Security=true;";

        public bool Delete(int contactID)
        { SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From MyContact where ContactUserD=@ID";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ID", contactID);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { 
                sqlConnection.Close();  
            }
        }

        public bool Insert(string name, string family, string mobile, string email, string address, int age)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
               
                string query = "Insert Into MyContact (Name,Family,Mobile,Email,Age,Address) values (@Name,@Family,@Mobile,@Email,@Age,@Address)";
                SqlCommand cmd = new SqlCommand(query, connection);
                
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Family", family);
                cmd.Parameters.AddWithValue("@Mobile", mobile);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Address", address);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally {
                connection.Close();
            }

        }

        public DataTable Search(string parameter)
        {
            string query = "Select * From MyContact where Name like @parameter or Family like @parameter";
            // Use the correct namespace and class names
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter","%" + parameter + "%");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable SelectAll()
        {
            string query = "Select * From MyContact";

            // Use the correct namespace and class names
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable SelectRow(int contactID)
        {
            string query = "Select * From MyContact where ContactUserD="+contactID;

            // Use the correct namespace and class names
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Update(int contactID, string name, string family, string mobile, string email, string address, int age)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query= "Update MyContact Set Name=@Name,Family=@Family,Mobile=@Mobile,Email=@Email,Age=@Age,Address=@Address where ContactUserD="+contactID;
          SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue ("@Name", name);
                cmd.Parameters.AddWithValue("@Family", family);
                cmd.Parameters.AddWithValue("@Mobile", mobile);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Address", address);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally
            {
                connection.Close();
            }
        }
    }
}
