using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace TestProject
{
    /*
    The lottery will draw 8 balls labeled 1 to 20.
    The balls will be picked out of bag and if the number rules below are valid we accept that number as part of the lottery numbers and return the ball back in the bag. We will do this until we get 8 numbers.
    Rules are:
    - The same number can appear more than once
    - No more than 2 occasions of duplicates are allowed
    Your function will return the results sorted in ascending order.

    [1,2,3,4,5,6,7,8]
    [1,1,2,2,2,6,7,8]

    Example not allowed:
    [1,1,2,2,3,3,7,8]
    not allowed bcs the re are 3 duplicates here 1,2,3
    */

    public class LotteryBalls
    {
        private readonly IRandomNumberGenerator _randomNumberNumberGenerator;

        public LotteryBalls(IRandomNumberGenerator randomNumberNumberGenerator)
        {
            _randomNumberNumberGenerator = randomNumberNumberGenerator;
        }

        public int[] MakeSelection()
        {
            var results = new List<int>();
            var validDuplicates = new List<int>();

            while (results.Count < 8)
            {
                var number = _randomNumberNumberGenerator.Next(1, 20);

                if (results.Contains(number) )
                {
                    if (!validDuplicates.Contains(number) && validDuplicates.Count < 2) 
                        validDuplicates.Add(number);

                    if (validDuplicates.Contains(number)) 
                        results.Add(number);
                }
                else
                    results.Add(number);
            }

            results.Sort();
            return results.ToArray();
        }
    }

    public interface IRandomNumberGenerator
    {
        int Next(int min, int max);
    }

    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random _random;

        public RandomNumberGenerator()
        {
            _random = new Random(3);
        }

        public int Next(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
