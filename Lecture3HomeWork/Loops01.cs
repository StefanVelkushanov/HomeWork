using System;
using System.Collections.Generic;
using System.Text;
using Lecture3HomeWork;

namespace Lecture3HomeWork
{
    public class Loops01
    {
        public static void Loop01()
        {
            Console.WriteLine("Enter number");
            var number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
               sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}