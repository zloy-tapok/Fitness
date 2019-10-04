using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDll.Model
{/// <summary>
/// Пользователь.
/// </summary>
    [Serializable]
    public class User
    #region Свойства.
    {   /// <summary>
        /// Имя.
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// День Рождения.
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - BirthDay.Year; }
        }
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
            if (weight <= 0)
            {
                throw new ArgumentException("Вес слишком мал", nameof(weight));
            }
            if(height <= 0)
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
        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Пустое имя блэт", nameof(name));
            }
            else
            {
                Name = name;
            }
        }
        public override string ToString()
        {
            return Name + Age;
        }
    }
    
}
