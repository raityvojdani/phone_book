namespace MyContacts;

public partial class Form1 : Form
{
    IContactRepository contactRepository;
    public Form1()
    {
        InitializeComponent();
        contactRepository = new ContactRepository();
    }



    private void Form1_Load(object sender, EventArgs e)
    {
        BindGrid();
    }

    private void dgContacs_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        BindGrid();
    }

    private void BindGrid()
    {

        dgContacs.AutoGenerateColumns = false;
        dgContacs.DataSource = contactRepository.SelectAll();
    }

    private void addNewUser_Click(object sender, EventArgs e)
    {
        frmEditOrAdd frmAddOrEdit = new frmEditOrAdd();
        frmAddOrEdit.ShowDialog();
        if (frmAddOrEdit.DialogResult == DialogResult.OK)
        {
            BindGrid();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgContacs.CurrentRow != null)
        {
            string name = dgContacs.CurrentRow.Cells[1].Value.ToString();
            string family = dgContacs.CurrentRow.Cells[2].Value.ToString();
            string fullName = name + " " + family;
            if (MessageBox.Show($"ایا از حذف {fullName} اطمینان دارید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int contactID = int.Parse(dgContacs.CurrentRow.Cells[0].Value.ToString());
                contactRepository.Delete(contactID);
                BindGrid();
            }
        }
        else
        {
            MessageBox.Show("سطر مورد نظر را انتخاب کنید");
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgContacs.CurrentRow != null)
        {

            int contctID = int.Parse(dgContacs.CurrentRow.Cells[0].Value.ToString());
            frmEditOrAdd frmEdit = new frmEditOrAdd();
            frmEdit.contactId = contctID;
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {

                BindGrid();

            }
        }
        else
        {
            MessageBox.Show("سطر مورد نظر را انتخاب کنید");
        }
    }

   

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        dgContacs.DataSource = contactRepository.Search(searchTextBox.Text);
    }
}
