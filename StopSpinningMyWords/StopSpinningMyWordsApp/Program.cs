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
        public static string SpinWordsII(string sentence) =>sentence
                   .Split(' ')
                   .Select(word => word.Length < 5 ? word : word.Reverse().StringJoin())
                   .StringJoin(" ");

        public static string SpinWordsIII(string sentence)
        {
            sentence.Split(' ').ToList().ForEach(word => { if (word.ToCharArray().Length >= 5) sentence = sentence.Replace(word, new String(word.Reverse().ToArray())); });
            return sentence;
        }
    }
    public static class StringJoinExtension
    {
        public static string StringJoin(this IEnumerable<string> stringList, string seperator = "") => string.Join(seperator, stringList);

        public static string StringJoin(this IEnumerable<char> stringList, string seperator = "") => string.Join(seperator, stringList);
    }


}
