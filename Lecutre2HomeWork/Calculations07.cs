using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Calculations07
    {
        public static void Main11()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Input a first number(<100): ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.Write("Input a second number(>200): ");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        if (a < 100 && b > 200)
                        {
                            Console.WriteLine("\n True");
                        }
                        else
                        {
                            Console.WriteLine("\n False");
                        }
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