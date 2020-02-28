using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Calculations05
    {
        public static void raMain(string[] args)
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