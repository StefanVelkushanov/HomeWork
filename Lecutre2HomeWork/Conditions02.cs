using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Conditions02
    {
        public static void Main17()
        {
            while (true)
            {
                Console.Write("\n Input first integer: ");

                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.Write("\n Input second integer: ");
                    if (double.TryParse(Console.ReadLine(), out double b))
                    {
                        a = Math.Abs(a);
                        b = Math.Abs(b);
                        a = Math.Abs(a - b);

                            Console.WriteLine($"\n The absolute value of the difference between the numbers is : {a}");
                        }
                        else
                        {
                            Console.WriteLine("\n Please enter valid value.");
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