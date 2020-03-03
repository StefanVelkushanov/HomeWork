using System;
using System.Collections.Generic;
using System.Text;
using Lecture2HomeWork;

namespace Lecture2HomeWork
{
    public class DateAndTime05
    {
        public static void TimeAndDate05()
        {
            DateTime CurrentTime = DateTime.Now;
            var future40 = CurrentTime.AddDays(40);
            var date = future40.Date;

            Console.WriteLine($" Today = {date} \n {future40.DayOfWeek}");
        }
    }
}