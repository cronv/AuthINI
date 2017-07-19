using System;
using System.Windows.Forms;

namespace AuthINI
{
    public partial class Profile : Forms
    {
        /// <summary>
        /// Конструктор Profile
        /// </summary>
        public Profile()
        {
            this.InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Устанавливает значения в интерфейсе профиля пользователя
        /// </summary>
        /// <param name="Login"></param>
        public void setProfile(string Login)
        {
            this.Login = Login;
            this.labelSurname.Text = "Фамилия: " + this.Auth.GetStringValue(this.Login, "Family");
            this.labelName.Text = "Имя: " + this.Auth.GetStringValue(this.Login, "Name");
            this.labelPatronymic.Text = "Отчество: " + this.Auth.GetStringValue(this.Login, "Patronymic");
            this.labelLogin.Text = "Логин: " + this.Login;
            this.labelGroup.Text = "Группа: " + this.Auth.GroupNameID(this.Auth.GetAccessValue(this.Login));
        }

        /// <summary>
        /// Событие закрытия формы профиля обычного пользователя приводит к открытию Главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

            Profile.getInstanceProfile().Hide();
            Main.getInstanceMain().Show();

            GC.Collect(); // Очищаем мусор
        }
    }
}
