using System;

namespace Aula86SintaxeAlternativaSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day of week: ");
            int dayOfWeek = int.Parse(Console.ReadLine());

            string day;

            switch (dayOfWeek)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine($"Day of Week: {day}");
        }
    }
}
