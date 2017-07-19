namespace AuthINI
{
    partial class Admin
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
            this.listViewUserList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAddPatronymic = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.labelAddSurname = new System.Windows.Forms.Label();
            this.labelAddPassword = new System.Windows.Forms.Label();
            this.labelAddLogin = new System.Windows.Forms.Label();
            this.comboBoxAddGroupRole = new System.Windows.Forms.ComboBox();
            this.textBoxAddSurname = new System.Windows.Forms.TextBox();
            this.textBoxAddPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddPassword = new System.Windows.Forms.TextBox();
            this.textBoxAddLogin = new System.Windows.Forms.TextBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelEditLogin = new System.Windows.Forms.Label();
            this.labelEditPatronymic = new System.Windows.Forms.Label();
            this.textBoxEditLogin = new System.Windows.Forms.TextBox();
            this.labelEditName = new System.Windows.Forms.Label();
            this.textBoxEditPassword = new System.Windows.Forms.TextBox();
            this.labelEditSurname = new System.Windows.Forms.Label();
            this.textBoxEditName = new System.Windows.Forms.TextBox();
            this.labelEditPassword = new System.Windows.Forms.Label();
            this.textBoxEditPartonymic = new System.Windows.Forms.TextBox();
            this.textBoxEditSurname = new System.Windows.Forms.TextBox();
            this.comboBoxEditGroupRole = new System.Windows.Forms.ComboBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.buttonUpdateUserList = new System.Windows.Forms.Button();
            this.checkedListBoxOperationAdmin = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewUserList
            // 
            this.listViewUserList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewUserList.HoverSelection = true;
            this.listViewUserList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewUserList.Location = new System.Drawing.Point(8, 12);
            this.listViewUserList.Name = "listViewUserList";
            this.listViewUserList.Size = new System.Drawing.Size(673, 165);
            this.listViewUserList.TabIndex = 1;
            this.listViewUserList.UseCompatibleStateImageBehavior = false;
            this.listViewUserList.View = System.Windows.Forms.View.Details;
            this.listViewUserList.Click += new System.EventHandler(this.listViewUserList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Группа";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Логин";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Пароль";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Фамилия";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Имя";
            this.columnHeader6.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Отчество";
            this.columnHeader7.Width = 109;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAddUser);
            this.groupBoxAdd.Controls.Add(this.label7);
            this.groupBoxAdd.Controls.Add(this.labelAddPatronymic);
            this.groupBoxAdd.Controls.Add(this.labelAddName);
            this.groupBoxAdd.Controls.Add(this.labelAddSurname);
            this.groupBoxAdd.Controls.Add(this.labelAddPassword);
            this.groupBoxAdd.Controls.Add(this.labelAddLogin);
            this.groupBoxAdd.Controls.Add(this.comboBoxAddGroupRole);
            this.groupBoxAdd.Controls.Add(this.textBoxAddSurname);
            this.groupBoxAdd.Controls.Add(this.textBoxAddPatronymic);
            this.groupBoxAdd.Controls.Add(this.textBoxAddName);
            this.groupBoxAdd.Controls.Add(this.textBoxAddPassword);
            this.groupBoxAdd.Controls.Add(this.textBoxAddLogin);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 238);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(329, 161);
            this.groupBoxAdd.TabIndex = 2;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавить";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Enabled = false;
            this.buttonAddUser.Location = new System.Drawing.Point(197, 84);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(114, 59);
            this.buttonAddUser.TabIndex = 11;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Группа (права)";
            // 
            // labelAddPatronymic
            // 
            this.labelAddPatronymic.AutoSize = true;
            this.labelAddPatronymic.Location = new System.Drawing.Point(6, 126);
            this.labelAddPatronymic.Name = "labelAddPatronymic";
            this.labelAddPatronymic.Size = new System.Drawing.Size(57, 13);
            this.labelAddPatronymic.TabIndex = 9;
            this.labelAddPatronymic.Text = "Отчество:";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(6, 100);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(32, 13);
            this.labelAddName.TabIndex = 8;
            this.labelAddName.Text = "Имя:";
            // 
            // labelAddSurname
            // 
            this.labelAddSurname.AutoSize = true;
            this.labelAddSurname.Location = new System.Drawing.Point(6, 74);
            this.labelAddSurname.Name = "labelAddSurname";
            this.labelAddSurname.Size = new System.Drawing.Size(59, 13);
            this.labelAddSurname.TabIndex = 7;
            this.labelAddSurname.Text = "Фамилия:";
            // 
            // labelAddPassword
            // 
            this.labelAddPassword.AutoSize = true;
            this.labelAddPassword.Location = new System.Drawing.Point(6, 48);
            this.labelAddPassword.Name = "labelAddPassword";
            this.labelAddPassword.Size = new System.Drawing.Size(48, 13);
            this.labelAddPassword.TabIndex = 6;
            this.labelAddPassword.Text = "Пароль:";
            // 
            // labelAddLogin
            // 
            this.labelAddLogin.AutoSize = true;
            this.labelAddLogin.Location = new System.Drawing.Point(6, 22);
            this.labelAddLogin.Name = "labelAddLogin";
            this.labelAddLogin.Size = new System.Drawing.Size(41, 13);
            this.labelAddLogin.TabIndex = 2;
            this.labelAddLogin.Text = "Логин:";
            // 
            // comboBoxAddGroupRole
            // 
            this.comboBoxAddGroupRole.Enabled = false;
            this.comboBoxAddGroupRole.FormattingEnabled = true;
            this.comboBoxAddGroupRole.Items.AddRange(new object[] {
            "Пользователи",
            "Администраторы"});
            this.comboBoxAddGroupRole.Location = new System.Drawing.Point(196, 44);
            this.comboBoxAddGroupRole.Name = "comboBoxAddGroupRole";
            this.comboBoxAddGroupRole.Size = new System.Drawing.Size(116, 21);
            this.comboBoxAddGroupRole.TabIndex = 5;
            // 
            // textBoxAddSurname
            // 
            this.textBoxAddSurname.Enabled = false;
            this.textBoxAddSurname.Location = new System.Drawing.Point(68, 71);
            this.textBoxAddSurname.Name = "textBoxAddSurname";
            this.textBoxAddSurname.Size = new System.Drawing.Size(101, 20);
            this.textBoxAddSurname.TabIndex = 4;
            // 
            // textBoxAddPatronymic
            // 
            this.textBoxAddPatronymic.Enabled = false;
            this.textBoxAddPatronymic.Location = new System.Drawing.Point(68, 123);
            this.textBoxAddPatronymic.Name = "textBoxAddPatronymic";
            this.textBoxAddPatronymic.Size = new System.Drawing.Size(101, 20);
            this.textBoxAddPatronymic.TabIndex = 3;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Enabled = false;
            this.textBoxAddName.Location = new System.Drawing.Point(68, 97);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(101, 20);
            this.textBoxAddName.TabIndex = 2;
            // 
            // textBoxAddPassword
            // 
            this.textBoxAddPassword.Enabled = false;
            this.textBoxAddPassword.Location = new System.Drawing.Point(68, 45);
            this.textBoxAddPassword.Name = "textBoxAddPassword";
            this.textBoxAddPassword.Size = new System.Drawing.Size(101, 20);
            this.textBoxAddPassword.TabIndex = 1;
            // 
            // textBoxAddLogin
            // 
            this.textBoxAddLogin.Enabled = false;
            this.textBoxAddLogin.Location = new System.Drawing.Point(68, 19);
            this.textBoxAddLogin.Name = "textBoxAddLogin";
            this.textBoxAddLogin.Size = new System.Drawing.Size(101, 20);
            this.textBoxAddLogin.TabIndex = 0;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonEditUser);
            this.groupBoxEdit.Controls.Add(this.label8);
            this.groupBoxEdit.Controls.Add(this.labelEditLogin);
            this.groupBoxEdit.Controls.Add(this.labelEditPatronymic);
            this.groupBoxEdit.Controls.Add(this.textBoxEditLogin);
            this.groupBoxEdit.Controls.Add(this.labelEditName);
            this.groupBoxEdit.Controls.Add(this.textBoxEditPassword);
            this.groupBoxEdit.Controls.Add(this.labelEditSurname);
            this.groupBoxEdit.Controls.Add(this.textBoxEditName);
            this.groupBoxEdit.Controls.Add(this.labelEditPassword);
            this.groupBoxEdit.Controls.Add(this.textBoxEditPartonymic);
            this.groupBoxEdit.Controls.Add(this.textBoxEditSurname);
            this.groupBoxEdit.Controls.Add(this.comboBoxEditGroupRole);
            this.groupBoxEdit.Location = new System.Drawing.Point(347, 238);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(334, 161);
            this.groupBoxEdit.TabIndex = 3;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Изменить";
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Enabled = false;
            this.buttonEditUser.Location = new System.Drawing.Point(196, 85);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(114, 58);
            this.buttonEditUser.TabIndex = 12;
            this.buttonEditUser.Text = "Изменить";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Группа (права)";
            // 
            // labelEditLogin
            // 
            this.labelEditLogin.AutoSize = true;
            this.labelEditLogin.Location = new System.Drawing.Point(6, 22);
            this.labelEditLogin.Name = "labelEditLogin";
            this.labelEditLogin.Size = new System.Drawing.Size(41, 13);
            this.labelEditLogin.TabIndex = 13;
            this.labelEditLogin.Text = "Логин:";
            // 
            // labelEditPatronymic
            // 
            this.labelEditPatronymic.AutoSize = true;
            this.labelEditPatronymic.Location = new System.Drawing.Point(6, 126);
            this.labelEditPatronymic.Name = "labelEditPatronymic";
            this.labelEditPatronymic.Size = new System.Drawing.Size(57, 13);
            this.labelEditPatronymic.TabIndex = 21;
            this.labelEditPatronymic.Text = "Отчество:";
            // 
            // textBoxEditLogin
            // 
            this.textBoxEditLogin.Location = new System.Drawing.Point(68, 19);
            this.textBoxEditLogin.Name = "textBoxEditLogin";
            this.textBoxEditLogin.Size = new System.Drawing.Size(101, 20);
            this.textBoxEditLogin.TabIndex = 11;
            // 
            // labelEditName
            // 
            this.labelEditName.AutoSize = true;
            this.labelEditName.Location = new System.Drawing.Point(6, 100);
            this.labelEditName.Name = "labelEditName";
            this.labelEditName.Size = new System.Drawing.Size(32, 13);
            this.labelEditName.TabIndex = 20;
            this.labelEditName.Text = "Имя:";
            // 
            // textBoxEditPassword
            // 
            this.textBoxEditPassword.Location = new System.Drawing.Point(68, 45);
            this.textBoxEditPassword.Name = "textBoxEditPassword";
            this.textBoxEditPassword.Size = new System.Drawing.Size(101, 20);
            this.textBoxEditPassword.TabIndex = 12;
            // 
            // labelEditSurname
            // 
            this.labelEditSurname.AutoSize = true;
            this.labelEditSurname.Location = new System.Drawing.Point(6, 74);
            this.labelEditSurname.Name = "labelEditSurname";
            this.labelEditSurname.Size = new System.Drawing.Size(59, 13);
            this.labelEditSurname.TabIndex = 19;
            this.labelEditSurname.Text = "Фамилия:";
            // 
            // textBoxEditName
            // 
            this.textBoxEditName.Location = new System.Drawing.Point(68, 97);
            this.textBoxEditName.Name = "textBoxEditName";
            this.textBoxEditName.Size = new System.Drawing.Size(101, 20);
            this.textBoxEditName.TabIndex = 14;
            // 
            // labelEditPassword
            // 
            this.labelEditPassword.AutoSize = true;
            this.labelEditPassword.Location = new System.Drawing.Point(6, 48);
            this.labelEditPassword.Name = "labelEditPassword";
            this.labelEditPassword.Size = new System.Drawing.Size(48, 13);
            this.labelEditPassword.TabIndex = 18;
            this.labelEditPassword.Text = "Пароль:";
            // 
            // textBoxEditPartonymic
            // 
            this.textBoxEditPartonymic.Location = new System.Drawing.Point(68, 123);
            this.textBoxEditPartonymic.Name = "textBoxEditPartonymic";
            this.textBoxEditPartonymic.Size = new System.Drawing.Size(101, 20);
            this.textBoxEditPartonymic.TabIndex = 15;
            // 
            // textBoxEditSurname
            // 
            this.textBoxEditSurname.Location = new System.Drawing.Point(68, 71);
            this.textBoxEditSurname.Name = "textBoxEditSurname";
            this.textBoxEditSurname.Size = new System.Drawing.Size(101, 20);
            this.textBoxEditSurname.TabIndex = 16;
            // 
            // comboBoxEditGroupRole
            // 
            this.comboBoxEditGroupRole.Enabled = false;
            this.comboBoxEditGroupRole.FormattingEnabled = true;
            this.comboBoxEditGroupRole.Items.AddRange(new object[] {
            "Пользователи",
            "Администраторы"});
            this.comboBoxEditGroupRole.Location = new System.Drawing.Point(196, 44);
            this.comboBoxEditGroupRole.Name = "comboBoxEditGroupRole";
            this.comboBoxEditGroupRole.Size = new System.Drawing.Size(116, 21);
            this.comboBoxEditGroupRole.TabIndex = 17;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDeleteUser);
            this.groupBoxDelete.Controls.Add(this.label1);
            this.groupBoxDelete.Controls.Add(this.textBoxUserId);
            this.groupBoxDelete.Location = new System.Drawing.Point(173, 183);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(508, 49);
            this.groupBoxDelete.TabIndex = 4;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Удалить";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Enabled = false;
            this.buttonDeleteUser.Location = new System.Drawing.Point(370, 16);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(114, 24);
            this.buttonDeleteUser.TabIndex = 23;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Enabled = false;
            this.textBoxUserId.Location = new System.Drawing.Point(35, 19);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(308, 20);
            this.textBoxUserId.TabIndex = 0;
            // 
            // buttonUpdateUserList
            // 
            this.buttonUpdateUserList.Location = new System.Drawing.Point(92, 183);
            this.buttonUpdateUserList.Name = "buttonUpdateUserList";
            this.buttonUpdateUserList.Size = new System.Drawing.Size(75, 49);
            this.buttonUpdateUserList.TabIndex = 0;
            this.buttonUpdateUserList.Text = "Обновить";
            this.buttonUpdateUserList.UseVisualStyleBackColor = true;
            this.buttonUpdateUserList.Click += new System.EventHandler(this.buttonUpdateUserList_Click);
            // 
            // checkedListBoxOperationAdmin
            // 
            this.checkedListBoxOperationAdmin.CheckOnClick = true;
            this.checkedListBoxOperationAdmin.FormattingEnabled = true;
            this.checkedListBoxOperationAdmin.Items.AddRange(new object[] {
            "Добавить",
            "Удалить",
            "Изменить"});
            this.checkedListBoxOperationAdmin.Location = new System.Drawing.Point(8, 183);
            this.checkedListBoxOperationAdmin.Name = "checkedListBoxOperationAdmin";
            this.checkedListBoxOperationAdmin.Size = new System.Drawing.Size(78, 49);
            this.checkedListBoxOperationAdmin.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(170, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 6;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 431);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.checkedListBoxOperationAdmin);
            this.Controls.Add(this.buttonUpdateUserList);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.listViewUserList);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(709, 469);
            this.MaximumSize = new System.Drawing.Size(709, 469);
            this.MinimumSize = new System.Drawing.Size(709, 469);
            this.Name = "Admin";
            this.Text = "Инженер администратор: <admin> <FIO>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewUserList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonUpdateUserList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAddPatronymic;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.Label labelAddSurname;
        private System.Windows.Forms.Label labelAddPassword;
        private System.Windows.Forms.Label labelAddLogin;
        private System.Windows.Forms.ComboBox comboBoxAddGroupRole;
        private System.Windows.Forms.TextBox textBoxAddSurname;
        private System.Windows.Forms.TextBox textBoxAddPatronymic;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxAddPassword;
        private System.Windows.Forms.TextBox textBoxAddLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelEditLogin;
        private System.Windows.Forms.Label labelEditPatronymic;
        private System.Windows.Forms.TextBox textBoxEditLogin;
        private System.Windows.Forms.Label labelEditName;
        private System.Windows.Forms.TextBox textBoxEditPassword;
        private System.Windows.Forms.Label labelEditSurname;
        private System.Windows.Forms.TextBox textBoxEditName;
        private System.Windows.Forms.Label labelEditPassword;
        private System.Windows.Forms.TextBox textBoxEditPartonymic;
        private System.Windows.Forms.TextBox textBoxEditSurname;
        private System.Windows.Forms.ComboBox comboBoxEditGroupRole;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.CheckedListBox checkedListBoxOperationAdmin;
        private System.Windows.Forms.Label label14;
    }
}