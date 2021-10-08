using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestConvert12To24Time
    {
        [Theory]
        [InlineData("00:00:01AM","00:00:01")]
        [InlineData("00:00:01PM","12:00:01")]
        [InlineData("12:59:59AM","00:59:59")]
        [InlineData("12:59:59PM","12:59:59")]
        public void Test1(string testTime, string expectedTime)
        {
            var result = Convert12To24Time.TimeConversion(testTime);
            result.ShouldBe(expectedTime);
        }
    }
}
