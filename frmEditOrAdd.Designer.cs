namespace MyContacts;

partial class frmEditOrAdd
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        NameBox = new TextBox();
        EmailBox = new TextBox();
        Address = new Label();
        Email = new Label();
        AddressBox = new TextBox();
        Age = new Label();
        MobileBox = new TextBox();
        Mobile = new Label();
        FamilyBox = new TextBox();
        Family = new Label();
        btnSubmit = new Button();
        AgeBox = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)AgeBox).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(738, 23);
        label1.Name = "label1";
        label1.Size = new Size(34, 20);
        label1.TabIndex = 0;
        label1.Text = "نام :";
        // 
        // NameBox
        // 
        NameBox.Location = new Point(511, 23);
        NameBox.Name = "NameBox";
        NameBox.Size = new Size(221, 27);
        NameBox.TabIndex = 1;
        // 
        // EmailBox
        // 
        EmailBox.Location = new Point(78, 138);
        EmailBox.Name = "EmailBox";
        EmailBox.Size = new Size(654, 27);
        EmailBox.TabIndex = 3;
        // 
        // Address
        // 
        Address.AutoSize = true;
        Address.Location = new Point(739, 233);
        Address.Name = "Address";
        Address.Size = new Size(51, 20);
        Address.TabIndex = 2;
        Address.Text = "آدرس :";
        // 
        // Email
        // 
        Email.AutoSize = true;
        Email.Location = new Point(739, 145);
        Email.Name = "Email";
        Email.Size = new Size(49, 20);
        Email.TabIndex = 4;
        Email.Text = "ایمیل :";
        // 
        // AddressBox
        // 
        AddressBox.Location = new Point(78, 230);
        AddressBox.Multiline = true;
        AddressBox.Name = "AddressBox";
        AddressBox.Size = new Size(654, 138);
        AddressBox.TabIndex = 7;
        // 
        // Age
        // 
        Age.AutoSize = true;
        Age.Location = new Point(342, 85);
        Age.Name = "Age";
        Age.Size = new Size(39, 20);
        Age.TabIndex = 6;
        Age.Text = "سن :";
        // 
        // MobileBox
        // 
        MobileBox.Location = new Point(511, 75);
        MobileBox.Name = "MobileBox";
        MobileBox.Size = new Size(221, 27);
        MobileBox.TabIndex = 9;
        // 
        // Mobile
        // 
        Mobile.AutoSize = true;
        Mobile.Location = new Point(738, 78);
        Mobile.Name = "Mobile";
        Mobile.Size = new Size(57, 20);
        Mobile.TabIndex = 8;
        Mobile.Text = "موبایل :";
        // 
        // FamilyBox
        // 
        FamilyBox.Location = new Point(78, 23);
        FamilyBox.Name = "FamilyBox";
        FamilyBox.Size = new Size(221, 27);
        FamilyBox.TabIndex = 11;
        // 
        // Family
        // 
        Family.AutoSize = true;
        Family.Location = new Point(322, 30);
        Family.Name = "Family";
        Family.Size = new Size(97, 20);
        Family.TabIndex = 10;
        Family.Text = "نام خانوادگی :";
        // 
        // btnSubmit
        // 
        btnSubmit.Location = new Point(638, 398);
        btnSubmit.Name = "btnSubmit";
        btnSubmit.Size = new Size(94, 29);
        btnSubmit.TabIndex = 12;
        btnSubmit.Text = "ثبت";
        btnSubmit.UseVisualStyleBackColor = true;
        btnSubmit.Click += btnSubmit_Click;
        // 
        // AgeBox
        // 
        AgeBox.Location = new Point(86, 85);
        AgeBox.Name = "AgeBox";
        AgeBox.Size = new Size(250, 27);
        AgeBox.TabIndex = 13;
        // 
        // frmEditOrAdd
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(AgeBox);
        Controls.Add(btnSubmit);
        Controls.Add(FamilyBox);
        Controls.Add(Family);
        Controls.Add(MobileBox);
        Controls.Add(Mobile);
        Controls.Add(AddressBox);
        Controls.Add(Age);
        Controls.Add(Email);
        Controls.Add(EmailBox);
        Controls.Add(Address);
        Controls.Add(NameBox);
        Controls.Add(label1);
        Name = "frmEditOrAdd";
        RightToLeft = RightToLeft.Yes;
        StartPosition = FormStartPosition.CenterParent;
        Load += frmEditOrAdd_Load;
        ((System.ComponentModel.ISupportInitialize)AgeBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox NameBox;
    private TextBox EmailBox;
    private Label Address;
    private Label Email;
    private TextBox AddressBox;
    private Label Age;
    private TextBox MobileBox;
    private Label Mobile;
    private TextBox FamilyBox;
    private Label Family;
    private Button btnSubmit;
    private NumericUpDown AgeBox;
}