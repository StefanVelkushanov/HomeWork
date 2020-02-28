using System;

namespace Lecture2HomeWork
{
    class Calculations01
    {
        public static void Calc01()
        {
            double a = -1 + 4 * 6;


            double ba = 35;
            double bb = 5;
            double bc = 7;
            double b = (ba + bb) % bc;



            double c = 14 + -4 * 6 / (double)11;





            double d = 2 + 15 / 6.00 * 1 - 7 % 2;




            Console.WriteLine();
            Console.WriteLine($"First calculation: -1 + 4 * 6 = {a}");
            Console.WriteLine();
            Console.WriteLine($"Second calculation: (35 + 5) % 7 = {b:F2}");
            Console.WriteLine();
            Console.WriteLine($"Third calculation: 14 + -4 * 6 / 11 = {c:F2}");
            Console.WriteLine();
            Console.WriteLine($"Fourth calculation: 2 + 15 / 6 * 1 - 7 % 2 = {d}");
        }
    }
}
