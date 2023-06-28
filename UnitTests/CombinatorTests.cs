using System;
using System.Collections.Generic;
using System.Linq;
using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class CombinatorTests

    {
        [Theory]
        [InlineData("0,0,0", "2,2,2", "0,0,0", "1,0,0", "0,1,0", "1,1,0", "0,0,1", "1,0,1", "0,1,1", "1,1,1")]
        [InlineData("0,0", "2,3", "0,0", "1,0", "0,1", "1,1", "0,2", "1,2")]
        [InlineData("0,1", "2,3", "0,1", "1,1", "0,2", "1,2")]
        [InlineData("0", "3", "0", "1", "2")]
        [InlineData("1", "3", "1", "2")]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("1", "2", "1")]
        public void TestListCombinations(string indexList, string maxList, params string[] expected)
        {
            var indexes = indexList.Split(",").Select(int.Parse).ToArray();
            var maxInts = maxList.Split(",").Select(int.Parse).ToArray();
            var result = new List<string>();
            var makeResult = new Action<List<int>>(intList => result.Add( string.Join(",", intList.Select(x => x.ToString()))));

            Combinator.ListCombinations(indexes, maxInts, makeResult);
        
            result.ShouldBe(expected);
        }
    }
}