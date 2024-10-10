namespace MyContacts;

/// <summary>
/// Main form for the application.
/// </summary>
public partial class Form1 : Form
{
    private readonly IContactRepository _contactRepository;

    public Form1()
    {
        InitializeComponent();
        _contactRepository = new ContactRepository();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        BindGrid();
    }

    private void dgContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // This method is currently not used.
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        BindGrid();
    }

    /// <summary>
    /// Binds the data grid to the contact repository.
    /// </summary>
    private void BindGrid()
    {
        dgContacts.AutoGenerateColumns = false;
        dgContacts.DataSource = _contactRepository.SelectAll();
    }

    private void addNewUser_Click(object sender, EventArgs e)
    {
        OpenEditOrAddForm();
    }

    /// <summary>
    /// Opens the form to add or edit a contact.
    /// </summary>
    private void OpenEditOrAddForm()
    {
        frmEditOrAdd frmAddOrEdit = new();
        frmAddOrEdit.ShowDialog();
        if (frmAddOrEdit.DialogResult == DialogResult.OK)
        {
            BindGrid();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        DeleteSelectedContact();
    }

    /// <summary>
    /// Deletes the selected contact.
    /// </summary>
    private void DeleteSelectedContact()
    {
        if (dgContacts.CurrentRow != null)
        {
            string? name = dgContacts.CurrentRow.Cells[1].Value?.ToString();
            string? family = dgContacts.CurrentRow.Cells[2].Value?.ToString();
            string fullName = (name ?? "") + " " + (family ?? "");
            if (MessageBox.Show($"ایا از حذف {fullName} اطمینان دارید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (int.TryParse(dgContacts.CurrentRow.Cells[0].Value?.ToString(), out int contactID))
                {
                    _contactRepository.Delete(contactID);
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("شناسه مخاطب نامعتبر است");
                }
            }
        }
        else
        {
            MessageBox.Show("سطر مورد نظر را انتخاب کنید");
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        EditSelectedContact();
    }

    /// <summary>
    /// Edits the selected contact.
    /// </summary>
    private void EditSelectedContact()
    {
        if (dgContacts.CurrentRow != null)
        {
            if (int.TryParse(dgContacts.CurrentRow.Cells[0].Value?.ToString(), out int contactID))
            {
                frmEditOrAdd frmEdit = new()
                {
                    ContactId = contactID
                };
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("شناسه مخاطب نامعتبر است");
            }
        }
        else
        {
            MessageBox.Show("سطر مورد نظر را انتخاب کنید");
        }
    }

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        SearchContacts();
    }

    /// <summary>
    /// Searches for contacts based on the search text.
    /// </summary>
    private void SearchContacts()
    {
        dgContacts.DataSource = _contactRepository.Search(searchTextBox.Text);
    }
}
