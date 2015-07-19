using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.  I am a robot.  Bleep bloop.\nMy job is to convert stuff that you type in to Pig Latin!\nType something for me!");
            string userInput;
            string userPigLatin;

            userInput = GetUserInput();
            userPigLatin = ConvertToPigLatin(userInput);
            DisplayOutput(userPigLatin);
        }

        private static string GetUserInput()
        {
            string userInput = Console.ReadLine();
            
            return userInput;
        }

        private static string ConvertToPigLatin(string userInput)
        {
            string userPigLatin = string.Empty;
            return userPigLatin;
        }

        private static void DisplayOutput(string userPigLatin)
        {
            Console.WriteLine(userPigLatin);
            Console.ReadLine();
        }
    }
}

/*  Rough design
Assumptions
 1) Intended for individual words without punctuation, numbers, or special characters
 2) Only for converting TO pig latin, not converting from pig latin to english

GetUserInput
  • ReadLine from user
  • Return string

ConvertToPigLatin
  • If begins with consonant, move first char to end of string and add 'ay' at the end of string
  • Else if begins with vowel add 'yay' to end of string
  • Else do nothing

DisplayOutput
  • Writeline of the output
*/

