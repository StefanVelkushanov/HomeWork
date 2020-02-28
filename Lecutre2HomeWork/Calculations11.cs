using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Calculations11
    {
        public static void hhhMain(string[] args)
        {
            while (true)
            {
                Console.Write("\n Input the value for Y coordinate: ");

                if (int.TryParse(Console.ReadLine(), out int y))
                {
                    Console.Write("\n Input the value for X coordinate: ");
                    if (int.TryParse(Console.ReadLine(), out int x))
                    {
                        if (x+y > 0)
                        {
                            Console.WriteLine($"\n The coordinate point ({x},{y}) lies in the First quadrant.");
                        }
                        if (x < 0 && y > 0)
                        {
                            Console.WriteLine($"\n The coordinate point ({x},{y}) lies in the Second quadrant.");
                        }
                        if (x < 0 && y < 0)
                        {
                            Console.WriteLine($"\n The coordinate point ({x},{y}) lies in the Thurth quadrant.");
                        }
                        if (x > 0 && y < 0)
                        {
                            Console.WriteLine($"\n The coordinate point ({x},{y}) lies in the Fourth quadrant.");
                        }
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