using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._8
{
    class Program
    {
        static void Main()
        {
            string password = "Just Sayori";
            string userInput;
            int attemptsQuantity = 3;
            bool isPasswordCorrect = false;

            for (int i = 0; i < attemptsQuantity; i++)
            {
                Console.Write("Введите пароль. Поле для ввода: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    isPasswordCorrect = true;
                    break;
                }
                else if (i + 1 < attemptsQuantity)
                {
                    Console.WriteLine("Пароль недействителен, попробуйте ещё раз.\n");
                }
            }

            if (isPasswordCorrect)
                Console.WriteLine("\nI agree.");
            else
                Console.WriteLine("\nDont you know what culture is?");
        }
    }
}
