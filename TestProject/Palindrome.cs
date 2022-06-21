using System.Linq;

namespace TestProject
{
    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            var lowerCaseWord = word.ToLower();
            var reverseWord = lowerCaseWord.Reverse();

            return lowerCaseWord == reverseWord;
        }
    }
}