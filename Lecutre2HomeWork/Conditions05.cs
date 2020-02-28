using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Conditions05
    {
        public static void ghklMain(string[] args)
        {
            while (true)
            {
                Console.Write("\n Input first integer: ");

                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.Write("\n Input operation: ");
                    var c = Console.ReadLine();

                    Console.Write("\n Input second integer: ");

                    if (c == "+")
                    {
                        if (double.TryParse(Console.ReadLine(), out double b))
                        {
                            Console.WriteLine($"\n {a} + {b} = {a+b}");
                        }
                    }
                    if (c == "-")
                    {
                        if (double.TryParse(Console.ReadLine(), out double b))
                        {
                            Console.WriteLine($"\n {a} - {b} = {a - b}");
                        }
                    }
                    if (c == "/")
                    {
                        if (double.TryParse(Console.ReadLine(), out double b))
                        {
                            Console.WriteLine($"\n {a} / {b} = {a / b}");
                        }
                    }
                    if (c == "*")
                    {
                        if (double.TryParse(Console.ReadLine(), out double b))
                        {
                            Console.WriteLine($"\n {a} * {b} = {a * b}");
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