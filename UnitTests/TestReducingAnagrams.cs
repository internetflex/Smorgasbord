using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestReducingAnagrams
    {
        [Theory]
        [InlineData("aaa", "a", 2)]
        [InlineData("aaabb", "ab", 3)]
        [InlineData("ab", "", -1)]
        [InlineData("ab", "cd", -1)]
        void Test1(string first, string second, int expected)
        {
            ReducingAnagrams.MostCommon(first, second).ShouldBe(expected);
        }
    }
}
