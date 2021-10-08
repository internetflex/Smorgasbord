using System.Diagnostics;
using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestSourceCharsInTargetString
    {
        [Theory]
        [InlineData("aaa", "a", 1)]
        [InlineData("abc", "ab", 2)]
        [InlineData("ab", "ababab", 2)]
        [InlineData("abc", "", 0)]
        [InlineData("", "abc", 0)]
        void Test1(string first, string second, int expected)
        {
            SourceCharsInTargetString.FindMaxSourceCharsInTarget(first, second).ShouldBe(expected);
        }

        [Theory]
        [InlineData("aaab", "aabaa", 3)]
        [InlineData("b", "aabaa", 1)]
        [InlineData("zxbyq", "aabaa", 1)]
        [InlineData("abc", "ab", 2)]
        [InlineData("ab", "xabay", 2)]
        [InlineData("ab", "xyab", 2)]
        [InlineData("ab", "", 0)]
        [InlineData("ab", "xy", 0)]
        [InlineData("", "abc", 0)]
        void Test2(string first, string second, int expected)
        {
            SourceCharsInTargetString.FindMaxConsecutiveSourceCharsInTarget(first, second).ShouldBe(expected);
        }

        [Fact]
        void Test3()
        {
            foreach (var str in SourceCharsInTargetString.PermutateAllCharsInSource("ABCD"))
            {
                Debug.WriteLine(str);
            }
        }

        [Fact]
        void Test4()
        {
            foreach (var str in SourceCharsInTargetString.CombinationsOfNCharsInSource("ABCDE", 3))
            {
                Debug.WriteLine(str);
            }
        }
    }
}
