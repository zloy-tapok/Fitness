using System;

namespace Fitness.BL.Model
{/// <summary>
/// Пользователь.
/// </summary>
    [Serializable]
    public class User
    {
        #region Свойства Пользователя.
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; set;  }
        /// <summary>
        /// Дата рождения.
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
        
        public int Age { get { return DateTime.Now.Year - BirthDay.Year; } }
 #endregion

            /// <summary>
            /// Создать нового пользователя.
            /// </summary>
            /// <param name="name">Имя.</param>
            /// <param name="gender">Пол.</param>
            /// <param name="birthday">Дата рождения.</param>
            /// <param name="weight">Вес.</param>
            /// <param name="height">Рост.</param>
        public User(string name,
                    Gender gender, 
                    DateTime birthday, 
                    double weight, 
                    double height)
        { 
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }

            if(birthday < DateTime.Parse("01.01.1999") & birthday >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения", nameof(birthday));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("Невозможный вес", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentException("Невозможный рост", nameof(weight));
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
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
