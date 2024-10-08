using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts;
public partial class frmEditOrAdd : Form
{
    public int contactId = 0;
    IContactRepository contactRepository;
    public frmEditOrAdd()
    {
        InitializeComponent();
        contactRepository = new ContactRepository();
    }



    private void frmEditOrAdd_Load(object sender, EventArgs e)
    {
        if (contactId == 0)
        {
            this.Text="افزودن شخص جدید";
        }
        else { 
            this.Text="ویرایش کاربر";
            DataTable dt = contactRepository.SelectRow(contactId);
            NameBox.Text = dt.Rows[0][1].ToString();
            FamilyBox.Text = dt.Rows[0][2].ToString();
            MobileBox.Text = dt.Rows[0][3].ToString();
            EmailBox.Text = dt.Rows[0][4].ToString();
            AgeBox.Text = dt.Rows[0][5].ToString();
            AddressBox.Text = dt.Rows[0][6].ToString();
            btnSubmit.Text = "ویرایش";

        }
    }

    bool validateInputs()
    {
        if (NameBox.Text == "")
        {
            MessageBox.Show("نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (FamilyBox.Text == "")
        {
            MessageBox.Show("نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (EmailBox.Text == "")
        {
            MessageBox.Show("ایمیل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (AgeBox.Value == 0)
        {
            MessageBox.Show("سن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (MobileBox.Text == "")
        {
            MessageBox.Show("موبایل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        if (validateInputs())
        {
            bool isSuccess;
            if (contactId == 0)
            {
                isSuccess = contactRepository.Insert(NameBox.Text, FamilyBox.Text, MobileBox.Text, EmailBox.Text, AddressBox.Text, (int)AgeBox.Value);

            }
            else
            {
                isSuccess = contactRepository.Update(contactId,NameBox.Text, FamilyBox.Text, MobileBox.Text, EmailBox.Text, AddressBox.Text, (int)AgeBox.Value);

            }

            if (isSuccess)
            {
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK; 
            }
            else {
                MessageBox.Show("عملیات با خطا مواجه شد","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
