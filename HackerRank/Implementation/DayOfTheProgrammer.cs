using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    public class DayOfTheProgrammer
    {
        public static void ProcessMain()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            year = 1900;

            string result = ProcessDayOfTheProgrammer(year);
            Console.WriteLine(result);
        }

        public static string ProcessDayOfTheProgrammer(int year)
        {
            int total = 0;

            if (year == 1918)
            {
                total -= 13;
            }

            int month = 1;
            for (int i = 1; i <= 12; i++)
            {
                int daysInMonth = DateTime.DaysInMonth(year, i);

                if (i == 2 && year <= 1918)
                {
                    if (year % 4 == 0)
                        daysInMonth = 29;
                    else
                        daysInMonth = 28;
                }

                if (total + daysInMonth > 256)
                    break;

                month++;
                total += daysInMonth;
            }

            var newDay = 256 - total;

            var newDate = new DateTime(year, month, newDay);

            return newDate.ToString("dd.MM.yyyy");
        }
    }
}
