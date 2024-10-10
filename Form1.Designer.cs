namespace MyContacts;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        addNewContact = new ToolStrip();
        addNewUser = new ToolStripButton();
        btnRefresh = new ToolStripButton();
        searchBox = new GroupBox();
        searchTextBox = new TextBox();
        label1 = new Label();
        groupBox2 = new GroupBox();
        btnDelete = new Button();
        btnEdit = new Button();
        dgContacts = new DataGridView();
        ID = new DataGridViewTextBoxColumn();
        MyName = new DataGridViewTextBoxColumn();
        Family = new DataGridViewTextBoxColumn();
        Mobile = new DataGridViewTextBoxColumn();
        Email = new DataGridViewTextBoxColumn();
        Age = new DataGridViewTextBoxColumn();
        addNewContact.SuspendLayout();
        searchBox.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
        SuspendLayout();
        // 
        // addNewContact
        // 
        addNewContact.ImageScalingSize = new Size(20, 20);
        addNewContact.Items.AddRange(new ToolStripItem[] { addNewUser, btnRefresh });
        addNewContact.Location = new Point(0, 0);
        addNewContact.Name = "addNewContact";
        addNewContact.Size = new Size(800, 27);
        addNewContact.TabIndex = 0;
        addNewContact.Text = "افزودن شخص جدید";
        // 
        // addNewUser
        // 
        addNewUser.DisplayStyle = ToolStripItemDisplayStyle.Text;
        addNewUser.Image = (Image)resources.GetObject("addNewUser.Image");
        addNewUser.ImageTransparentColor = Color.Magenta;
        addNewUser.Name = "addNewUser";
        addNewUser.Size = new Size(136, 24);
        addNewUser.Text = "افزودن شخص جدید";
        addNewUser.Click += addNewUser_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
        btnRefresh.ImageTransparentColor = Color.Magenta;
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(93, 24);
        btnRefresh.Text = "به روز رسانی";
        btnRefresh.Click += btnRefresh_Click;
        // 
        // searchBox
        // 
        searchBox.Controls.Add(searchTextBox);
        searchBox.Controls.Add(label1);
        searchBox.Location = new Point(0, 42);
        searchBox.Name = "searchBox";
        searchBox.Size = new Size(800, 56);
        searchBox.TabIndex = 1;
        searchBox.TabStop = false;
        searchBox.Text = "جستجو";
        // 
        // searchTextBox
        // 
        searchTextBox.Location = new Point(412, 22);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.Size = new Size(242, 26);
        searchTextBox.TabIndex = 1;
        searchTextBox.TextChanged += searchTextBox_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(660, 22);
        label1.Name = "label1";
        label1.Size = new Size(56, 18);
        label1.TabIndex = 0;
        label1.Text = "جستجو";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnDelete);
        groupBox2.Controls.Add(btnEdit);
        groupBox2.Controls.Add(dgContacts);
        groupBox2.Location = new Point(0, 104);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(800, 303);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "لیست";
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(557, 250);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 29);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "حذف";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(677, 250);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(94, 29);
        btnEdit.TabIndex = 1;
        btnEdit.Text = "ویرایش";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // dgContacts
        // 
        dgContacts.AllowUserToAddRows = false;
        dgContacts.AllowUserToDeleteRows = false;
        dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgContacts.Columns.AddRange(new DataGridViewColumn[] { ID, MyName, Family, Mobile, Email, Age });
        dgContacts.Location = new Point(6, 48);
        dgContacts.Name = "dgContacts";
        dgContacts.ReadOnly = true;
        dgContacts.RowHeadersWidth = 51;
        dgContacts.Size = new Size(788, 184);
        dgContacts.TabIndex = 0;
        dgContacts.CellContentClick += dgContacts_CellContentClick;
        // 
        // ID
        // 
        ID.DataPropertyName = "ContactUserD";
        ID.HeaderText = "شناسه";
        ID.MinimumWidth = 6;
        ID.Name = "ID";
        ID.ReadOnly = true;
        ID.Width = 125;
        // 
        // MyName
        // 
        MyName.DataPropertyName = "Name";
        MyName.HeaderText = "نام";
        MyName.MinimumWidth = 6;
        MyName.Name = "MyName";
        MyName.ReadOnly = true;
        MyName.Width = 125;
        // 
        // Family
        // 
        Family.DataPropertyName = "Family";
        Family.HeaderText = "نام خانوادگی";
        Family.MinimumWidth = 6;
        Family.Name = "Family";
        Family.ReadOnly = true;
        Family.Width = 125;
        // 
        // Mobile
        // 
        Mobile.DataPropertyName = "Mobile";
        Mobile.HeaderText = "موبایل";
        Mobile.MinimumWidth = 6;
        Mobile.Name = "Mobile";
        Mobile.ReadOnly = true;
        Mobile.Width = 125;
        // 
        // Email
        // 
        Email.DataPropertyName = "Email";
        Email.HeaderText = "ایمیل";
        Email.MinimumWidth = 6;
        Email.Name = "Email";
        Email.ReadOnly = true;
        Email.Width = 125;
        // 
        // Age
        // 
        Age.DataPropertyName = "Age";
        Age.HeaderText = "سن";
        Age.MinimumWidth = 6;
        Age.Name = "Age";
        Age.ReadOnly = true;
        Age.Width = 125;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 405);
        Controls.Add(groupBox2);
        Controls.Add(searchBox);
        Controls.Add(addNewContact);
        Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        Text = "دفترچه تلفن";
        Load += Form1_Load;
        addNewContact.ResumeLayout(false);
        addNewContact.PerformLayout();
        searchBox.ResumeLayout(false);
        searchBox.PerformLayout();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip addNewContact;
    private GroupBox searchBox;
    private GroupBox groupBox2;
    private DataGridView dgContacts;
    private ToolStripButton addNewUser;
    private ToolStripButton btnRefresh;
    private Button btnDelete;
    private Button btnEdit;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn MyName;
    private DataGridViewTextBoxColumn Family;
    private DataGridViewTextBoxColumn Mobile;
    private DataGridViewTextBoxColumn Email;
    private DataGridViewTextBoxColumn Age;
    private TextBox searchTextBox;
    private Label label1;
}
