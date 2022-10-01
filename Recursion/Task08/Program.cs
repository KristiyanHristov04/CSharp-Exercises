using System;

namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine(); //RADAR -> RADAR(Palindrome)
            string newWord = string.Empty;
            bool isPalindrome = IsPalindrome(0, word.Length - 1, word, newWord);
            if (isPalindrome)
            {
                Console.WriteLine("The string is Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not Palindrome.");
            }
        }
        static bool IsPalindrome(int index, int endIndex, string word, string newWord)
        {
            if (index > endIndex)
            {
                if (word.Equals(newWord))
                {
                    return true;
                }
                return false;
            }
            newWord += word[endIndex - index];
            return IsPalindrome(index + 1, endIndex, word, newWord);
        }
    }
}
