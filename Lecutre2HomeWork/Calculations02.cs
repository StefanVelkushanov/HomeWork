using System;

namespace Lecture2HomeWork
{
    class Calculations02
    {
        public static void Calc02()
        {
            int FirstNumber = 5;
            int SecondNumber = 6;
            int temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = temp;

            Console.WriteLine();
            Console.WriteLine($" First Number: {FirstNumber} \n \n Second Number: {SecondNumber}");
        }
    }
}
