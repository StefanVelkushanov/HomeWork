using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Calculations06
    {
        public static void armain(string[] args)
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