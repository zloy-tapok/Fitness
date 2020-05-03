using Fitness.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Control
{
     public class EatingController : ControllBase
    {
        private const string FOODS_FILE_NAME = "foods.dat";
        private const string EATING_FILE_NAME = "eatings.dat";
        private readonly User user;
        public List<Food> Foods { get; }
        public List<Eating> Eatings { get; }

        public EatingController(User user)
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не может быть пустым", nameof(user));
            Foods = GetAllFoods();
            Eatings = GetAllEatings();
        }

        public void Add(string)
        private List<Food> GetAllFoods()
        {
            return Load<List<Food>>(FOODS_FILE_NAME) ?? new List<Food>();

        }
        private List<Eating> GetAllEatings()
        {
            return Load<List<Eating>>(EATING_FILE_NAME) ?? new List<Eating>();

        }
        private void Save()
        {
            Save(FOODS_FILE_NAME, Foods);
            Save(EATING_FILE_NAME, Eatings);
        }
    }
}
