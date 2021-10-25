using System.Collections.Generic;

namespace TestProject
{
    public static class FindNextBiggestLong
    {
        public static long FindNextBiggestRecursive(long input)
        {
            var digits = input.ToString();
            var biggerLongs = new List<long>();
            ShuffleRecursive(digits, "", input, biggerLongs);
            if (biggerLongs.Count == 0)
                return -1;
            biggerLongs.Sort();
            return biggerLongs[0];
        }

        public static long FindNextBiggest(long input)
        {
            var digits = input.ToString();
            var biggerLongs = new List<long>();
            Shuffle(digits, "", input, biggerLongs);
            if (biggerLongs.Count == 0)
                return -1;
            biggerLongs.Sort();
            return biggerLongs[0];
        }

        private static void Shuffle(string digits, string shuffledDigits, long input, List<long> biggerLongs)
        {
            var stack = new Stack<(string Digits, string Shuffled)>();
            stack.Push((Digits:digits, Shuffled: shuffledDigits));

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (current.Digits.Length == 0)
                {
                    if (!long.TryParse(current.Shuffled, out var number))
                        continue;
                    if (number > input)
                        biggerLongs.Add(number);
                }
                else
                {
                    for (int i = 0; i < current.Digits.Length; i++)
                    {
                        stack.Push((Digits:current.Digits.Remove(i,1), $"{current.Shuffled}{current.Digits[i]}"));
                    }
                }
            }
        }

        private static void ShuffleRecursive(string digits, string shuffledDigits, long input, List<long> biggerLongs)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                var shuffledDigitsCopy = $"{shuffledDigits}{digits[i]}";
                var digitsCopy = digits.Remove(i, 1);

                if (digitsCopy == "")
                {
                    if (!long.TryParse(shuffledDigitsCopy, out var number))
                        continue;
                    if (number > input)
                        biggerLongs.Add(number);
                }
                else
                {
                    Shuffle(digitsCopy, shuffledDigitsCopy, input, biggerLongs);
                }
            }
        }
    }
}
