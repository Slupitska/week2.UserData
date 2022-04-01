using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести его год рождения
            //приложение вычисляет возраст пользователя (2022 - год рождения пользователя)
            //если пользователь моложе 18-ти лет, то в консоли выводится "Too young to drive"
            //если пользователь сташе 18-ти лет, то в консоли выводится "Drive carefully"
            //если пользователь 18 лет, то в консоли выводится "Congratulations, you may apply
            //to your driving license now"
            
            //int result = 2022 - Convert.ToInt32(Console.ReadLine()) - лаконичнее,
            //без int YearOfBirth;

            Console.WriteLine("Please enter your year of birth:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            
            int result = 2022 - YearOfBirth;

            if (result < 18) 
            {
                Console.WriteLine("Too young to drive.");
            }
            else if (result > 18)
            {
                Console.WriteLine("Drive carefully!");
            }
            else
            {
                Console.WriteLine("Congratulations, you may apply to your driving license now.");
            }
        }
    }
}
