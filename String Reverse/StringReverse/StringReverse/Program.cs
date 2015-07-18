using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //A clunky manual way to reverse a string!
            Console.WriteLine("Hello.  I am a robot.  Bleep bloop.\nMy job is to reverse stuff that you type!\nType something for me!");
            
            string nonReversedString = Console.ReadLine();
            Console.WriteLine("Got it.  I will reverse this for you: " + nonReversedString);
            string reversedString = getReversedString(nonReversedString);

            Console.WriteLine("\nThat was easy: " + reversedString);
            Console.ReadLine();
        }

        private static string getReversedString(string nonReversedString)
        {
            string reversedString = string.Empty;
            int nonReversedStringsIndexOfLastChar = nonReversedString.Length - 1;

            for (int i = 0; i < nonReversedString.Length; i++)
            {
                reversedString += nonReversedString.Substring(nonReversedStringsIndexOfLastChar - i, 1);
            }

            return reversedString;
        }
    }
}
