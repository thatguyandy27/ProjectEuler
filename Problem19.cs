using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     DateTime min = new DateTime(1901, 1,1);
        //     DateTime max = new DateTime(2000, 12,31);

        //     int count = FindSundaysOnFirstOfMonth(min, max);
        //     Console.Write("The count is {0}",  count);
        //     Console.ReadKey();
        // }

        private static int FindSundaysOnFirstOfMonth(DateTime min, DateTime max)
        {
            int count = 0;

            DateTime currentTime = min;

            while (currentTime < max)
            {
                if (currentTime.DayOfWeek == DayOfWeek.Sunday)
                    count++;
                currentTime = currentTime.AddMonths(1);
            }

            return count;
        }
    }
}
