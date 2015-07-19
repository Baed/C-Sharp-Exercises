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
            string userInput = string.Empty;

            Console.WriteLine("Hello.  I am a robot.  Bleep bloop.\nMy job is to alter words that you type in to Pig Latin!\nType something for me!");
            
            userInput = getUserInput();
            userInput = removeNonCharsFromUserInput(userInput);
            determineIfUserInputHasMultipleWords();
            convertToPigLatin();
        }

        private static string getUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }

        private static string removeNonCharsFromUserInput(string userInput)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in userInput)
            {
                if (Char.IsLetterOrDigit(c) || c == '.' || c == '_' || c == ' ' || c == '%')
                { sb.Append(c); }
            }
            return sb.ToString();

            string strippedString = Regex.Replace(userInput, "[^a-zA-Z0-9_]+", " ");
            return strippedString;
        }
    }
}
/*My "design" notes (look away, don't judge!)
1) Get a string "banana" or "i really want 5 bananas, or else i'll die!"
2) Remove all non-chars (numbers, special symbols)
3) Determine if string has multiple words
4) If multiple words:
    - Split string into array
    - Run piglatin code on all items in array
5) If not multiple words
    - Run piglatin code

Piglatin code:
1) Begins with consonant:
    - Move first char to end of string
        - Get length
        - Substring (0, 1)
        - String w/o first char + substring
    - Concotonate string with "ay" (banana --> ananabay)
2) Beings with vowel or silent letter
    - Just add "yay" to end of string
*/
