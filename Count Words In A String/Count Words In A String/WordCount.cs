using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Count_Words_In_A_String
{
    class WordCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.  I am a robot.  Bleep bloop.\nMy job is to count the number of words for you!");

            bool retry = true;
            while (retry == true)
            {
                string input = GetUserInput();
                string strippedInput = StripNumbersAndSpecialChars(input);
                ReportWordCount(strippedInput);
            }

        }

        private static string GetUserInput()
        {
            Console.WriteLine("\nType 'file' to see me read from a text file, or type anything in the console for me to read.  Type 'exit' to quit the application.");
            string input = Console.ReadLine();

            if (input.ToLower().Trim() == "file")
            {
                //Opens text file, stores every line in array, and loops and stores every array element to a string
                string fileLocation = "../../Assets/Text.txt";
                StreamReader reader = new StreamReader(fileLocation);
                string[] allLinesOfTextFile = File.ReadAllLines(fileLocation);
                string textFileContents = "";
                for (int i = 0; i < allLinesOfTextFile.Length; i++)
                {
                    textFileContents += allLinesOfTextFile[i] + " ";
                }

                return textFileContents;
            }
            else if (input.ToLower().Trim() == "exit")
            {
                Environment.Exit(0);
                return input;
            }
            else
            {
                return input;
            }
        }

        private static string StripNumbersAndSpecialChars(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (Char.IsLetter(c) || Char.IsSeparator(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private static void ReportWordCount(string input)
        {
            //Report doesn't count numbers or special chars as words due to logic in StripNumbersAndSpecialChars methods
            string[] words = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Number of words you typed are: {0}", words.Length);
        }
    }
}
