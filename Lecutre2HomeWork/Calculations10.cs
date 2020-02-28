using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Calculations10
    {
        public static void Main14()
        {
            while (true)
            {
                Console.Write("\n  Enter the amount of Radius: ");

                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    double surface = (double)4 * Math.PI * Math.Pow(a, 2);
                    double volume = (double)4 / 3 * Math.PI * Math.Pow(a, 3);

                    Console.WriteLine($"\n Surface = {surface} \n Volume = {volume}");
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