using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._3
{
    class Program
    {
        static void Main()
        {
            int startNumber = 5;
            int targetNumber = 103;
            int step = 7;

            for (int i = startNumber; i <= targetNumber; i += step) // Цикл for был выбран потому, что точно известны параметры прогрессии, такие как начальное
                Console.Write(i + " ");                             // значение, а также шаг прогрессии, что делает реализацию через цикл for самой оптимальной, ведь именно
                                                                    // прогрессия чисел получается при работе цикла for
        }
    }
}
