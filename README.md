# 📱 Phone Book Windows Forms

## Project Overview
The **Phone Book Application** is a simple console-based program built with C#. It allows users to manage their contacts efficiently, providing options to view, search, add, and delete contacts. This project is a foundational step to practice C# concepts and improve coding skills through a practical application.

## ✨ Features
- **View All Contacts**: Users can see a list of all saved contacts.
- **Search Contacts**: Users can search for contacts by name or phone number.
- **Add New Contact**: Users can add a new contact by providing a name and phone number.
- **Delete Contact**: Users can delete a specific contact from the phone book.

## 🛠️ How to Run the Project
1. Clone the repository:
   ```bash
   git clone https://github.com/raityvojdani/phone_book.git
   ```

## 🛠️ Setting Up the Development Environment
1. **Prerequisites**:
   - .NET SDK 8.x.x
   - Visual Studio 2022 or later

2. **Dependencies**:
   - System.Data.SqlClient

3. **Steps**:
   - Open the solution file `MyContacts.sln` in Visual Studio.
   - Restore the dependencies by running:
     ```bash
     dotnet restore
     ```
   - Build the project by running:
     ```bash
     dotnet build
     ```

## 🏗️ Project Architecture
The project follows a simple architecture with the following structure:
- **Forms**: Contains the Windows Forms for the application.
- **Repository**: Contains the interface for the contact repository.
- **Services**: Contains the implementation of the contact repository.

## 🗂️ Codebase Structure
- `Form1.cs`: Main form for the application.
- `Form1.Designer.cs`: Designer file for the main form.
- `frmEditOrAdd.cs`: Form for adding or editing a contact.
- `frmEditOrAdd.Designer.cs`: Designer file for the add/edit form.
- `Repository/IContactRepository.cs`: Interface for contact repository operations.
- `Services/ContactRepository.cs`: Implementation of the contact repository.

## 🤝 Contributing
We welcome contributions to the project! Here are some guidelines to get started:
1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Make your changes and commit them with a clear message.
4. Push your changes to your forked repository.
5. Create a pull request to the main repository.

### Submitting Issues
If you encounter any issues or have suggestions for improvements, please submit an issue on the GitHub repository.

### Pull Requests
When submitting a pull request, please ensure that your changes do not break existing functionality and that your code follows the project's coding standards.

## 📜 License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
