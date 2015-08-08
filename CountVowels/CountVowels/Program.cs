using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.  I am a robot.  Bleep bloop.\nMy job is to count the vowels in what you type!\nType something for me!");
            string userInput = Console.ReadLine();
            countTheVowels(userInput);
            //reportTheVowels(userInput);
            /* 
             * 1) Split string into array by CHAR
             * 2) Loop through array and count IF char is a vowel
             * 3) Repeat 2 but store counts for each type of vowel for reporting
            */
        }

        private static void countTheVowels(string userInput)
        {
            int countOfVowels = 0;
            int countofA = 0;
            int countofE = 0;
            int countofI = 0;
            int countofO = 0;
            int countofU = 0;

            char[] splitInputTest = userInput.ToCharArray();
            foreach (char c in splitInputTest)
            {
                char.ToLower(c);

                switch (c)
                {
                    case 'a':
                        countOfVowels += 1;
                        countofA += 1;
                        break;
                    case 'e':
                        countOfVowels += 1;
                        countofE += 1;
                        break;
                    case 'i':
                        countOfVowels += 1;
                        countofI += 1;
                        break;
                    case 'o':
                        countOfVowels += 1;
                        countofO += 1;
                        break;
                    case 'u':
                        countOfVowels += 1;
                        countofU += 1;
                        break;
                }

            }
        }
    }
}
