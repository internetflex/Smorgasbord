using Moq;
using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestLotteryBalls
    {
        [Theory]
        [InlineData(new[] {1,2,1,2,1,5,8,5,4}, new[] {1,1,1,2,2,4,5,8})]
        [InlineData(new[] {20,7,6,5,4,3,2,1,1,2}, new[] {1,2,3,4,5,6,7,20})]
        [InlineData(new[] {1,1,1,1,1,1,1,1,1}, new[] {1,1,1,1,1,1,1,1})]
        [InlineData(new[] {5,1,1,3,1,1,3,5,5,1}, new[] {1,1,1,1,1,3,3,5})]
        [InlineData(new[] {5,3,1,3,1,5,1,3,5,5,1}, new[] {1,1,1,1,3,3,3,5})]
        void Test1(int[] randomValues, int[] expected)
        {
            int nextIndex = 0;
            var rng = new Mock<IRandomNumberGenerator>();
            rng.Setup(x => x.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(() => randomValues[nextIndex++]);
            var sut = new LotteryBalls(rng.Object);
            var result = sut.MakeSelection();
            result.ShouldBe(expected);
        }
    }
}
