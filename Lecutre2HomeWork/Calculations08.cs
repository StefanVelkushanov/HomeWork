using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class Calculations08
    {
        public static void Calc08()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("\n Input first integer: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.Write("\n Input second integer: ");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.Write("\n Input third integer: ");
                        if (int.TryParse(Console.ReadLine(), out int c))
                        {
                            int Max = Math.Max((Math.Max(a, b)), c);
                            int Min = Math.Min((Math.Min(a, b)), c);

                            if (Min == Max)
                            {
                                Console.WriteLine($"\n The lowest and the largest are {Min}");
                            }
                            else
                            {
                                Console.WriteLine($"\n The largest is: {Max}");
                                Console.WriteLine($"\n The lowest is: {Min}");
                            }

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