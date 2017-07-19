using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AuthINI
{
    public partial class Main : Forms
    {
        /// <summary>
        /// Регулярные выражения для пароля
        /// </summary>
        public readonly string[] PatternPassword = { "[a-z]{1}", "[A-Z]{1}", "[?#@$]{1}" };

        /// <summary>
        /// Название полей в файле сохранения паролей
        /// </summary>
        private readonly string[] JsonInputNames = { "login", "password" };
        
        /// <summary>
        /// Файл сохранения паролей
        /// </summary>
        private readonly string FileNameAuthSaved = "unloading.json";

        /// <summary>
        /// Коллекция хранения значений INIф-файла
        /// </summary>
        public Dictionary<string, string> WriteUn = new Dictionary<string, string>();

        /// <summary>
        /// Временные данные для чтения
        /// </summary>
        private string ReadTmp;

        /// <summary>
        /// Конструктор Main
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
            this.MaximizeBox = false; // Запретить сворачивать/разворачивать окно
            this.Visible = true;
            Main.InstanceMain = this;

            // Добавляем коллекцию ключей, при успешной авторизации значение
            for (int i = 0; i < this.JsonInputNames.Length; i++)
            {
                this.WriteUn.Add(this.JsonInputNames[i], null);
            }
        }

        /// <summary>
        /// Событие по клику кнопки открытия формы Регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Registration.getInstance().ShowDialog();
        }

        /// <summary>
        /// Событие по клику кнопки Авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAuth_Click(object sender, EventArgs e)
        {
            // Проверка
            if (textBoxLogin.Text.Equals(""))
            {
                this.labelErrorText.Text = "Поле <Логин> пустое\n";
                this.labelErrorText.ForeColor = Color.Red;
            }
            else if (textBoxPassword.Equals(""))
            {
                this.labelErrorText.Text = "Поле <Пароль> пустое\n";
                this.labelErrorText.ForeColor = Color.Red;
            }
            else
            {
                if (System.IO.File.Exists(this.Path) && this.File.GetPrivateString(IniAuth.INISystemSectionName, "count") != "") // Если путь существует
                {
                    if (this.Auth.FindGetValue(textBoxLogin.Text, "login")) // Если логин существует, true
                    {
                        if (this.Auth.FindGetValue(textBoxPassword.Text, "password") && textBoxPassword.Text != "") // Если пароль действителен, true
                        {

                            if (this.Auth.GetAccessValue(textBoxLogin.Text) == 0) // Если пустое значение, true
                            {
                                MessageBox.Show("Поздравляем с успешной авторизацией " + textBoxLogin.Text + "!");
                                Profile.getInstanceProfile().Text = "Вы авторизированы: " + textBoxLogin.Text;
                                Profile.getInstanceProfile().Show();
                                Profile.getInstanceProfile().setProfile(textBoxLogin.Text);
                            }
                            else
                            {
                                // Заходим в админ панель
                                MessageBox.Show("Добро пожаловать панель инженеров " + textBoxLogin.Text + "!");
                                Profile.getInstanceProfile().Text = "Инженер администратор: " + textBoxLogin.Text;
                                Admin.getInstanceAdmin().Show();
                                // Application.OpenForms.OfType<Admin>().Single().profile(textBoxLogin.Text);
                                Admin.getInstanceAdmin().profile(textBoxLogin.Text);
                            }

                            this.Visible = false; // Скрываем первую форму авторизации

                            // Добавляем в коллекцию ключей значения
                            this.WriteUn[this.JsonInputNames[0]] = textBoxLogin.Text;
                            this.WriteUn[this.JsonInputNames[1]] = textBoxPassword.Text;


                            if (System.IO.File.Exists(this.FileNameAuthSaved)) // Если файл существует
                            {
                                System.IO.File.Delete(this.FileNameAuthSaved); // Удаляем файл, чтобы избежать конфликта
                                System.IO.File.WriteAllText(this.FileNameAuthSaved, JsonConvert.SerializeObject(this.WriteUn)); // Создаём json файл
                            }
                            else
                            {
                                System.IO.File.WriteAllText(this.FileNameAuthSaved, JsonConvert.SerializeObject(this.WriteUn)); // Создаём json файл
                            }
                        }
                        else // Пароль неправильный, false
                        {
                            this.labelErrorText.ForeColor = Color.Red;
                            if (!textBoxPassword.Text.Equals(""))
                            {
                                this.labelErrorText.Text = "Не правильный пароль!\n";
                            }
                            else
                                this.labelErrorText.Text = "Поле <Пароль> пустое\n";
                        }
                    }
                    else
                    {
                        this.labelErrorText.Text = "Пользователя <" + textBoxLogin.Text + "> не существует!\n";
                        this.labelErrorText.ForeColor = Color.Red;
                    }
                }
                else // Если логин не существует, false
                {
                    this.labelErrorText.Text = Color.Red + "БД не существовало!\nМы создали её за вас!\nДля продолжения нажмите ещё раз.";
                    this.labelErrorText.ForeColor = Color.Orange;
                    this.File.WritePrivateString(IniAuth.INISystemSectionName, "count", "1");
                    this.File.WritePrivateString(IniAuth.INISystemSectionName, "SavePass", "False");
                }
            }
        }

        /// <summary>
        /// Установка флажка сохранения пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            this.Auth.SavePassword(checkBoxRememberMe.Checked);
        }

        /// <summary>
        /// Событие первичной загрузки главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.Path))
            {
                // Если существует параметр "SavePass", то выгружаем его
                if (this.Auth.GetSavePassword())
                    this.checkBoxRememberMe.Checked = this.Auth.GetSavePassword();

                if (this.Auth.GetSavePassword()) // Если значение true SavePass реестра
                {
                    if (System.IO.File.Exists(this.FileNameAuthSaved))
                    {
                        this.ReadTmp = System.IO.File.ReadAllText(this.FileNameAuthSaved);
                        var jObj = JObject.Parse(this.ReadTmp);
                        this.textBoxLogin.Text = (string)jObj["login"];
                        this.textBoxPassword.Text = (string)jObj["password"];
                    }
                }
            }
        }
    }
}
