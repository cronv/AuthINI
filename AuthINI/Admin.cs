using System;
using System.Windows.Forms;

namespace AuthINI
{
    public partial class Admin : Forms
    {
        /// <summary>
        /// ID пользователя, выбранной строки в списке
        /// </summary>
        private int ListViewUserId = 0;

        private ListViewItem ListUsersViewItem = new ListViewItem();

        /// <summary>
        /// Конструктор Admin
        /// </summary>
        public Admin()
        {
            this.InitializeComponent();

            // Анализатор функций
            this.checkedListBoxOperationAdmin.ItemCheck += checkedList;
            this.checkedListBoxOperationAdmin.SelectedIndexChanged += checkeds;

            // Проверка пароля
            this.textBoxAddPassword.TextChanged += passp;
            this.textBoxEditPassword.TextChanged += passp;
        }

        /// <summary>
        /// Загрузка списка данными пользователей при первичной загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_Load(object sender, EventArgs e)
        {
            this.updateLV();
        }

        /// <summary>
        /// Обновление списка пользователей
        /// </summary>
        private void updateLV()
        {
            if (this.listViewUserList.Items != null)
                this.listViewUserList.Items.Clear();

            for (int i = 1; i < Auth.RegistryLength(); i++)
            {
                if (this.File.GetPrivateString(i.ToString(), "id") != "")
                {
                    this.ListUsersViewItem = new ListViewItem(new string[] { i.ToString(), this.Auth.GroupNameID(this.Auth.GetAccessValue(this.Auth.GetIDStringValue(i, "login"))), this.Auth.GetIDStringValue(i, "login"), this.Auth.GetIDStringValue(i, "password"), this.Auth.GetIDStringValue(i, "Family"), this.Auth.GetIDStringValue(i, "Name"), this.Auth.GetIDStringValue(i, "Patronymic") }, i);
                    this.listViewUserList.Items.Add(ListUsersViewItem);
                }
            }
        }

        /// <summary>
        /// События выделения для определения вектора выбора в checkedLisBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedList(object sender, ItemCheckEventArgs e)
        {
            // Изменение свойств, в зависимости от выбранной нами функции
            if (e.NewValue == CheckState.Checked)
            {
                foreach (int index in (sender as CheckedListBox).CheckedIndices)
                {
                    if (index != e.Index)
                    {
                        (sender as CheckedListBox).SetItemChecked(index, false);
                    }
                }
            }
        }

        /// <summary>
        /// Модель поведения формы администратора при переключении функций
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkeds(object sender, EventArgs e)
        {
            if (this.checkedListBoxOperationAdmin.GetItemChecked(0) == true)
            {
                this.EditPanel(true, false, false);
            }
            else if (this.checkedListBoxOperationAdmin.GetItemChecked(1) == true)
            {
                this.EditPanel(false, true, false);
            }
            else if (this.checkedListBoxOperationAdmin.GetItemChecked(2) == true)
            {
                this.EditPanel(false, false, true);
            }
            else
                this.EditPanel(false, false, false);
        }

        /// <summary>
        /// Событие при закрытии формы администратора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

            Forms.getInstanceAdmin().Hide();
            Forms.getInstanceMain().Show();

            GC.Collect(); // Очищаем мусор
        }

        /// <summary>
        /// Установка данных в интерфейс администратора
        /// </summary>
        /// <param name="login"></param>
        public void profile(String login)
        {
            this.Login = login;
            this.Text = "Инженер администратор: <" + login + "> <" + this.Auth.GetStringValue(login, "Family") + " " + this.Auth.GetStringValue(login, "Name") + " " + this.Auth.GetStringValue(login, "Patronymic") + ">";
        }

        /// <summary>
        /// Проверка сложности пароля и вывод индикатора в пользовательский интерфейс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void passp(object sender, EventArgs e)
        {
            if (this.textBoxAddPassword.Enabled.Equals(true))
            {
                if (this.textBoxAddPassword.Text != "")
                {
                    this.Auth.CheckSample(this.textBoxAddPassword.Text, Forms.getInstanceMain().PatternPassword, out this.Message, out this.ColorMessage, out this.IsAuth);
                    this.label14.Text = this.Message + "\n";
                    this.label14.ForeColor = this.ColorMessage;
                }
            }

            if (this.textBoxEditPassword.Enabled.Equals(true))
            {
                if (this.textBoxEditPassword.Text != "")
                {
                    this.Auth.CheckSample(this.textBoxEditPassword.Text, Forms.getInstanceMain().PatternPassword, out this.Message, out this.ColorMessage, out this.IsAuth);
                    this.label14.Text = this.Message + "\n";
                    this.label14.ForeColor = this.ColorMessage;
                }
            }
        }

        /// <summary>
        /// Функция для изменения свойства Enabled функциональных панелей.
        /// </summary>
        /// <param name="add"></param>
        /// <param name="delete"></param>
        /// <param name="edit"></param>
        private void EditPanel(bool add, bool delete, bool edit)
        {
            // Добавление
            this.textBoxAddLogin.Enabled = add;
            this.textBoxAddPassword.Enabled = add;
            this.textBoxAddName.Enabled = add;
            this.textBoxAddPatronymic.Enabled = add;
            this.textBoxAddSurname.Enabled = add;
            this.comboBoxAddGroupRole.Enabled = add;
            this.buttonAddUser.Enabled = add;

            // Удаление
            this.textBoxUserId.Enabled = delete;
            this.buttonDeleteUser.Enabled = delete;

            // Изменение
            this.textBoxEditSurname.Enabled = edit;
            this.textBoxEditPartonymic.Enabled = edit;
            this.textBoxEditName.Enabled = edit;
            this.textBoxEditPassword.Enabled = edit;
            this.textBoxEditLogin.Enabled = edit;
            this.comboBoxEditGroupRole.Enabled = edit;
            this.buttonEditUser.Enabled = edit;

            GC.Collect(); // Очищаем мусор
        }

        /// <summary>
        /// Событие клика по кнопке Обновления листа пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateUserList_Click(object sender, EventArgs e)
        {
            this.updateLV();
        }

        /// <summary>
        /// Событие клика по строке листа, заполняющая поля ID-пользователем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewUserList_Click(object sender, EventArgs e)
        {
            if (this.checkedListBoxOperationAdmin.GetItemChecked(1) == true)
            {
                this.textBoxUserId.Text = this.listViewUserList.Items[listViewUserList.FocusedItem.Index].SubItems[0].Text;
            }
            else if (this.checkedListBoxOperationAdmin.GetItemChecked(2) == true)
            {
                // Изменение
                this.ListViewUserId = Convert.ToInt32(this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[0].Text);
                this.textBoxEditLogin.Text = this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[2].Text;
                this.textBoxEditPassword.Text = this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[3].Text;
                this.textBoxEditSurname.Text = this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[4].Text;
                this.textBoxEditName.Text = this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[5].Text;
                this.textBoxEditPartonymic.Text = this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[6].Text;
                this.Access = this.Auth.GroupNameIDInt(this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[1].Text);

                if (this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[2].Text == this.Login)
                {
                    this.comboBoxEditGroupRole.SelectedIndex = this.Access;
                    this.comboBoxEditGroupRole.Enabled = false;
                }
                else
                    this.comboBoxEditGroupRole.SelectedIndex = this.Access;
            }

            if (this.listViewUserList.SelectedItems.Count != 0)
            {
                this.ListViewUserId = Int32.Parse(this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[0].Text);
            }
        }

        /// <summary>
        /// Событие клика по кнопке Удаления пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (this.textBoxUserId.Equals(""))
            {
                MessageBox.Show("Поле ID пустое!");
            }
            else
            {
                if (this.Auth.DeleteUser(this.textBoxUserId.Text))
                {
                    MessageBox.Show("Пользовател с ID:" + this.textBoxUserId.Text + " успешно удалён!");
                }
                else
                {
                    MessageBox.Show("Пользователя с ID:" + this.textBoxUserId.Text + " не существует!");
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (this.textBoxAddLogin.Text.Equals(""))
            {
                MessageBox.Show("Поле <Логин> пустое\n");
            }
            else if (this.textBoxAddPassword.Text.Equals(""))
            {
                MessageBox.Show("Поле <Пароль> пустое\n");
            }
            else if (this.textBoxAddSurname.Text.Equals(""))
            {
                MessageBox.Show("Поле <Фамилия> пустое\n");
            }
            else if (this.textBoxAddName.Text.Equals(""))
            {
                MessageBox.Show("Поле <Имя> пустое\n");
            }
            else if (this.textBoxAddPatronymic.Text.Equals(""))
            {
                MessageBox.Show("Поле <Отчество> пустое\n");
            }
            else if (this.comboBoxAddGroupRole.Text.Equals(""))
            {
                MessageBox.Show("<Права> пользователя не выбраны!\n");
            }
            else
            {
                // Add
                if (this.IsAuth)
                {
                    if (this.Auth.FindLogin(this.textBoxAddLogin.Text))
                    {
                        bool aa = Auth.AddUser(this.textBoxAddLogin.Text, this.textBoxAddPassword.Text, this.textBoxAddSurname.Text, this.textBoxAddName.Text, this.textBoxAddPatronymic.Text, this.comboBoxAddGroupRole.SelectedIndex);
                        MessageBox.Show("Пользователь <" + this.textBoxAddLogin.Text + "> успешно создан!" + aa.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Логин <" + this.textBoxAddLogin.Text + "> уже существует в базе данных!");
                    }
                }
            }
            this.updateLV();
        }

        /// <summary>
        /// Событие клика по кнопке Изменения пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (this.textBoxEditLogin.Text.Equals(""))
            {
                MessageBox.Show("Поле <Логин> пустое.");
            }
            else if (this.textBoxEditPassword.Text.Equals(""))
            {
                MessageBox.Show("Поле <Пароль> пустое.");
            }
            else if (this.textBoxEditSurname.Text.Equals(""))
            {
                MessageBox.Show("Поле <Фамилия> пустое.");
            }
            else if (this.textBoxEditName.Text.Equals(""))
            {
                MessageBox.Show("Поле <Имя> пустое.");
            }
            else if (this.textBoxEditPartonymic.Text.Equals(""))
            {
                MessageBox.Show("Поле <Отчество> пустое.");
            }
            else
            {
                if (this.IsAuth)
                {
                    if (this.ListViewUserId != 0) // Если выбран элемент, то true
                    {
                        if (!this.Auth.FindLogin(listViewUserList.Items[listViewUserList.FocusedItem.Index].SubItems[2].Text))
                        {
                            this.Auth.EditUser(this.ListViewUserId, this.textBoxEditLogin.Text, this.textBoxEditPassword.Text, this.textBoxEditSurname.Text, this.textBoxEditName.Text, this.textBoxEditPartonymic.Text, this.Access);
                            MessageBox.Show("Пользователь с ID:" + this.ListViewUserId + " <" + this.textBoxEditLogin.Text + "> успешно измёнен!");
                        }
                        else
                        {
                            MessageBox.Show("Логин <" + this.listViewUserList.Items[this.listViewUserList.FocusedItem.Index].SubItems[2].Text + "> не существует в базе данных!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь из списка не выбран!");
                    }

                    if (!this.comboBoxEditGroupRole.Enabled)
                        this.comboBoxEditGroupRole.Enabled = true;
                    this.updateLV(); // Обновляем listView1
                    this.ListViewUserId = 0;
                }
            }
        }
    }
}
