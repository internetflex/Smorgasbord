using System.Collections.Generic;
using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestIntegerOverflow
    {
        [Theory]
        [InlineData(256741038, 623958417, 467905213, 714532089, 938071625, "2063136757 2744467344")]
        public void Test1(int val1, int val2, int val3, int val4, int val5, string expected)
        {
            var testData = new List<int> { val1, val2, val3, val4, val5 };
            var result = IntegerOverflow.MiniMaxSum(testData);
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(256741038, 623958417, 467905213, 714532089, 938071625, "2063136757 2744467344")]
        public void Test2(int val1, int val2, int val3, int val4, int val5, string expected)
        {
            var testData = new List<int> { val1, val2, val3, val4, val5 };
            var result = IntegerOverflow.MiniMaxSumV2(testData);
            result.ShouldBe(expected);
        }
    }
}
