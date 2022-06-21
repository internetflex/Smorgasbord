using System.Collections.Generic;
using System.Linq;
using System.Text;


public class TrayPortExercise
{

    /*
     * Complete the 'CalculateHighestScores' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER countOfHighScores - the number of highest scores and their locations to return
     *  2. INTEGER rowLength - the number of elements in one row of the array
     *  3. INTEGER_ARRAY array - zero-indexed array of integers
     */
    private static int[,] _grid;

    private class SumValues
    {
        public SumValues(int sum, int row, int col)
        {
            Sum = sum;
            Row = row;
            Col = col;
        }

        public int Sum { get; }
        public int Row { get; }
        public int Col { get; }
    }

    public static string CalculateHighestScores(int countOfHighScores, int rowLength, List<int> array)
    {
        if (rowLength * rowLength > array.Count)
            return string.Empty;

        _grid = new int[rowLength+2,rowLength+2];
        var index = 0;
        
        // Load into grid with surrounding 0 value cell border
        for (int i = 1; i <= rowLength; i++)
        {
            for (int j = 1; j <= rowLength; j++)
            {
                _grid[i, j] = array[index++];
            }
        }

        var results = new List<SumValues>();
        
        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < rowLength; col++)
            {
                results.Add(new SumValues(Sum3by3(row,col),row,col));                
            }
        }
        
        return getGroupOfHighScores(countOfHighScores, results);
    }

    private static int Sum3by3(int row, int col)
    {
        int sum = 0;
        for (int r = row; r <= row + 2; r++)
        {
            for (int c = col; c <= col + 2; c++)
            {
                sum += _grid[r, c];
            }
        }

        return sum;
    }
    
    private static string getGroupOfHighScores(int countOfHighScores, List<SumValues> results)
    {
        var sortedSums = results.OrderByDescending(x => x.Sum).ToList();

        var sb = new StringBuilder();
        var index = 0;
        var lastSum = sortedSums[0].Sum;

        while (countOfHighScores > 0 && index < sortedSums.Count)
        {
            if (sortedSums[index].Sum == lastSum)
                sb.Append($"({sortedSums[index].Sum},{sortedSums[index].Row},{sortedSums[index].Col})");
            else
            {
                if (--countOfHighScores == 0)
                    break;
                sb.Append($"({sortedSums[index].Sum},{sortedSums[index].Row},{sortedSums[index].Col})");
                lastSum = sortedSums[index].Sum;
            }

            index++;
        }

        return sb.ToString();
    }
}
