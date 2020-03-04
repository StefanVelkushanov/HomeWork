using System;
using System.Collections.Generic;
using System.Text;
using Lecture3HomeWork;

namespace Lecture3HomeWork
{
    public class Loops03
    {
        public static void Loop03()
        {
            double sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter number {i}");
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine($" \n The sum of the numbers is: {sum} \n The Averige is: {sum /10}");
        }
    }
}