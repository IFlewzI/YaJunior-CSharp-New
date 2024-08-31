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
            int minN = 10;
            int maxN = 25;
            int N = random.Next(minN, maxN + 1);

            int minValidMultipleNumber = 50;
            int maxValidMultipleNumber = 150;
            int quantityOfValidMultipleNumbers = 0;

            for (int i = N; i <= maxValidMultipleNumber; i += N)
            {
                if (i >= minValidMultipleNumber)
                    quantityOfValidMultipleNumbers++;
            }

            Console.WriteLine($"В диапозоне от {minValidMultipleNumber} до {maxValidMultipleNumber} (включительно) существует {quantityOfValidMultipleNumbers} чисел, кратных {N}");
        }
    }
}
