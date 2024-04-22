using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._4
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int minRandomNumber = 0;
            int maxRandomNumber = 100;
            int randomNumber = random.Next(minRandomNumber, maxRandomNumber + 1);

            int sum = 0;

            for (int i = randomNumber; i > 0; i--)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                    sum += i;
            }

            Console.WriteLine(randomNumber + " | " + sum);
        }
    }
}
