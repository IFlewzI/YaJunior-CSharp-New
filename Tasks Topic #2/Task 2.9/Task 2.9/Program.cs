using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._9
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int minDivider = 10;
            int maxDivider = 25;
            int divider = random.Next(minDivider, maxDivider + 1);

            int minValidMultipleNumber = 50;
            int maxValidMultipleNumber = 150;
            int quantityOfValidMultipleNumbers = 0;

            for (int i = divider; i <= maxValidMultipleNumber; i += divider)
            {
                if (i >= minValidMultipleNumber)
                    quantityOfValidMultipleNumbers++;
            }

            Console.WriteLine($"В диапозоне от {minValidMultipleNumber} до {maxValidMultipleNumber} (включительно) существует {quantityOfValidMultipleNumbers} чисел, кратных {N}");
        }
    }
}
