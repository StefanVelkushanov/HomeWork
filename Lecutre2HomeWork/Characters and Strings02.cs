using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class CharactersAndStrings02
    {
        public static void CharAndString02()
        {
            while (true)
            {
                Console.Write("\n Please enter a word : ");
                var a = Console.ReadLine();

                var FirstLetter = a.Substring(0, 1);
                var added = FirstLetter + a + FirstLetter;
               
                Console.WriteLine(added);
            }
        }
    }
}