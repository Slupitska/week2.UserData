using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            // приложение просит пользователя ввести PIN-код.
            // если введенный PIN-код будет 1234, то приложение приветствует пользователя
            //*и спрашивает его имя. А затем приветствует пользователя по имени.
            //в ином случае консоль выводит на экран соообщение об ошибке Invalid PIN.

            Console.WriteLine("Please enter your PIN:");
            string userPIN = Console.ReadLine();

            if (userPIN == "1234")
            {
                Console.WriteLine("Hello! What is your name?");                                                                             
            }
            else
            {
                Console.WriteLine("Oops! Invalid PIN");
            }
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome, dear {userName}!");
        }

    }
}