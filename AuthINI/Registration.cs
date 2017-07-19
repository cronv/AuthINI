using System;
using System.Drawing;
using System.Windows.Forms;

using INIFile;

namespace AuthINI
{
    public partial class Registration : Forms
    {
        /// <summary>
        /// ID Пользователя
        /// </summary>
        private int TokenId;

        /// <summary>
        /// Конструктор Registration
        /// </summary>
        public Registration()
        {
            this.InitializeComponent();
            this.textBoxPassword.TextChanged += pass;
            this.textBoxPassword2.TextChanged += pass;
            this.Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\file.ini";
            this.File = new INIUpr(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\file.ini");
        }

        /// <summary>
        /// Проверка сложности пароля и вывод индикатора в пользовательский интерфейс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pass(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "")
            {
                this.Auth.CheckSample(textBoxPassword.Text, Main.getInstanceMain().PatternPassword, out this.Message, out this.ColorMessage, out this.IsAuth);
                this.labelErrorText.Text = this.Message + "\n";
                this.labelErrorText.ForeColor = this.ColorMessage;
            }
        }

        /// <summary>
        /// Событие клика по кнопке Регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Проверка
            if (textBoxLogin.Text.Equals(""))
            {
                this.labelErrorText.Text = "Поле <Логин> пустое\n";
                this.labelErrorText.ForeColor = Color.Red;
            }
            else if (textBoxPassword.Text.Equals(""))
            {
                this.labelErrorText.Text = "Поле <Пароль> пустое\n";
                this.labelErrorText.ForeColor = Color.Red;
            }
            else if (!textBoxPassword.Text.Equals(textBoxPassword2.Text))
            {
                this.labelErrorText.Text = "Пароли не совпадают!\n";
                this.labelErrorText.ForeColor = Color.Red;
            }
            else if (textBoxSurname.Text.Equals(""))
            {
                this.labelErrorText.Text = "Поле <Фамилия> пустое\n";
                this.labelErrorText.ForeColor = Color.Red;
            }
            else if (textBoxName.Text.Equals(""))
            {
                this.labelErrorText.Text = "Поле <Имя> пустое\n";
                this.labelErrorText.ForeColor = Color.Red;
            }
            else if (textBoxPatronymic.Text.Equals(""))
            {
                this.labelErrorText.Text = "Поле <Отчество> пустое\n";
                this.labelErrorText.ForeColor = Color.Red;
            }
            else
            {
                if (this.IsAuth) // Разрешение от шаблона Regulars (Проверки пароля)
                {
                    // Логин
                    if (System.IO.File.Exists(this.Path) && this.File.GetPrivateString(IniAuth.INISystemSectionName, "count") != "") // Если файл пути существует
                    {
                        this.TokenId = this.Auth.RegistryLength(); // Извлекаем из записи значение, переводим его в int

                        if (this.Auth.FindLogin(textBoxLogin.Text))
                        {
                            if (this.TokenId > 1)
                            {
                                // Создание пользователя
                                this.File.WritePrivateString(this.TokenId.ToString(), "id", this.TokenId.ToString());
                                this.File.WritePrivateString(this.TokenId.ToString(), "access", "0");
                                this.File.WritePrivateString(this.TokenId.ToString(), "login", this.textBoxLogin.Text);
                                this.File.WritePrivateString(this.TokenId.ToString(), "password", this.textBoxPassword2.Text);
                                this.File.WritePrivateString(this.TokenId.ToString(), "Family", this.textBoxSurname.Text);
                                this.File.WritePrivateString(this.TokenId.ToString(), "Name", this.textBoxName.Text);
                                this.File.WritePrivateString(this.TokenId.ToString(), "Patronymic", this.textBoxPatronymic.Text);
                            }
                            else
                            {
                                // Первый всегда админ
                                this.File.WritePrivateString(this.TokenId.ToString(), "id", this.TokenId.ToString());
                                this.File.WritePrivateString(this.TokenId.ToString(), "access", "1");
                                this.File.WritePrivateString(this.TokenId.ToString(), "login", this.textBoxLogin.Text);
                                this.File.WritePrivateString(this.TokenId.ToString(), "password", this.textBoxPassword2.Text);
                                this.File.WritePrivateString(this.TokenId.ToString(), "Family", this.textBoxSurname.Text);
                                this.File.WritePrivateString(this.TokenId.ToString(), "Name", this.textBoxName.Text);
                                this.File.WritePrivateString(this.TokenId.ToString(), "Patronymic", this.textBoxPatronymic.Text);
                            }

                            MessageBox.Show("Учётная запись <" + this.textBoxLogin.Text + "> успешно создана!\nID: " + this.TokenId.ToString());
                            this.TokenId++;
                            this.File.WritePrivateString(IniAuth.INISystemSectionName, "count", this.TokenId.ToString()); // Закрываем запись счётчика для индексации псевдо-БД
                        }
                        else
                        {
                            this.labelErrorText.Text = "Логин <" + this.textBoxLogin.Text + "> уже существует!\n";
                            this.labelErrorText.ForeColor = Color.Gold;
                        }
                    }
                    else // В противном случае создаём БД
                    {
                        this.labelErrorText.Text = Color.Red + "БД не существовало!\nМы создали её за вас!\nДля продолжения нажмите ещё раз.";
                        this.labelErrorText.ForeColor = Color.Orange;
                        this.File.WritePrivateString(IniAuth.INISystemSectionName, "count", "0");
                        this.File.WritePrivateString(IniAuth.INISystemSectionName, "SavePass", "False");
                    }
                }
            }
        }

        /// <summary>
        /// Событие клика по кнопке закрытия Windows Forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            GC.Collect(); // Освобождаем мусор
            this.Close();
        }
    }
}
