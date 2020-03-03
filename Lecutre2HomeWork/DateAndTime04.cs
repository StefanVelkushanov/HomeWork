using System;
using System.Collections.Generic;
using System.Text;
using Lecture2HomeWork;

namespace Lecture2HomeWork
{
    public class DateAndTime04
    {
        public static void TimeAndDate04()
        {
            DateTime CurrentTime = DateTime.Now;

            Console.WriteLine(CurrentTime.DayOfWeek);
        }
    }
}