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
            const string PrintCurrentDateCommand = "1";
            const string PrintCurrentTimeCommand = "2";
            const string PrintRandomIntNumberCommand = "3";
            const string HelpCommand = "help";
            const string ClearCommand = "clear";
            const string ExitCommand = "exit";

            Random random = new Random();
            bool isProgramRunning = true;
            string userInput;

            while (isProgramRunning)
            {
                Console.Write($"Введите команду ({HelpCommand}, чтобы увидеть список команд) \nПоле для ввода: ");
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
                        $"\nВывести актуальную дату - {PrintCurrentDateCommand}" +
                        $"\nВывести актуальное время - {PrintCurrentTimeCommand}" +
                        $"\nВывести случайное значение типа данных int - {PrintRandomIntNumberCommand}" +
                        $"\nВывести список всех команд - {HelpCommand}" +
                        $"\nОчистить консоль - {ClearCommand}" +
                        $"\nЗавершить работу программы - {ExitCommand}");
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
