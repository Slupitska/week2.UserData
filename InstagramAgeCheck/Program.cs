using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение спрашивает у пользователя его возраст
            //если пользователь младше 13-ти лет, то приложение сообщает пользователю,
            //что он еще слишком молод, чтобы иметь аккаунт в Instagram.
            //если пользователю 13 или больше лет, то приложение приветствует его.
            
            Console.WriteLine("Please enter you age:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 13)
            {
                Console.WriteLine("You are too young for Instagram.");
            }
            else if (userAge > 13)
            {
                Console.WriteLine("Welcome to Instagram!");
            }
            else
            {
                Console.WriteLine("Congratulations! You may use Instagram now.");
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}
