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
            while (true)
            {
                Console.Write($"\n Enter number: ");
                double enteredNumber = double.Parse(Console.ReadLine());

                if (enteredNumber > 0)
                {
                    double sum = 0;
                    Console.Write($"\n Odd numbers:");
                    for (int i = 1; i <= enteredNumber; i += 2)
                    {
                        Console.Write($" {i}");
                        sum += i;
                    }
                    Console.WriteLine($"\n The sum of them is: {sum}");
                }
                else
                {
                    Console.WriteLine("\n Please enter positive number.");
                }
            }
        }
    }
}