using System;
using System.Collections.Generic;
using System.Text;
using Lecture2HomeWork;

namespace Lecture2HomeWork
{
    public class DateAndTime06
    {
        public static void TimeAndDate06()
        {
            DateTime CurrentTime = DateTime.FromFileTimeUtc(132277496706019063);

            Console.WriteLine(CurrentTime);
        }
    }
}