using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class FindNextBiggestLongTests
    {
        [Theory]
        [InlineData(24, 42)]
        [InlineData(7, -1)]
        [InlineData(77, -1)]
        [InlineData(72, -1)]
        [InlineData(314, 341)]
        [InlineData(3149, 3194)]
        [InlineData(3294, 3429)]
        [InlineData(3984, 4389)]
        [InlineData(3894, 3948)]
        void TestPermutations(long number, long expected)
        {
            FindNextBiggestLong.FindNextBiggest(number).ShouldBe(expected);
        }

        [Theory]
        [InlineData(24, 42)]
        [InlineData(7, -1)]
        [InlineData(77, -1)]
        [InlineData(72, -1)]
        [InlineData(314, 341)]
        [InlineData(3149, 3194)]
        [InlineData(3294, 3429)]
        [InlineData(3984, 4389)]
        [InlineData(3894, 3948)]
        void TestRecursivePermutations(long number, long expected)
        {
            FindNextBiggestLong.FindNextBiggestRecursive(number).ShouldBe(expected);
        }
    }
}
