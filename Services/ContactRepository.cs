using System;
using System.Data;
using System.Data.SqlClient;

namespace MyContacts
{
    public class ContactRepository : IContactRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Cantact_DB;Integrated Security=true;";

        public bool Delete(int contactID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM MyContact WHERE ContactUserD = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@ID", contactID);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    // Log the exception (ex) here for debugging purposes
                    Console.WriteLine($"Error deleting contact: {ex.Message}");
                    return false;
                }
            }
        }

        public bool Insert(string name, string family, string mobile, string email, string address, int age)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO MyContact (Name, Family, Mobile, Email, Age, Address) VALUES (@Name, @Family, @Mobile, @Email, @Age, @Address)";
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
                catch (Exception ex)
                {
                    // Log the exception (ex) here for debugging purposes
                    Console.WriteLine($"Error inserting contact: {ex.Message}");
                    return false;
                }
            }
        }

        public DataTable Search(string parameter)
        {
            string query = "SELECT * FROM MyContact WHERE Name LIKE @parameter OR Family LIKE @parameter";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable SelectAll()
        {
            string query = "SELECT * FROM MyContact";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable SelectRow(int contactID)
        {
            string query = "SELECT * FROM MyContact WHERE ContactUserD = @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", contactID);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public bool Update(int contactID, string name, string family, string mobile, string email, string address, int age)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE MyContact SET Name = @Name, Family = @Family, Mobile = @Mobile, Email = @Email, Age = @Age, Address = @Address WHERE ContactUserD = @ID";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ID", contactID);
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
                catch (Exception ex)
                {
                    // Log the exception (ex) here for debugging purposes
                    Console.WriteLine($"Error updating contact: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
