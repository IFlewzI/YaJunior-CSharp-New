using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._6
{
    class Program
    {
        static void Main()
        {
            const string ConvertRubToUsdCommand = "rub to usd";
            const string ConvertRubToEurCommand = "rub to eur";
            const string ConvertUsdToRubCommand = "usd to rub";
            const string ConvertUsdToEurCommand = "usd to eur";
            const string ConvertEurToRubCommand = "eur to rub";
            const string ConvertEurToUsdCommand = "eur to usd";
            const string ShowBalanceCommand = "balance";
            const string ClearCommand = "clear";
            const string HelpCommand = "help";
            const string ExitCommand = "exit";

            const float CurrencyMultiplierFromRubToUsd = 0.011f;
            const float CurrencyMultiplierFromRubToEur = 0.01f;
            const float CurrencyMultiplierFromUsdToRub = 92f;
            const float CurrencyMultiplierFromUsdToEur = 0.93f;
            const float CurrencyMultiplierFromEurToRub = 98f;
            const float CurrencyMultiplierFromEurToUsd = 1.07f;

            float rubBalance = 1000f;
            float usdBalance = 10f;
            float eurBalance = 10f;

            bool isProgramRunning = true;
            string userInput;
            bool isSuccess;
            float valueToConvert = 0;

            while (isProgramRunning)
            {
                Console.Write("Введите команду (help, чтобы увидеть список команд) \nПоле для ввода: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == ConvertRubToUsdCommand.ToLower()
                    || userInput.ToLower() == ConvertRubToEurCommand.ToLower()
                    || userInput.ToLower() == ConvertUsdToRubCommand.ToLower()
                    || userInput.ToLower() == ConvertUsdToEurCommand.ToLower()
                    || userInput.ToLower() == ConvertEurToRubCommand.ToLower()
                    || userInput.ToLower() == ConvertEurToUsdCommand.ToLower())
                {
                    Console.WriteLine();

                    do
                    {
                        Console.Write("Введите количество валюты, которое вы бы хотели конвертировать: ");
                        isSuccess = float.TryParse(Console.ReadLine(), out valueToConvert) && valueToConvert >= 0;
                    } while (isSuccess == false);
                }

                if (userInput.ToLower() == ConvertRubToUsdCommand.ToLower())
                {
                    if (rubBalance >= valueToConvert)
                    {
                        rubBalance -= valueToConvert;
                        usdBalance += valueToConvert * CurrencyMultiplierFromRubToUsd;
                        Console.WriteLine("\nКонвертация успешно проведена!");
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка! На балансе недостаточно валюты для проведения конвертации");
                    }
                }
                else if (userInput.ToLower() == ConvertRubToEurCommand.ToLower())
                {
                    if (rubBalance >= valueToConvert)
                    {
                        rubBalance -= valueToConvert;
                        eurBalance += valueToConvert * CurrencyMultiplierFromRubToEur;
                        Console.WriteLine("\nКонвертация успешно проведена!");
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка! На балансе недостаточно валюты для проведения конвертации");
                    }
                }
                else if (userInput.ToLower() == ConvertUsdToRubCommand.ToLower())
                {
                    if (usdBalance >= valueToConvert)
                    {
                        usdBalance -= valueToConvert;
                        rubBalance += valueToConvert * CurrencyMultiplierFromUsdToRub;
                        Console.WriteLine("\nКонвертация успешно проведена!");
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка! На балансе недостаточно валюты для проведения конвертации");
                    }
                }
                else if (userInput.ToLower() == ConvertUsdToEurCommand.ToLower())
                {
                    if (usdBalance >= valueToConvert)
                    {
                        usdBalance -= valueToConvert;
                        eurBalance += valueToConvert * CurrencyMultiplierFromUsdToEur;
                        Console.WriteLine("\nКонвертация успешно проведена!");
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка! На балансе недостаточно валюты для проведения конвертации");
                    }
                }
                else if (userInput.ToLower() == ConvertEurToRubCommand.ToLower())
                {
                    if (eurBalance >= valueToConvert)
                    {
                        eurBalance -= valueToConvert;
                        rubBalance += valueToConvert * CurrencyMultiplierFromEurToRub;
                        Console.WriteLine("\nКонвертация успешно проведена!");
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка! На балансе недостаточно валюты для проведения конвертации");
                    }
                }
                else if (userInput.ToLower() == ConvertEurToUsdCommand.ToLower())
                {
                    if (eurBalance >= valueToConvert)
                    {
                        eurBalance -= valueToConvert;
                        usdBalance += valueToConvert * CurrencyMultiplierFromEurToUsd;
                        Console.WriteLine("\nКонвертация успешно проведена!");
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка! На балансе недостаточно валюты для проведения конвертации");
                    }
                }
                else if (userInput.ToLower() == ShowBalanceCommand.ToLower())
                {
                    Console.WriteLine("\nВаш баланс: " +
                        $"\nРубли: \t\t{rubBalance}" +
                        $"\nДоллары: \t{usdBalance}" +
                        $"\nЕвро: \t\t{eurBalance}");
                }
                else if (userInput.ToLower() == ClearCommand.ToLower())
                {
                    Console.Clear();
                }
                else if (userInput.ToLower() == HelpCommand.ToLower())
                {
                    Console.WriteLine("\nСписок команд: " +
                        $"\n1) Конвертировать рубли в доллары - \t{ConvertRubToUsdCommand}" +
                        $"\n2) Конвертировать рубли в евро - \t{ConvertRubToEurCommand}" +
                        $"\n3) Конвертировать доллары в рубли - \t{ConvertUsdToRubCommand}" +
                        $"\n4) Конвертировать доллары в евро - \t{ConvertUsdToEurCommand}" +
                        $"\n5) Конвертировать евро в рубли- \t{ConvertEurToRubCommand}" +
                        $"\n6) Конвертировать евро в доллары - \t{ConvertEurToUsdCommand}" +
                        $"\n7) Баланс - \t\t{ShowBalanceCommand}" +
                        $"\n8) Очистить консоль - \t{ClearCommand}" +
                        $"\n9) Помощь - \t\t{HelpCommand}" +
                        $"\n10) Выход - \t\t{ExitCommand}");
                }
                else if (userInput.ToLower() == ExitCommand.ToLower())
                {
                    isProgramRunning = false;
                }
                else
                {
                    Console.WriteLine("\nКоманда не распознана.");
                }

                if (userInput.ToLower() != ClearCommand.ToLower())
                    Console.WriteLine();
            }
        }
    }
}
