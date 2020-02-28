using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class Conditions03
    {
        public static void Cond03()
        {
            while (true)
            {
                Console.Write("\n Input first integer: ");

                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.Write("\n Input second integer: ");
                    if (double.TryParse(Console.ReadLine(), out double b))
                    {
                        if (a + b == 20 || a == 20 || b == 20)
                        {
                            Console.WriteLine($"\n True");
                        }
                        else
                        {
                            Console.WriteLine("\n False");
                        }
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