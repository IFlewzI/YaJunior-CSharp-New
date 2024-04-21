using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__1._7
{
    class Program
    {
        static void Main()
        {
            int minutesNumberInHour = 60;
            int timeToServeOnePatientInMinutes = 10;

            int quantityOfPatients;
            int timeToServeAllPatientsInMinutes;
            int hoursToServeAllPatients;
            int extraMinutesToServeAllPatients;

            Console.Write("Сколько пациентов в очереди? \nПоле для ввода: ");
            quantityOfPatients = GetInt(0);
            timeToServeAllPatientsInMinutes = quantityOfPatients * timeToServeOnePatientInMinutes;
            hoursToServeAllPatients = timeToServeAllPatientsInMinutes / minutesNumberInHour;
            extraMinutesToServeAllPatients = timeToServeAllPatientsInMinutes % minutesNumberInHour;

            Console.WriteLine($"\nВ очереди стоит {quantityOfPatients} людей, так что вся очередь займёт {hoursToServeAllPatients} часов {extraMinutesToServeAllPatients} минут");
        }

        static int GetInt(int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int numberForReturning;
            string userInput;
            bool isSuccess;

            userInput = Console.ReadLine();
            isSuccess = int.TryParse(userInput, out numberForReturning) && minValue <= numberForReturning && numberForReturning <= maxValue;

            while (!isSuccess)
            {
                Console.Write("\nОшибка ввода. Попробуйте ещё раз. \nПоле для ввода: ");
                userInput = Console.ReadLine();
                isSuccess = int.TryParse(userInput, out numberForReturning) && minValue <= numberForReturning && numberForReturning <= maxValue;
            }

            return numberForReturning;
        }
    }
}
