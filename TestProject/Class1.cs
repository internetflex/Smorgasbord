namespace TestProject
{

// You are running a classroom and suspect that some of your students are passing around the answers to multiple choice questions disguised as random strings.

// Your task is to write a function that, given a list of words and a string, finds and returns the word in the list that is scrambled up inside the string, if any exists. There will be at most one matching word. The letters don't need to be in order or next to each other. The letters cannot be reused.

// Example:
// words = ['cat', 'baby', 'dog', 'bird', 'car', 'ax']
// string1 = 'tcabnihjs'
// find_embedded_word(words, string1) -> cat (the letters do not have to be in order)

// string2 = 'tbcanihjs'
// find_embedded_word(words, string2) -> cat (the letters do not have to be together)

// string3 = 'baykkjl'
// find_embedded_word(words, string3) -> None / null (the letters cannot be reused)

// string4 = 'bbabylkkj'
// find_embedded_word(words, string4) -> baby

// string5 = 'ccc'
// find_embedded_word(words, string5) -> None / null

// string6 = 'breadmaking'
// find_embedded_word(words, string6) -> bird

// Complexity analysis variables:

// W = number of words in `words`
// S = maximal length of each word or string

    public class FindEmbeddedWord
    {
        public static string find_embedded_word(string[] words, string searchWord)
        {
            foreach (string word in words)
            {
                var count = 0;
                var copyWord = searchWord;

                foreach (char ch in word)
                {
                    var index = copyWord.IndexOf(ch);
                    if (index > -1)
                    {
                        count++;
                        copyWord = copyWord.Remove(index, 1);
                    }
                    else
                    {
                        break;
                    }
                }

                if (count == word.Length)
                {
                    return word;
                }
            }

            return string.Empty;
        }
    }


}
