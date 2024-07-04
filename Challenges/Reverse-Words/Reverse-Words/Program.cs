using System;

namespace Reverse_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string word1 = "csharp is programming language";
            string word2 = "Reverse the words in this sentence";
            string word3 = "challenges and data structures";

            string reversed1 = ReversedWord.ReverseWords(word1);
            string reversed2 = ReversedWord.ReverseWords(word2);
            string reversed3 = ReversedWord.ReverseWords(word3);

            Console.WriteLine("Reversed strings:");
            Console.WriteLine(reversed1);
            Console.WriteLine(reversed2);
            Console.WriteLine(reversed3);
        }
    }

    public class ReversedWord
    {
        public static string ReverseWords(string word)
        {
            
            string[] words = word.Split(' ');

            
            Array.Reverse(words);

            
            string reversedString = string.Join(' ', words);

            return reversedString;
        }
    }
}
