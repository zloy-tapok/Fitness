using FitnessDll.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDll.Controller
{/// <summary>
/// Контроллер пользователя.
/// </summary>
     public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        User UserPole { get; }
        /// <summary>
        /// Создание нового контроллера пользователя
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName, string genderName, DateTime birthdayName, double weightName, double heightName)
        {
            Gender gender = new Gender(genderName);
            UserPole = new User(userName, gender, birthdayName, weightName, heightName);
           
        }
        public UserController()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("users.dat", FileMode.Open))
            {

                if (formatter.Deserialize(fs) is User user)
                {
                    UserPole = user;
                }
            }
        }
        /// <summary>
        /// Сохраниеть юзера.
        /// </summary>
        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, UserPole);
            }
        }
        /// <summary>
        /// Загрузить юзера.
        /// </summary>
        /// <returns>Юзер приложения.</returns>
        //public UserController()
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    using(FileStream fs = new FileStream("users.dat", FileMode.Open))
        //    {

        //        if (formatter.Deserialize(fs) is User user)
        //        {
        //            UserPole = user;
        //        }
        //    }
        //}
    }
}
