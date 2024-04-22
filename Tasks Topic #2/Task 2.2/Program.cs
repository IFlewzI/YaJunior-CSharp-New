using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Program
    {
        static void Main()
        {
            const string ExitPhrase = "exit";

            string userInput;
            bool isCycleRunning = true;

            while (isCycleRunning)
            {
                Console.Write("-Купи слона \n-");
                userInput = Console.ReadLine();

                isCycleRunning = userInput.ToLower() != ExitPhrase.ToLower();
            }
        }
    }
}
