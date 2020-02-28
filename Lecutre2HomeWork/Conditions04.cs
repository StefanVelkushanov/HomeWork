using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class Conditions04
    {
        public static void Cond04()
        {
            while (true)
            {
                Console.Write("\n Input first integer: ");

                if (double.TryParse(Console.ReadLine(), out double a))
                {
                        if (a >= 80 && a <= 120 || a >= 180 && a <= 220)
                        {
                            Console.WriteLine($"\n True");
                        }
                        else
                        {
                            Console.WriteLine("\n False");
                        }
                }
                else
                {
                    Console.WriteLine("\n Please enter valid number.");
                }
            }
        }
    }
}