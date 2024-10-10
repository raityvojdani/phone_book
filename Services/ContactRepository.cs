using System.Data;
using System.Data.SqlClient;

namespace MyContacts;

public class ContactRepository : IContactRepository
{
    private readonly string connectionString = "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true;";

    public bool Delete(int contactID)
    {
        using SqlConnection sqlConnection = new(connectionString);
        string query = "DELETE FROM MyContact WHERE ContactUserD = @ID";
        using SqlCommand sqlCommand = new(query, sqlConnection);
        sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = contactID;
        sqlConnection.Open();
        try
        {
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

    public bool Insert(string name, string family, string mobile, string email, string address, int age)
    {
        using SqlConnection connection = new(connectionString);
        string query = "INSERT INTO MyContact (Name, Family, Mobile, Email, Age, Address) VALUES (@Name, @Family, @Mobile, @Email, @Age, @Address)";
        using SqlCommand cmd = new(query, connection);
        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
        cmd.Parameters.Add("@Family", SqlDbType.NVarChar).Value = family;
        cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = mobile;
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
        cmd.Parameters.Add("@Age", SqlDbType.Int).Value = age;
        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;
        connection.Open();
        try
        {
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

    public DataTable Search(string parameter)
    {
        string query = "SELECT * FROM MyContact WHERE Name LIKE @parameter OR Family LIKE @parameter";
        using SqlConnection connection = new(connectionString);
        using SqlDataAdapter adapter = new(query, connection);
        adapter.SelectCommand.Parameters.Add("@parameter", SqlDbType.NVarChar).Value = "%" + parameter + "%";
        DataTable dataTable = new();
        adapter.Fill(dataTable);
        return dataTable;
    }

    public DataTable SelectAll()
    {
        string query = "SELECT * FROM MyContact";
        using SqlConnection connection = new(connectionString);
        using SqlDataAdapter adapter = new(query, connection);
        DataTable dataTable = new();
        adapter.Fill(dataTable);
        return dataTable;
    }

    public DataTable SelectRow(int contactID)
    {
        string query = "SELECT * FROM MyContact WHERE ContactUserD = @ID";
        using SqlConnection connection = new(connectionString);
        using SqlDataAdapter adapter = new(query, connection);
        adapter.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = contactID;
        DataTable dataTable = new();
        adapter.Fill(dataTable);
        return dataTable;
    }

    public bool Update(int contactID, string name, string family, string mobile, string email, string address, int age)
    {
        using SqlConnection connection = new(connectionString);
        string query = "UPDATE MyContact SET Name = @Name, Family = @Family, Mobile = @Mobile, Email = @Email, Age = @Age, Address = @Address WHERE ContactUserD = @ID";
        using SqlCommand cmd = new(query, connection);
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = contactID;
        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
        cmd.Parameters.Add("@Family", SqlDbType.NVarChar).Value = family;
        cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = mobile;
        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
        cmd.Parameters.Add("@Age", SqlDbType.Int).Value = age;
        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;
        connection.Open();
        try
        {
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
