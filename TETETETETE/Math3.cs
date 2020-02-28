using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Math3
    {
        public static void N0TMAIN(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter x: ");

                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    Console.Write("Please enter y: ");
                    if (int.TryParse(Console.ReadLine(), out int y))
                    {
                        Console.WriteLine($"The result is: {Math.Pow(x, y)}");
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