using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__1._3
{
    class Program
    {
        static void Main()
        {
            string userInput;
            bool isSuccess;

            string userFirstName;
            string userSecondName;
            uint userAge;
            string userFavouriteVideogame;
            uint userRandomNumber;

            Console.Write("Введите ваше имя. \nПоле для ввода: ");
            userFirstName = Console.ReadLine();

            Console.Write("\nВведите вашу фамилию. \nПоле для ввода: ");
            userSecondName = Console.ReadLine();

            do
            {
                Console.Write("\nВведите ваш возраст. \nПоле для ввода: ");
                userInput = Console.ReadLine();
                isSuccess = uint.TryParse(userInput, out userAge);
            } while (isSuccess == false);

            Console.Write("\nКакая у вас любимая видеоигра? \nПоле для ввода: ");
            userFavouriteVideogame = Console.ReadLine();

            do
            {
                Console.Write("\nА назовёте первое пришедшее в голову неотрицательное число? \nПоле для ввода: ");
                userInput = Console.ReadLine();
                isSuccess = uint.TryParse(userInput, out userRandomNumber);
            } while (isSuccess == false);

            Console.WriteLine($"\nПодводя итог: \nВас зовут {userSecondName} {userFirstName}, вам {userAge} лет. \nВаша любимая игра - это \"{userFavouriteVideogame}\", а ещё вы молодец {userRandomNumber} раз :)");
            Console.ReadKey();
        }
    }
}
