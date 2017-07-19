using INIFile;
using System.Drawing;
using System.Windows.Forms;

namespace AuthINI
{
    public class Forms : Form
    {
        /// <summary>
        /// Логин авторизованного пользователя
        /// </summary>
        protected string Login;

        /// <summary>
        /// Сообщение проверки данных
        /// </summary>
        protected string Message;

        /// <summary>
        /// Роль пользователя
        /// </summary>
        protected int Access = 0;

        /// <summary>
        /// Цвет сообщения
        /// </summary>
        protected Color ColorMessage;

        /// <summary>
        /// Разрешение регистрации
        /// </summary>
        protected bool IsAuth;

        /// <summary>
        /// Флажок сохранения пароля во время авторизации
        /// </summary>
        protected IniAuth Auth = IniAuth.getInstance();

        /// <summary>
        /// Библиотека для работы с INI-файлами
        /// </summary>
        protected INIUpr File = new INIUpr(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\file.ini");
        
        /// <summary>
        /// Полный путь к файлу хранения пользователей
        /// </summary>
        protected string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\file.ini";

        /// <summary>
        /// Доступ к объекту формы Main
        /// </summary>
        protected static Main InstanceMain;

        /// <summary>
        /// Доступ к объекту формы Registration только для чтения
        /// </summary>
        private static readonly Registration InstanceRegistration = new Registration();

        /// <summary>
        /// Доступ к объекту формы Profile только для чтения
        /// </summary>
        protected static readonly Profile InstanceProfile = new Profile();

        /// <summary>
        /// Доступ к объекту формы Admin только для чтения
        /// </summary>
        protected static readonly Admin InstanceAdmin = new Admin();

        /// <summary>
        /// Возвращает объект класса Main
        /// </summary>
        /// <returns>Profile</returns>
        public static Main getInstanceMain()
        {
            return Forms.InstanceMain;
        }

        /// <summary>
        /// Возвращает объект класса Registration
        /// </summary>
        /// <returns>Profile</returns>
        public static Registration getInstance()
        {
            return Registration.InstanceRegistration;
        }

        /// <summary>
        /// Возвращает объект класса Profile
        /// </summary>
        /// <returns>Profile</returns>
        public static Profile getInstanceProfile()
        {
            return Profile.InstanceProfile;
        }

        /// <summary>
        /// Возвращает объект класса
        /// </summary>
        /// <returns>Profile</returns>
        public static Admin getInstanceAdmin()
        {
            return Forms.InstanceAdmin;
        }
    }
}
