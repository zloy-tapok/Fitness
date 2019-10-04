using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FitnessDll;
using FitnessDll.Model;
using FitnessDll.Controller;
namespace FitnessCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в фитнес приложение");

            Console.WriteLine("Введите имя пользователя");
            string tempName = Console.ReadLine();

            Console.WriteLine("Введите пол");
            string tempGender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            DateTime tempBirthDay = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой вес");
            double tempWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите свой рост");
            double tempHeight = double.Parse(Console.ReadLine());

            UserController userCon = new UserController(tempName, tempGender, tempBirthDay, tempWeight, tempHeight);
            userCon.Save();
        }
    }
}
