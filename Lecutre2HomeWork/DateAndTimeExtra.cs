using System;
using System.Collections.Generic;
using System.Text;
using Microsoft;
using System.Linq;
using Lecture2HomeWork;
using System.Globalization;

namespace Lecture2HomeWork
{
    class DateAndTime07
    {
        public static void TimeAndDate07()
        {
            while (true)
            {
                Console.WriteLine("date1");
                string EnteredData = Console.ReadLine();
                Console.WriteLine("date2");
                string EnteredData2 = Console.ReadLine();
                var dateTime = DateTime.ParseExact(EnteredData, "dd MM yyyy", CultureInfo.InvariantCulture);
                var dateTime2 = DateTime.ParseExact(EnteredData2, "dd MM yyyy", CultureInfo.InvariantCulture);
                if (dateTime > dateTime2)
                {
                    Console.WriteLine($"{dateTime}  is later than {dateTime2}");
                }
                else if (dateTime < dateTime2)
                    {
                    Console.WriteLine($"{dateTime}  is before than {dateTime2}");
                     
                    }
                else
                {
                    Console.WriteLine($"{dateTime}  is the same time as {dateTime2}");
                }
            }
        }
    }
}