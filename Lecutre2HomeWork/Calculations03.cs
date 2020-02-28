using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class Calculations03
    {
        public static void Calc03()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter a: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.Write("Please enter b: ");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.Write("Please enter c: ");
                        if (int.TryParse(Console.ReadLine(), out int c))
                        {
                            Console.WriteLine($"The result is: {a * b * c}");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter valid number.");
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