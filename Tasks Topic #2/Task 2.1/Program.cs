using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1
{
    class Program
    {
        static void Main()
        {
            string userInput;
            bool isSuccess;

            string message;
            uint quantityOfCicles;

            Console.Write("Введите сообщение. \nПоле для ввода: ");
            message = Console.ReadLine();

            do
            {
                Console.Write("\nСколько раз следует вывести это сообщение? \nПоле для ввода: ");
                userInput = Console.ReadLine();
                isSuccess = uint.TryParse(userInput, out quantityOfCicles);
            } while (isSuccess == false);

            Console.WriteLine();

            for (int i = 0; i < quantityOfCicles; i++)
                Console.WriteLine(message);
        }
    }
}
