using System.Data;

namespace MyContacts;

/// <summary>
/// Form for adding or editing a contact.
/// </summary>
public partial class frmEditOrAdd : Form
{
    public int ContactId { get; set; } = 0;
    private readonly IContactRepository _contactRepository;

    public frmEditOrAdd()
    {
        InitializeComponent();
        _contactRepository = new ContactRepository();
    }

    private void frmEditOrAdd_Load(object sender, EventArgs e)
    {
        Text = ContactId == 0 ? "افزودن شخص جدید" : "ویرایش کاربر";
        if (ContactId != 0)
        {
            LoadContactDetails();
            btnSubmit.Text = "ویرایش";
        }
    }

    /// <summary>
    /// Loads the contact details into the form fields.
    /// </summary>
    private void LoadContactDetails()
    {
        DataTable dt = _contactRepository.SelectRow(ContactId);
        if (dt.Rows.Count > 0)
        {
            var row = dt.Rows[0];
            NameBox.Text = row[1].ToString();
            FamilyBox.Text = row[2].ToString();
            MobileBox.Text = row[3].ToString();
            EmailBox.Text = row[4].ToString();
            AgeBox.Text = row[5].ToString();
            AddressBox.Text = row[6].ToString();
        }
    }

    /// <summary>
    /// Validates the input fields.
    /// </summary>
    /// <returns>True if all inputs are valid, otherwise false.</returns>
    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(NameBox.Text))
        {
            ShowError("نام را وارد کنید");
            return false;
        }
        if (string.IsNullOrWhiteSpace(FamilyBox.Text))
        {
            ShowError("نام خانوادگی را وارد کنید");
            return false;
        }
        if (string.IsNullOrWhiteSpace(EmailBox.Text))
        {
            ShowError("ایمیل را وارد کنید");
            return false;
        }
        if (AgeBox.Value == 0)
        {
            ShowError("سن را وارد کنید");
            return false;
        }
        if (string.IsNullOrWhiteSpace(MobileBox.Text))
        {
            ShowError("موبایل را وارد کنید");
            return false;
        }
        return true;
    }

    private void ShowError(string message)
    {
        MessageBox.Show(message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidateInputs())
        {
            bool isSuccess = ContactId == 0 ? AddContact() : UpdateContact();

            MessageBox.Show(isSuccess ? "عملیات با موفقیت انجام شد" : "عملیات با خطا مواجه شد",
                            isSuccess ? "موفقیت آمیز" : "خطا",
                            MessageBoxButtons.OK,
                            isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (isSuccess)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }

    /// <summary>
    /// Adds a new contact.
    /// </summary>
    /// <returns>True if the operation is successful, otherwise false.</returns>
    private bool AddContact()
    {
        return _contactRepository.Insert(NameBox.Text, FamilyBox.Text, MobileBox.Text, EmailBox.Text, AddressBox.Text, (int)AgeBox.Value);
    }

    /// <summary>
    /// Updates an existing contact.
    /// </summary>
    /// <returns>True if the operation is successful, otherwise false.</returns>
    private bool UpdateContact()
    {
        return _contactRepository.Update(ContactId, NameBox.Text, FamilyBox.Text, MobileBox.Text, EmailBox.Text, AddressBox.Text, (int)AgeBox.Value);
    }
}
