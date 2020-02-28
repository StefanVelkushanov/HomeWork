using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Math4
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter h: ");

                if (double.TryParse(Console.ReadLine(), out double h))
                {
                    Console.Write("Please enter b: ");
                    if (double.TryParse(Console.ReadLine(), out double b))
                    {
                        Console.WriteLine($"The result is: {h * (b / 2)}");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter valid number.");
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