using System.Collections.Generic;

namespace TestProject
{
    public class CountUniqueChars
    {
        public static long FindUniqueChars(string s)
        {
            var uniqueChars = new HashSet<char>(s);
            return uniqueChars.Count;
        }
    }
}
