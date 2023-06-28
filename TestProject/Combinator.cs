using System;
using System.Collections.Generic;

namespace TestProject
{
    public class Combinator
    {
        public static void ListCombinations(int[] startIndexes, int[] maxIndexes, Action<List<int>> dataSelectionHandler)
        {
            var increment = 0;
            var combinedIndexers = Pipe(() => (increment, startIndexes), CreateIndexUpdater(maxIndexes[0], 0));
           
            for (var i = 1; i < startIndexes.Length; i++)
            {
                var nextIndexUpdater = CreateIndexUpdater(maxIndexes[i], i);
                combinedIndexers = Pipe(combinedIndexers, nextIndexUpdater);
            }

            var result = combinedIndexers();
            increment = 1;

            while (result.CarryOverIncrement != 1 )
            {
                var indexSet = new List<int>();
                indexSet.AddRange(result.Indexes);
                dataSelectionHandler(indexSet);
                result = combinedIndexers();
            }

            Func<(int, int[]), (int, int[])> CreateIndexUpdater(int max, int offset) =>
                parameters =>
                {
                    var (addValue, indexes) = parameters;

                    if (indexes[offset] + addValue == max)
                    {
                        indexes[offset] = 0;
                        return (1, indexes);
                    }

                    indexes[offset] += addValue;

                    return (0, indexes);
                };

            Func<(int CarryOverIncrement, int[] Indexes)> Pipe(Func<(int, int[])> f, Func<(int, int[]), (int, int[])> g) => () => g(f());
        }
    }
}