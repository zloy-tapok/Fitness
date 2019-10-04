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
        public List<User> UsersPole { get; }
        public User CurrentUserPole { get; }
        public bool IsNewUser { get; } = false;

        /// <summary>
        /// Создание нового контроллера пользователя
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("Пустое имя для списка", nameof(userName));
            }
            UsersPole = LoadUserData();
            CurrentUserPole = UsersPole.SingleOrDefault(u => u.Name == userName);
            if(CurrentUserPole == null)
            {
                CurrentUserPole = new User(userName);
                UsersPole.Add(CurrentUserPole);
                IsNewUser = true;
                Save();
            }

        
           
        }
        private List<User> LoadUserData()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("users.dat", FileMode.Open))
            {
                if (formatter.Deserialize(fs) is List<User> users)
                {
                    return users;
                }
                else
                {
                    return new List<User>();
                }
            }
        }
        public void SetNewUserData(string genderName, DateTime birthDayName, double weightName = 1, double heigtName = 1)
        {
            CurrentUserPole.Gender = new Gender(genderName);
            CurrentUserPole.BirthDay = birthDayName;
            CurrentUserPole.Weight = weightName;
            CurrentUserPole.Height = heigtName;
            Save();
        }
        /// <summary>
        /// Сохраниеть юзера.
        /// </summary>
        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, UsersPole);
            }
        }
   
    }
}
