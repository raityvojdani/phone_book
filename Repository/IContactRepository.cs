using System.Data;

namespace MyContacts;

/// <summary>
/// Interface for contact repository operations.
/// </summary>
public interface IContactRepository
{
    /// <summary>
    /// Selects all contacts.
    /// </summary>
    /// <returns>A DataTable containing all contacts.</returns>
    DataTable SelectAll();

    /// <summary>
    /// Selects a specific contact by ID.
    /// </summary>
    /// <param name="contactID">The ID of the contact to select.</param>
    /// <returns>A DataTable containing the selected contact.</returns>
    DataTable SelectRow(int contactID);

    /// <summary>
    /// Searches for contacts based on a parameter.
    /// </summary>
    /// <param name="parameter">The search parameter.</param>
    /// <returns>A DataTable containing the search results.</returns>
    DataTable Search(string parameter);

    /// <summary>
    /// Inserts a new contact.
    /// </summary>
    /// <param name="name">The name of the contact.</param>
    /// <param name="family">The family name of the contact.</param>
    /// <param name="mobile">The mobile number of the contact.</param>
    /// <param name="email">The email address of the contact.</param>
    /// <param name="address">The address of the contact.</param>
    /// <param name="age">The age of the contact.</param>
    /// <returns>True if the operation is successful, otherwise false.</returns>
    bool Insert(string name, string family, string mobile, string email, string address, int age);

    /// <summary>
    /// Updates an existing contact.
    /// </summary>
    /// <param name="contactID">The ID of the contact to update.</param>
    /// <param name="name">The name of the contact.</param>
    /// <param name="family">The family name of the contact.</param>
    /// <param name="mobile">The mobile number of the contact.</param>
    /// <param name="email">The email address of the contact.</param>
    /// <param name="address">The address of the contact.</param>
    /// <param name="age">The age of the contact.</param>
    /// <returns>True if the operation is successful, otherwise false.</returns>
    bool Update(int contactID, string name, string family, string mobile, string email, string address, int age);

    /// <summary>
    /// Deletes a contact.
    /// </summary>
    /// <param name="contactID">The ID of the contact to delete.</param>
    /// <returns>True if the operation is successful, otherwise false.</returns>
    bool Delete(int contactID);
}
