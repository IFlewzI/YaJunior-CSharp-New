using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._5
{
    class Program
    {
        static void Main()
        {
            const string PrintCurrentDateCommand = "print current date";
            const string PrintCurrentTimeCommand = "print current time";
            const string PrintRandomIntNumberCommand = "print random int number";
            const string HelpCommand = "help";
            const string ClearCommand = "clear";
            const string ExitCommand = "exit";

            Random random = new Random();
            bool isProgramRunning = true;
            string userInput;

            while (isProgramRunning)
            {
                Console.Write("Введите команду (help, чтобы увидеть список команд) \nПоле для ввода: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == PrintCurrentDateCommand.ToLower())
                {
                    DateTime now = DateTime.Now;
                    Console.WriteLine($"\n{now.Day}.{now.Month}.{now.Year}");
                }
                else if (userInput.ToLower() == PrintCurrentTimeCommand.ToLower())
                {
                    TimeSpan currentTime = DateTime.Now.TimeOfDay;
                    Console.WriteLine($"\n{currentTime.Hours}:{currentTime.Minutes}:{currentTime.Seconds}");
                }
                else if (userInput.ToLower() == PrintRandomIntNumberCommand.ToLower())
                {
                    Console.WriteLine("\n" + random.Next(int.MinValue, int.MaxValue));
                }
                else if (userInput.ToLower() == HelpCommand.ToLower())
                {
                    Console.WriteLine("\nСписок команд: " +
                        $"\n1) Вывести актуальную дату - {PrintCurrentDateCommand}" +
                        $"\n2) Вывести актуальное время - {PrintCurrentTimeCommand}" +
                        $"\n3) Вывести случайное значение типа данных int - {PrintRandomIntNumberCommand}" +
                        $"\n4) Вывести список всех команд - {HelpCommand}" +
                        $"\n5) Очистить консоль - {ClearCommand}" +
                        $"\n6) Завершить работу программы - {ExitCommand}");
                }
                else if (userInput.ToLower() == ClearCommand.ToLower())
                {
                    Console.Clear();
                }
                else if (userInput.ToLower() == ExitCommand.ToLower())
                {
                    isProgramRunning = false;
                }
                else
                {
                    Console.WriteLine("\nКоманда не была распознана");
                }

                if (userInput.ToLower() != ClearCommand.ToLower())
                    Console.WriteLine();
            }
        }
    }
}
