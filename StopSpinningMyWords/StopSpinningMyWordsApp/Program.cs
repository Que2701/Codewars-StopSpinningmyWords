using System;
using System.Collections.Generic;
using System.Linq;

namespace StopSpinningMyWordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpinWords("Welcome"));
        }

        static string SpinWords(string sentence)
        {
            string[] spaceLineSplit = new string[] { Environment.NewLine , " "};
            string[] newSentence = sentence.Split(spaceLineSplit, StringSplitOptions.None);
            sentence = String.Empty;

            for (int i = 0; i < newSentence.Length; i++)
            {
                char[] charArray = newSentence[i].ToCharArray();
                if (charArray.Length > 4)
                {
                    Array.Reverse(charArray);
                }
                sentence += $"{new string(charArray)} {string.Empty}";
            }

            return sentence.Trim();
        }
    }
}
