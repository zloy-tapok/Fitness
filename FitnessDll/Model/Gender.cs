using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDll.Model
{   /// <summary>
/// Пол юзера
/// </summary>
   [Serializable]
   public class Gender
    {   /// <summary>
    /// Название
    /// </summary>
        public string Name { get; }
        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Имя пола</param>
        public Gender(string name)
        {
            if(String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Ошибка ввода именя пола", nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
