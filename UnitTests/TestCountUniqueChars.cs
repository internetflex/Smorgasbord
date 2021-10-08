using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestCountUniqueChars
    {
        [Theory]
        [InlineData("aaa", 1)]
        [InlineData("aba", 2)]
        [InlineData("abab", 2)]
        [InlineData("ababc", 3)]
        [InlineData("", 0)]
        [InlineData("xyabayx", 4)]
        void Test1(string testStr, int expected)
        {
            CountUniqueChars.FindUniqueChars(testStr).ShouldBe(expected);
        }
    }
}
