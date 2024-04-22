using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__1._6
{
    class Program
    {
        static void Main()
        {
            int userMoney;
            int userCrystals;
            int crystalPrice = 4;
            int crystalsPossibleToBuy;

            Console.Write("Сколько золота лежит в твоих карманцах, путник? \nПоле для ввода: ");
            userMoney = GetInt(0);
            crystalsPossibleToBuy = userMoney / crystalPrice;

            Console.Write($"\nТак, хорошо один кристалл стоит {crystalPrice} золотых, так что для покупки тебе доступно {crystalsPossibleToBuy} кристаллов. Сколько бы ты хотел купить? \nПоле для ввода: ");
            userCrystals = GetInt(0, crystalsPossibleToBuy);
            userMoney -= userCrystals * crystalPrice;

            Console.WriteLine("\nХорошо, отличная сделка! Хорошего дня)");
            Console.WriteLine($"\nТвой баланс: \nЗолото: {userMoney} \nКристаллы: {userCrystals}");
        }

        static int GetInt(int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int numberForReturning;
            string userInput;
            bool isSuccess;

            userInput = Console.ReadLine();
            isSuccess = int.TryParse(userInput, out numberForReturning) && minValue <= numberForReturning && numberForReturning <= maxValue;

            while (!isSuccess)
            {
                Console.Write("\nОшибка ввода. Попробуйте ещё раз. \nПоле для ввода: ");
                userInput = Console.ReadLine();
                isSuccess = int.TryParse(userInput, out numberForReturning) && minValue <= numberForReturning && numberForReturning <= maxValue;
            }

            return numberForReturning;
        }
    }
}
