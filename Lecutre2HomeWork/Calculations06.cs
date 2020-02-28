using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class Calculations06
    {
        public static void Calc06()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write(" Input first integer: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    if (a > 0)
                    {
                        if (a % 3 == 0 || a % 7 == 0)
                        {
                            Console.WriteLine("\n True");
                        }
                        else
                        {
                            Console.WriteLine("\n False");
                        }
                    }
                    else
                    {

                        Console.WriteLine("\n Please enter a positive number.");
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