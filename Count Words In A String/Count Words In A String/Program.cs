﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words_In_A_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Count Words in a String – Counts the number of individual words in a string. 
             * For added complexity read these strings in from a text file and generate a summary.
             * 
             * Design notes below
             * Get user input by console or text file
             * Split user input into array by space delimiter
             * Count the number of elements in array
            */
            Console.WriteLine("Hello.  I am a robot.  Bleep bloop.\nMy job is to count the number of words for you!");

            bool retry = true;
            while (retry == true)
            {
                string input = GetUserInput();
                ReportWordCount(input);
            }
            
        }

        private static string GetUserInput()
        {
            Console.WriteLine("\nType 'file' if you would like to specify a text file on your computer for me to read, otherwise type whatever words you wish me to read");
            string input = Console.ReadLine();

            if (input.ToLower().Trim() == "file")
            {
                //Present dialog to select a file for reading
                //StreamReader code
                return input;
            }
            else
            {
                return input;
            }
        }

        private static void ReportWordCount(string input)
        {
            string[] words = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Number of words you typed are: {0}", words.Length);
        }
    }
}