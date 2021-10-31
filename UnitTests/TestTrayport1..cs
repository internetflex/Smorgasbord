using System.Collections.Generic;
using Shouldly;
using Xunit;

namespace UnitTests
{
    public class TestTrayport
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        void Test1(int countOfHighScores, int rowLength, List<int> array, string expected)
        {
            TrayPortExercise.CalculateHighestScores(countOfHighScores, rowLength, array).ShouldBe(expected);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { 1, 3, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "(45,1,1)" };
            yield return new object[] { 2, 3, new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(9,1,1)(6,0,1)(6,1,0)(6,1,2)(6,2,1)" };
            yield return new object[] { 1, 2, new List<int> { 1, 2, 3, 4 }, "(10,0,0)(10,0,1)(10,1,0)(10,1,1)" };
        }
    }
}
