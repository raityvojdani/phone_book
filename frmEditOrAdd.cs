using System;
using System.Data;
using System.Windows.Forms;

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
        if (ContactId == 0)
        {
            this.Text = "افزودن شخص جدید";
        }
        else
        {
            this.Text = "ویرایش کاربر";
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
        NameBox.Text = dt.Rows[0][1].ToString();
        FamilyBox.Text = dt.Rows[0][2].ToString();
        MobileBox.Text = dt.Rows[0][3].ToString();
        EmailBox.Text = dt.Rows[0][4].ToString();
        AgeBox.Text = dt.Rows[0][5].ToString();
        AddressBox.Text = dt.Rows[0][6].ToString();
    }

    /// <summary>
    /// Validates the input fields.
    /// </summary>
    /// <returns>True if all inputs are valid, otherwise false.</returns>
    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(NameBox.Text))
        {
            MessageBox.Show("نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (string.IsNullOrWhiteSpace(FamilyBox.Text))
        {
            MessageBox.Show("نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (string.IsNullOrWhiteSpace(EmailBox.Text))
        {
            MessageBox.Show("ایمیل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (AgeBox.Value == 0)
        {
            MessageBox.Show("سن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (string.IsNullOrWhiteSpace(MobileBox.Text))
        {
            MessageBox.Show("موبایل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ValidateInputs())
        {
            bool isSuccess = ContactId == 0 ? AddContact() : UpdateContact();

            if (isSuccess)
            {
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("عملیات با خطا مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
