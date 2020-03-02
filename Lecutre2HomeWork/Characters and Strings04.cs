using System;
using System.Collections.Generic;
using System.Text;
using Microsoft;
using System.Linq;

namespace Lecture2HomeWork
{
    class CharactersAndStrings04
    {
        public static string CharAndString04()
        {
            while (true)
            {

                Console.Write("Input a string: ");
                string EnteredString = Console.ReadLine();

                var count = EnteredString.Count(z => z == 'c');
                Console.WriteLine("Test the string contains 'c' character  between 1 and 3 times: ");
                Console.WriteLine(count >= 1 && count <= 3);
            }
        }
    }
}