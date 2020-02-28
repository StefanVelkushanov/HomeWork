using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Math2
    {
        public static void Main2()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter r: ");

                if (int.TryParse(Console.ReadLine(), out int r))
                {
                        Console.WriteLine($"The result is: {Math.PI * (Math.Pow(r ,2))}");
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