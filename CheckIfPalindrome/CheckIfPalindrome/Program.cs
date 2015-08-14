using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /* *********** DESIGN NOTES*************

                **Notes about Palindromes**
                Palindromes are WORDS or PHRASES that read the same in both direction
                Word example:  Eye
                Phrase example:  Do geese see God?

                **Initial design**
                Get String (Do geese see God?)
                Strip special chars (Do geese see God)
                Strip spaces (DogeeseseeGod)
                ToLower (dogeeseseegod)
                Store ToLowererd as string1
                Reverse string1 and store as string2
                Compare string 1 to string 2 by length and value?

               *********** DESIGN NOTES*************  */

            //Hello and get string
            Console.WriteLine("Hello, I'm a robot.  Bleep Bloop.  My job is to tell you if what you write is a Palindrome or not!");
            Console.WriteLine("Please write something for my to analyze.");
            string input = Console.ReadLine();
            string strippedInput = StripSpecialCharsAndSpaces(input); //TODO: can I clean this up with a StringBuilder object?
            //StringBuilder modifiedInput = new StringBuilder();
            //modifiedInput.Append(StripSpecialCharsAndSpaces(input));
            string reversedInput = ReverseString(strippedInput.ToLower());
            Console.WriteLine(reversedInput);

        }

        private static string StripSpecialCharsAndSpaces(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private static string ReverseString(string modifiedInputToLower)
        {
            char[] charArray = modifiedInputToLower.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }
    }
}
