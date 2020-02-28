using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Calculations04
    {
        public static void Main8()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter the first number: ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine();
                    Console.Write("Enter the second number: ");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.WriteLine();
                        Console.Write("Enter the third number: ");
                        if (int.TryParse(Console.ReadLine(), out int c))
                        {
                            Console.WriteLine();
                            Console.Write("Enter the four number: ");
                            if (int.TryParse(Console.ReadLine(), out int d))
                            {
                                Console.WriteLine();
                                Console.WriteLine($"The average of 10, 15, 20, 30 is: {(a+b+c+d) / 4}");
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