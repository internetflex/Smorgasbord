using System.Collections.Generic;

namespace TestProject
{
    public class SourceCharsInTargetString
    {
        public static int FindMaxSourceCharsInTarget(string source, string target)
        {
            int count = 0;

            foreach (var ch in source)
            {
                var index = target.IndexOf(ch);
                if (index >= 0)
                {
                    count++;
                    target = target.Remove(index, 1);
                }
            }

            return count;
        }

        public static int FindMaxConsecutiveSourceCharsInTarget(string source, string target)
        {
            var strQueue = new Queue<string>();
            strQueue.Enqueue(source);
            var maxLen = 0;

            while (strQueue.Count > 0)
            {
                var str = strQueue.Dequeue();
                if (target.IndexOf(str) >= 0)
                {
                    maxLen = str.Length;
                    break;
                }

                if (str.Length > 0)
                {
                    strQueue.Enqueue(str.Remove(0, 1));
                    strQueue.Enqueue(str.Remove(str.Length - 1, 1));
                }
            }

            return maxLen;
        }

        public static IEnumerable<string> PermutateAllCharsInSource(string source)
        {
            var strStack = new Stack<(string PartSource, string Output)>();
            strStack.Push((PartSource:source, Output:""));

            while (strStack.Count > 0)
            {
                var strPair = strStack.Pop();
                if (strPair.PartSource.Length == 0)
                {
                    yield return strPair.Output;
                }
                else
                {
                    for (var i = 0; i < strPair.PartSource.Length; i++)
                    {
                        var str1 = strPair.PartSource.Remove(i, 1);
                        var str2 = $"{strPair.Output}{strPair.PartSource[i]}";
                        strStack.Push((PartSource:str1, Output:str2));
                    }
                }
            }
        }

        public static IEnumerable<string> CombinationsOfNCharsInSource(string source, int count)
        {
            var strStack = new Stack<(string Output, int StartIndex)>();
            strStack.Push((Output:"", StartIndex:0));

            while (strStack.Count > 0)
            {
                var tuple = strStack.Pop();
                if (tuple.Output.Length == count)
                {
                    yield return tuple.Output;
                }
                else
                {
                    for (var i = tuple.StartIndex; i < source.Length; i++)
                    {
                        var str = $"{tuple.Output}{source[i]}";
                        strStack.Push((Output:str, StartIndex:i+1));
                    }
                }
            }
        }
    }
}
