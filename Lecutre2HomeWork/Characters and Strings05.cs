using System;
using System.Collections.Generic;
using System.Text;
using Microsoft;
using System.Linq;

namespace Lecture2HomeWork
{
    class CharactersAndStrings05
    {
        public static char CharAndString05()
        {
            while (true)
            {

                Console.Write("\n Input a char: ");

                char EnteredString;
                bool isFound = false;

                if (char.TryParse(Console.ReadLine(), out EnteredString))
                {
                    if (char.IsDigit(EnteredString))
                    {
                        Console.WriteLine("\n The entered char is digit.");
                    }
                    if (char.IsLetter(EnteredString))
                    {
                        char[] compare = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

                        for (int i = 0; i < compare.Length; i++)
                        {
                            if (EnteredString == compare[i])
                            {
                                isFound = true;
                                break;
                            }
                        }
                        if (isFound)
                        {
                            Console.WriteLine("Your char is vowel.");
                        }
                        if (isFound == false)
                        {
                            Console.WriteLine("Your char is letter.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your char is other.");
                    }
                }
                else
                {
                    Console.WriteLine("\n Please enter valid char.");
                }
            }
        }
    }
}