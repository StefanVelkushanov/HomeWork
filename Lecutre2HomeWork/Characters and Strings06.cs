using System;
using System.Collections.Generic;
using System.Text;
namespace Lecture2HomeWork
{
    public class CharactersAndStrings06
    {
        public static int CharAndString06()
        {
            while (true)
            {
                int decVal;
                int val;
                string a = "";
                Console.WriteLine("\n Please enter decimal");
                if (int.TryParse(Console.ReadLine(), out decVal))
                {
                    Console.WriteLine("\n Decimal: {0}", decVal);
                    while (decVal >= 1)
                    {
                        val = decVal / 2;
                        a += (decVal % 2).ToString();
                        decVal = val;
                    }
                    string binValue = "";
                    for (int i = a.Length - 1; i >= 0; i--)
                    {
                        binValue = binValue + a[i];
                    }
                    Console.WriteLine("\n Binary: {0}", binValue);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}