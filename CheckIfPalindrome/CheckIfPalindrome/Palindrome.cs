using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfPalindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.  I am a robot.  Bleep bloop.\nMy job is to analyze what you write and determine if it's a Palindrome!\nType something for me!");
            
            bool retry = true;
            while (retry == true)
            {
                string input = GetUserInput();
                string strippedInput = StripSpecialCharsAndSpaces(input);
                string reversedInput = ReverseString(strippedInput);
                bool isPalindrome = PalindromeValidation(strippedInput, reversedInput);

                if (isPalindrome == true)
                {
                    Console.WriteLine("Palindrome!  Type something else for me, or type 'exit' to quit.");
                }
                else
                {
                    Console.WriteLine("NOT a Palindrome!  Type something else for me, or type 'exit' to quit.");
                }
            }
        }

        private static string GetUserInput()
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                Environment.Exit(0);
                return input;
            }
            else
            {
                return input;
            }
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
            return sb.ToString().ToLower();
        }

        private static string ReverseString(string modifiedInputToLower)
        {
            char[] charArray = modifiedInputToLower.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }

        private static bool PalindromeValidation(string strippedInput, string reversedInput)
        {
            if (String.IsNullOrEmpty(strippedInput) == true || String.IsNullOrEmpty(reversedInput) == true)
            {
                return false;
            }
            else if (strippedInput == reversedInput)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
