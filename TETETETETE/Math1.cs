using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Math1
    {
        public static void Main1()
        {
            while (true)
            {
                Console.Write("\n Please enter a: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.Write("\n Please enter b: ");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.WriteLine($"The result is: {Math.Pow (a, 2) + (2 * a * b) + Math.Pow(b, 2)}");
                    }
                    else
                    {
                        Console.WriteLine("\n Please enter valid number.");
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