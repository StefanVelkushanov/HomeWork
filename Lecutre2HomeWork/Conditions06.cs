using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class Conditions06
    {
        public static void Cond06()
        {
            while (true)
            {
                Console.Write("\n Input first integer: "); 

                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("The day is: Monday");
                            break;
                        case 2:
                            Console.WriteLine("The day is: Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("The day is: Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("The day is: Wednesday");
                            break;
                        case 5:
                            Console.WriteLine("The day is: Friday");
                            break;
                        case 6:
                            Console.WriteLine("The day is: Saturday");
                            break;
                        case 7:
                            Console.WriteLine("The day is: Sunday");
                            break;
                        default:
                            Console.WriteLine("\n Please enter value from 1-7");
                            break;
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