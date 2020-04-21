using Fitness.BL.Control;
using System;

namespace Fitness.Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложения Fitness от Власа");
            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

          

            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.Write("Введите ваш пол: ");
                var gender = Console.ReadLine();
                var birthday = ParseDateTime();
                var weight = ParseDouble("Вес");
                var height = ParseDouble("Рост");

                userController.SetNewUserData(gender, birthday, weight, height);

            }
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();
        }

        private static DateTime ParseDateTime()
        {
            DateTime birthday;
            while (true)
            {
                Console.Write("Введите дату рождения (dd.mm.yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthday))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный формат даты.");
                }
            }

            return birthday;
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.Write($"Введите {name}: ");
                if (Double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Неверный формат {name}а:");
                }
            }
        }
    }
}
        
   
