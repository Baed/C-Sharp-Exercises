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
            reportTheVowels(userInput, countOfVowels, countofA, countofE, countofI, countofO, countofU);
        }

        private static void reportTheVowels(string userInput, int countOfVowels, int countofA, int countofE, int countofI, int countofO, int countofU)
        {
            Console.WriteLine("\nYou entered the following string: " + userInput);
            Console.WriteLine("The total number of vowels are: " + countOfVowels);
            Console.WriteLine("Here's a report of the sum of each vowel found: \nA = {0}\nE = {1}\nI = {2}\nO = {3}\nU = {4}", countofA, countofE, countofI, countofO, countofU);
            Console.ReadLine();
        }
    }
}
