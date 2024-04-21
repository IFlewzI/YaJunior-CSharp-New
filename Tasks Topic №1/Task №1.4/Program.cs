using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__1._4
{
    class Program
    {
        static void Main()
        {
            int imagesTotalQuantity = 52;
            int imagesQuantityForFullRow = 3;
            int fullRowsNumber = imagesTotalQuantity / imagesQuantityForFullRow;
            int imagesLeft = imagesTotalQuantity % imagesQuantityForFullRow;

            Console.WriteLine($"Полных рядов картинок: {fullRowsNumber} \nКартинок осталось вне заполненных рядов: {imagesLeft}");
        }
    }
}
