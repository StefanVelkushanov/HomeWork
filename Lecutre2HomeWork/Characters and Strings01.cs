using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2HomeWork
{
    class CharactersAndStrings01
    {
        public static void CharAndString01()
        {
            while (true)
            {
                Console.Write("\n Please enter a : ");
                var a = Console.ReadLine();

                var FirstLetter = a.Substring(0, 1);
                var LastLetter = a.Substring((a.Length - 1), 1);
                var removeFirstLetter = a.Remove(0, 1);
                var removeLastLetter = removeFirstLetter.Remove((removeFirstLetter.Length - 1), 1);
                var changed = LastLetter + removeLastLetter + FirstLetter;
                Console.WriteLine(changed);
            }
        }
    }
}