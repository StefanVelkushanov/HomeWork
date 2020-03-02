using System;
using System.Collections.Generic;
using System.Text;
using Microsoft;

namespace Lecture2HomeWork
{
    class CharactersAndStrings03
    {
        public static string CharAndString03()
        {
            while (true)
            {
                Console.Write("\n Please enter text : ");
                var EnteredText = Console.ReadLine();
                var TheReversedText = Microsoft.VisualBasic.Strings.StrReverse(EnteredText);
                Console.WriteLine($"\n The reversed text is: {TheReversedText}");
            }
        }
    }
}