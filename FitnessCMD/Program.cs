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

   

            UserController userCon = new UserController(tempName);
            Console.WriteLine(userCon.CurrentUserPole);
            Console.ReadLine();
        }
    }
}
