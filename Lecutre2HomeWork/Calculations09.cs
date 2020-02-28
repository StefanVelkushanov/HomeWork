using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class Calculations09
    {
        public static void Calc09()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("\n  Please enter year: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    if (a <= 0)
                    {
                        Console.WriteLine("\n  Please enter valid year.");
                    }
                    else
                    {
                        int cent = a / 100;
                        a %= 100;

                        if (a > 0)
                        {
                            cent = cent + 1;
                        }
                        Console.WriteLine($"\n This year is in {cent} century");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter valid number.");
                }
            }
        }
    }
}