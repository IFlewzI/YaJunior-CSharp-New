using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._10
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int startNumber = 2;
            int targetNumber = random.Next(0, 1000);
            int degree = 0;
            int numberInPower = 1;

            while (numberInPower <= targetNumber)
            {
                degree++;
                numberInPower *= startNumber;
            }

            Console.WriteLine($"Число {numberInPower} больше {targetNumber} и является числом {startNumber} в степени {degree}");
        }
    }
}
