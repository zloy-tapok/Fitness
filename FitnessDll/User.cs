using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDll
{/// <summary>
/// Пользователь.
/// </summary>
    class User
    #region Свойства.
    {   /// <summary>
        /// Имя.
        /// 
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// День Рождения.
        /// </summary>
        public DateTime BirthDay { get; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name"> Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthday">День Рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="height">Рост</param>
        public User(string name, 
                    Gender gender, 
                    DateTime birthday, 
                    double weight, 
                    double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не введено", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не введен", nameof(gender));
            }
            if(birthday < DateTime.Parse("1.1.1950") || birthday >= DateTime.Now)
            {
                throw new ArgumentException("Невозможно родиться тогда", nameof(birthday));
            }
            if (weight <= 30)
            {
                throw new ArgumentException("Вес слишком мал", nameof(weight));
            }
            if(height <= 50)
            {
                throw new ArgumentException("Рост слишком мал блэт", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDay = birthday;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    
}
