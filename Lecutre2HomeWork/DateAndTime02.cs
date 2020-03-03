using System;
using System.Collections.Generic;
using System.Text;
using Lecture2HomeWork;

namespace Lecture2HomeWork
{
    public class DateAndTime02
    {
        public static int TimeAndDate02()
        {
            while (true)
            {

                Console.Write("\n Please enter month: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    int year = 2020;
                    if (a > 0 && a <= 12)
                    {
                        int days = DateTime.DaysInMonth(year, a);
                        Console.WriteLine($"The days in this month are: {days}");
                    }
                    else
                    {
                        Console.WriteLine("\n Please enter valid integer.");
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter valid integer.");
                }
            }
        }
    }
}