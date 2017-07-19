using System;
using System.Text.RegularExpressions;
using System.Drawing;

using INIFile;
using System.Windows.Forms;

namespace AuthINI
{
    /// <summary>
    /// Класс для чтения ini-файлов, простой авторизации и проверки полей.
    /// </summary>
    public class IniAuth
    {
        [ThreadStatic]
        private const int IndexMin = 1;

        /// <summary>
        /// Количество совпадений для хорошего пароля
        /// </summary>
        private int PasswordGoodCount = 0;

        /// <summary>
        /// Количество совпадений для надежного пароля
        /// </summary>
        private int PasswordStrongCount = 0;

        /// <summary>
        /// Название системной секции в файле ini
        /// </summary>
        private readonly String SystemSectionName = "SYSTEM";

        /// <summary>
        /// Путь к файлу хранения пользователей
        /// </summary>
        private String Path;

        /// <summary>
        /// Библиотека для работы с INI файлом
        /// </summary>
        private INIUpr File;

        /// <summary>
        /// Название системной секции в INI-файле
        /// </summary>
        public static readonly String INISystemSectionName = "SYSTEM";

        /// <summary>
        /// Доступ к объекту только для чтения
        /// </summary>
        private static readonly IniAuth Instance = new IniAuth();

        /// <summary>
        /// Конструктор RE
        /// </summary>
        private IniAuth()
        {
            this.Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\file.ini";
            this.File = new INIUpr(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\file.ini");
        }

        /// <summary>
        /// Процедура для проверки информации по шаблону регулярных выражений.
        /// </summary>
        /// <param name="InputText"></param>
        /// <param name="RegularPatterns"></param>
        /// <param name="Message"></param>
        /// <param name="c"></param>
        public void CheckSample(String InputText, String[] RegularPatterns, out String Message, out Color c, out bool Token)
        {
            c = Color.Empty;
            Token = false;
            if (InputText.Length >= 6)
            {
                for (int i = 0; i <= RegularPatterns.Length - 1; i++)
                {
                    Regex reg = new Regex(RegularPatterns[i]);

                    if (reg.Matches(InputText).Count > 0 && InputText.Length >= 8)
                        this.PasswordStrongCount++;

                    if (reg.Matches(InputText).Count > 0 && (InputText.Length >= 6 && InputText.Length <= 8))
                        this.PasswordGoodCount++;
                }

                if (this.PasswordStrongCount == RegularPatterns.Length)
                {
                    c = Color.Green;
                    Message = "Пароль надёжный";
                    Token = true;
                }
                else if (this.PasswordGoodCount == RegularPatterns.Length)
                {
                    c = Color.Orange;
                    Message = "Хороший пароль";
                    Token = true;
                }
                else
                {
                    Message = "Плохой пароль";
                    Token = false;
                }
            }
            else
            {
                c = Color.Red;
                Message = "Пароль должен быть из 6 символов";
            }

            this.PasswordStrongCount = this.PasswordGoodCount = 0;
            GC.Collect(); // Собираем ненужный мусор
        }

        /// <summary>
        /// Ищет логин по все разделам базы данных и сравнивает, существует ли он. Работает для регистрации.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool FindLogin(String login)
        {
            bool a = true;

            if (RegistryLength() == 1) // Если бд пустая, то даём разрешение на первую запись
            {
                a = true;
            }

            if (System.IO.File.Exists(this.Path))
            {
                for (int i = IndexMin; i <= RegistryLength(); i++)
                {
                    if (this.File.GetPrivateString(i.ToString(), "id") != "") // Если существует
                    {
                        if (login.Equals(this.File.GetPrivateString(i.ToString(), "login")))
                        {
                            a = false;
                        }
                    }
                }
            }

            GC.Collect(); // Собираем ненужный мусор

            return a;
        }

        /// <summary>
        /// Функция для проверки данных по ключу.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public bool FindGetValue(String Parameter, String Key)
        {
            bool result = false;

            for (int i = IndexMin; i <= RegistryLength(); i++)
            {
                if (this.File.GetPrivateString(i.ToString(), "id") != "") // Если существует
                {
                    if (Parameter.Equals(this.File.GetPrivateString(i.ToString(), Key)))
                    {
                        result = true;
                    }
                }
            }

            GC.Collect(); // Собираем ненужный мусор

            return result;
        }

        /// <summary>
        /// Позволяет изменить параметр ключа "SavePass" на true, false
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public void SavePassword(bool key)
        {
            this.File.WritePrivateString(this.SystemSectionName, "SavePass", key.ToString());

            GC.Collect(); // Собираем ненужный мусор
        }

        /// <summary>
        /// Позволяет получить значение ключа "SavePass"
        /// </summary>
        /// <returns></returns>
        public bool GetSavePassword()
        {
            bool result = false;
            string tmp;
            
            tmp = this.File.GetPrivateString(this.SystemSectionName, "SavePass");

            // C# не дружит с bool реестра
            if (tmp == "False")
                result = false;
            else
                result = true;

            GC.Collect(); // Собираем ненужный мусор

            return result;
        }

        /// <summary>
        /// Позволяет получить ключ привелегии из ini по логину.
        /// </summary>
        /// <returns></returns>
        public int GetAccessValue(string Login)
        {
            int result = 0;

            for (int i = IndexMin; i <= RegistryLength(); i++)
            {
                if (this.File.GetPrivateString(i.ToString(), "id") != "") // Если существует
                {
                    if (Login.Equals(this.File.GetPrivateString(i.ToString(), "login")))
                    {
                        result = Convert.ToInt32(this.File.GetPrivateString(i.ToString(), "access"));
                    }
                }
            }

            GC.Collect(); // Собираем ненужный мусор

            return result;
        }

        /// <summary>
        /// Позволяет получать значения типа String из ini.
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public string GetStringValue(string Login, string Key)
        {
            string result = "";

            for (int i = IndexMin; i <= RegistryLength(); i++)
            {
                if (this.File.GetPrivateString(i.ToString(), "id") != "") // Если существует
                {
                    if (Login.Equals(this.File.GetPrivateString(i.ToString(), "login")))
                    {
                        result = (string)this.File.GetPrivateString(i.ToString(), Key);
                    }
                }
            }

            GC.Collect(); // Собираем ненужный мусор

            return result;
        }

        /// <summary>
        /// Позволяет получать значения типа String из реестра вместе с ID
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Key"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetIDStringValue(int ID, String Key)
        {
            string result = "";

            for (int i = IndexMin; i <= RegistryLength(); i++)
            {
                if (this.File.GetPrivateString(i.ToString(), "id") != "") // Если существует
                {
                    if (ID == i)
                    {
                        result = this.File.GetPrivateString(i.ToString(), Key);
                    }
                }
            }
            GC.Collect(); // Собираем ненужный мусор

            return result;
        }

        /// <summary>
        /// Получает Id записи, по умолчанию возвращает число равное 1
        /// </summary>
        /// <returns></returns>
        public int RegistryLength()
        {
            string tmp = this.File.GetPrivateString(this.SystemSectionName, "count");
            int result = -1;

            if (System.IO.File.Exists(this.Path)) // Если файл существует
                result = Convert.ToInt32(tmp);

            if (result == 0)
                result++;

            return result;
        }

        /// <summary>
        /// Позволяет удалять пользователя из реестра по ID типа string.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteUser(string ID)
        {
            bool result = false;
            for (int i = IndexMin; i <= RegistryLength(); i++)
            {
                if (this.File.GetPrivateString(i.ToString(), "id") != "") // Если существует
                {
                    if (ID.Equals(i.ToString()))
                    {
                        this.File.DeleteSection(this.File.GetPrivateString(i.ToString(), "id"));
                        result = true;
                    }
                }
            }

            GC.Collect(); // Собираем ненужный мусор

            return result;
        }

        /// <summary>
        /// Процедура позволяет изменять пользователя.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="family"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        public bool EditUser(int ID, string login, string password, string family, string name, string patronymic, int group)
        {
            bool result = false;
            string strID = ID.ToString();

            if (!FindLogin(login))
            {
                // Изменение пользователя
                this.File.WritePrivateString(strID, "id", strID);
                this.File.WritePrivateString(strID, "access", group.ToString());
                this.File.WritePrivateString(strID, "login", login);
                this.File.WritePrivateString(strID, "password", password);
                this.File.WritePrivateString(strID, "Family", family);
                this.File.WritePrivateString(strID, "Name", name);
                this.File.WritePrivateString(strID, "Patronymic", patronymic);

                result = true;
            }
            else
            {
                result = false;
            }
            GC.Collect();

            return result;
        }

        /// <summary>
        /// Процедура позволяет создавать пользователя.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="family"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        public bool AddUser(string login, string password, string family, string name, string patronymic, int group)
        {
            bool result = false;
            int ID = RegistryLength();

            if (FindLogin(login))
            {
                // Создание пользователя
                this.File.WritePrivateString(ID.ToString(), "id", ID.ToString());
                this.File.WritePrivateString(ID.ToString(), "access", group.ToString());
                this.File.WritePrivateString(ID.ToString(), "login", login);
                this.File.WritePrivateString(ID.ToString(), "password", password);
                this.File.WritePrivateString(ID.ToString(), "Family", family);
                this.File.WritePrivateString(ID.ToString(), "Name", name);
                this.File.WritePrivateString(ID.ToString(), "Patronymic", patronymic);
                
                ID++;
                this.File.WritePrivateString(this.SystemSectionName, "count", ID.ToString()); // Закрываем запись счётчика для индексации псевдо-БД

                result = true;
            }
            else
            {
                result = false;
            }
            GC.Collect();

            return result;
        }

        /// <summary>
        /// Определяет группу по числу 0 = Пользователи; 1 - Администраторы.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string GroupNameID(int i)
        {
            string result = "null";
            switch(i)
            {
                case 0:
                {
                    result = "Пользователи";
                } break;

                case 1:
                {
                    result = "Администраторы";
                } break;
            }

            GC.Collect(); // Собираем ненужный мусор

            return result;
        }

        /// <summary>
        /// Определяет индекс группы, возвращает int.
        /// </summary>
        /// <param name="GroupName"></param>
        /// <returns></returns>
        public int GroupNameIDInt(string GroupName)
        {
            int result = 0;

            if (GroupName == "Пользователи")
            {
                result = 0;
            }

            if (GroupName == "Администраторы")
            {
                result = 1;
            }

            GC.Collect(); // Собираем ненужный мусор

            return result;
        }
        
        /// <summary>
        /// Возвращает объект класса
        /// </summary>
        /// <returns>RE</returns>
        public static IniAuth getInstance()
        {
            return IniAuth.Instance;
        }
    }
}
