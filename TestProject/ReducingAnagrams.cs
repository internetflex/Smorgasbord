namespace TestProject
{
    public class ReducingAnagrams
    {
        // A = "aaabc" B = "bcccd"
        // remove "aaa" from A and "ccd" from B leaving bc in common
        // Total removed 6 chars

        // A = "aaa" B = "a"
        public static int MostCommon(string first, string second)
        {
            var removeCount = 0;

            foreach (var ch in first)
            {
                var index = second.IndexOf(ch);
                if (index >= 0)
                {
                    second = second.Remove(index, 1);
                }
                else
                {
                    removeCount++;
                }
            }

            if (removeCount == first.Length)
                return -1;

            return removeCount + second.Length;
        }
    }
}
