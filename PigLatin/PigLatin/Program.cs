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
            Console.WriteLine("Hello.  I am a robot.  Bleep bloop.\nMy job is to convert stuff that you type to Pig Latin!\nType something for me!");
            string userInput = Console.ReadLine();
            string userPigLatin = ConvertToPigLatin(userInput);
            DisplayOutput(userPigLatin);
            //TODO: implement mechanism that handles special characters and numbers
        }

        private static string ConvertToPigLatin(string userInput)
        {
            string[] userInputArray = userInput.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string userPigLatin = string.Empty;

            foreach (string word in userInputArray)
            {
                string firstLetter = word.Substring(0,1).ToLower();

                //distinguishes between vowel and consonant to satisfy the pig latin rules
                if (firstLetter == "a" || firstLetter == "e" || firstLetter == "i" || firstLetter == "o" || firstLetter == "u")
                {
                    userPigLatin += word + "yay ";
                }
                else if (firstLetter == "b" || firstLetter == "c" || firstLetter == "d" || firstLetter == "f"
                     || firstLetter == "g" || firstLetter == "h" || firstLetter == "j" || firstLetter == "k"
                     || firstLetter == "l" || firstLetter == "m" || firstLetter == "n" || firstLetter == "p"
                     || firstLetter == "q" || firstLetter == "r" || firstLetter == "s" || firstLetter == "t"
                     || firstLetter == "v" || firstLetter == "w" || firstLetter == "x" || firstLetter == "y"
                     || firstLetter == "z") //TODO: revise this later...kind of messy
                {
                    string wordWithRemovedConsonant = word.Substring(1, word.Length - 1);
                    userPigLatin += wordWithRemovedConsonant + firstLetter + "ay ";
                }
            }

            return userPigLatin;
        }

        private static void DisplayOutput(string userPigLatin)
        {
            Console.WriteLine(userPigLatin);
            Console.ReadLine();
        }
    }
}

