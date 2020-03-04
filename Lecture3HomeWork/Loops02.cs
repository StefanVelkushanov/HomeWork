using System;
using System.Collections.Generic;
using System.Text;
using Lecture3HomeWork;

namespace Lecture3HomeWork
{
    public class Loops02
    {
        public static void Loop02()
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter number {i}");
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine($" \n The sum of the numbers is: {sum} \n The Averige is: {sum /10}");
            

            //Console.WriteLine("Enter number 1: ");
            //var number1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 2: ");
            //var number2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 3: ");
            //var number3 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 4: ");
            //var number4 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 5: ");
            //var number5 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 6: ");
            //var number6 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 7: ");
            //var number7 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 8: ");
            //var number8 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 9: ");
            //var number9 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 10: ");
            //var number10 = double.Parse(Console.ReadLine());


            //double sum = number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8 + number9 + number10;
            //double average = sum / 10;

            //Console.WriteLine($"\n The sum of 10 no is: {sum} \n The Average is: {average}");
        }
    }
}