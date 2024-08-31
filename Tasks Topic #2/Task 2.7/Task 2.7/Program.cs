using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._7
{
    class Program
    {
        static void Main()
        {
            string userInput;
            string userName;
            string nameLine;
            char outlineSymbol;
            string outline = "";

            Console.Write("Введите имя. Поле для ввода: ");
            userName = Console.ReadLine();

            Console.Write("Введите символ. Поле для ввода: ");
            userInput = Console.ReadLine();
            outlineSymbol = userInput[userInput.Length - 1];
            nameLine = $"{outlineSymbol}{userName}{outlineSymbol}";

            for (int i = 0; i < nameLine.Length; i++)
                outline += outlineSymbol;

            Console.WriteLine("\n" + outline);
            Console.WriteLine(nameLine);
            Console.WriteLine(outline);
        }
    }
}
