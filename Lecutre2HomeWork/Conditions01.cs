using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Conditions01
    {
        public static void Main16()
        {
            while (true)
            {
                Console.Write("\n Input first integer: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.Write("\n Input second integer: ");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        if (a < 0 && b > 0)
                        {
                            Console.WriteLine("\n Check if one is negative and one is positive: True");
                        }
                        if (a > 0 && b < 0)
                        {
                            Console.WriteLine("\n Check if one is negative and one is positive: True");
                        }
                        else
                        {
                            Console.WriteLine("\n Check if one is negative and one is positive: False");
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