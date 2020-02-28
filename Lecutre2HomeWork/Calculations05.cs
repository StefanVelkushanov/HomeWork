using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class Calculations05
    {
        public static void Calc05()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write(" Enter the amount of celsius: ");

                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    double Kelvin = a + 273.15;
                    double Fahrenheit = a * (double)2 + 30;

                    Console.WriteLine($"\n Kelvin = {Kelvin} \n Fahrenheit = {Fahrenheit}");
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