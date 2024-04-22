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
            const int MinutesNumberInHour = 60;
            const int TimeToServeOnePatientInMinutes = 10;

            string userInput;
            bool isSuccess;

            uint quantityOfPatients;
            int timeToServeAllPatientsInMinutes;
            int hoursToServeAllPatients;
            int extraMinutesToServeAllPatients;

            do
            {
                Console.Write("Сколько пациентов в очереди? \nПоле для ввода: ");
                userInput = Console.ReadLine();
                isSuccess = uint.TryParse(userInput, out quantityOfPatients);
            } while (isSuccess == false);

            timeToServeAllPatientsInMinutes = (int)quantityOfPatients * TimeToServeOnePatientInMinutes;
            hoursToServeAllPatients = timeToServeAllPatientsInMinutes / MinutesNumberInHour;
            extraMinutesToServeAllPatients = timeToServeAllPatientsInMinutes % MinutesNumberInHour;

            Console.WriteLine($"\nВ очереди стоит {quantityOfPatients} людей, так что вся очередь займёт {hoursToServeAllPatients} часов {extraMinutesToServeAllPatients} минут");
        }
    }
}
