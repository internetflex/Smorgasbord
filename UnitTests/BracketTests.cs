using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class BracketTests
    {
        [Theory]
        [InlineData("() (()) [] {} <> [<({})>] [[]] (((())))", true)]
        [InlineData("[{}()<hello world>[[{{}}]]]", true)]
        [InlineData("(>", false)]
        [InlineData("(", false)]
        [InlineData("(", false)]
        [InlineData("[", false)]
        [InlineData("<", false)]
        [InlineData("{", false)]
        [InlineData("@", true)]
        [InlineData("()", true)]
        [InlineData("())", false)]
        [InlineData("(())", true)]
        [InlineData("((<))", false)]
        [InlineData("((<)>)", false)]
        [InlineData("<(()>)", false)]
        [InlineData("{}", true)]
        [InlineData("{}()", true)]
        [InlineData("{}()[]", true)]
        [InlineData("{}()[]<>", true)]
        [InlineData("[]", true)]
        [InlineData("<>", true)]
        public void ShouldCheckIfBracketsBalanced(string input, bool expected)
        {
            var sut = new Brackets();
            var result = sut.IsBalanced(input);
            result.ShouldBe(expected);
        }
    }
}