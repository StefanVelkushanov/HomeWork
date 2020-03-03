using System;
using System.Collections.Generic;
using System.Text;
using Lecture2HomeWork;

namespace Lecture2HomeWork
{
    public class DateAndTime01
    {
        public static int TimeAndDate01()
        {
            while (true)
            {

                Console.Write("\n Please enter year: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    if (DateTime.IsLeapYear(a))
                    {
                        Console.WriteLine($"\n {a} is leap year.");
                    }
                    else
                    {
                        Console.WriteLine($"\n {a} is not leap year.");
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter valid year.");
                }
            }
        }
    }
}