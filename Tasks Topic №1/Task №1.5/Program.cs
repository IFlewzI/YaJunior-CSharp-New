using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__1._5
{
    class Program
    {
        static void Main()
        {
            int medicHp = 8;
            int healingValue = 60;
            int boofer;

            Console.WriteLine($"У нас есть медик с {medicHp} очками здоровья, а лечит он на {healingValue} единиц за применение способности");

            boofer = medicHp;
            medicHp = healingValue;
            healingValue = boofer;

            Console.WriteLine($"\nОй! То есть я хотел сказать, что у нас есть медик с {medicHp} очками здоровья, а лечит он на {healingValue} единиц за применение способности");
        }
    }
}
