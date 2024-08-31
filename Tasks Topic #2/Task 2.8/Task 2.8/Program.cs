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
            int attemptsLeft = attemptsQuantity;
            bool isPasswordCorrect = false;

            while (attemptsLeft > 0 && isPasswordCorrect == false)
            {
                Console.Write("Введите пароль. Поле для ввода: ");
                userInput = Console.ReadLine();
                attemptsLeft--;

                isPasswordCorrect = userInput == password;

                if (isPasswordCorrect == false && attemptsLeft > 0)
                    Console.WriteLine("Пароль недействителен, попробуйте ещё раз.\n");
            }

            if (isPasswordCorrect)
                Console.WriteLine("\nI agree.");
            else
                Console.WriteLine("\nDont you know what culture is?");
        }
    }
}
