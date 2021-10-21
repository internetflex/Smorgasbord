using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestLeftOrRightOfBinaryTreeSumLarger
    {
        [Theory]
        [InlineData(new long[]{}, "")]
        [InlineData(new long[]{1}, "")]
        [InlineData(new long[]{1,1,1}, "")]
        [InlineData(new long[]{1,2,2}, "")]
        [InlineData(new long[]{1,2,3}, "Right")]
        [InlineData(new long[]{1,3,2}, "Left")]
        [InlineData(new long[]{1,-1,2}, "Right")]
        [InlineData(new long[]{1,-1,-1}, "")]
        [InlineData(new long[]{1,1}, "Left")]
        [InlineData(new long[]{1,-1,1}, "Right")]
        [InlineData(new long[]{1,1,1,1,2,1,3}, "Right")]
        [InlineData(new long[]{1,1,1,2,2,1,3}, "")]
        [InlineData(new long[]{1,1,1,2,2,1,3,1}, "Left")]
        [InlineData(new long[]{1,1,1,2,2,2,3}, "Right")]
        void Test(long[] arr, string expected)
        {
            LeftOrRightOfBinaryTreeSumLarger.Solution(arr).ShouldBe(expected);
        }
    }
}
