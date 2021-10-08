using System.Collections.Generic;

namespace TestProject
{
    public class IntegerOverflow
    {
        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static string MiniMaxSum(List<int> arr)
        {
            var longs = new ulong[5];
            for (int i = 0; i < arr.Count; i++)
            {
                longs[i] = (ulong)arr[i];
            }

            var total = new ulong[5];
            total[0] = longs[0] + longs[1] + longs[2] + longs[3];
            total[1] = longs[0] + longs[1] + longs[2] + longs[4];
            total[2] = longs[0] + longs[1] + longs[3] + longs[4];
            total[3] = longs[0] + longs[2] + longs[3] + longs[4];
            total[4] = longs[1] + longs[2] + longs[3] + longs[4];

            var min = total[0];
            ulong max = 0;

            for (int i = 0; i < 5; i++)
            {
                if (total[i] < min)
                    min = total[i];
                if (total[i] > max)
                    max = total[i];
            }

            return $"{min} {max}";
        }

        // Better version
        public static string MiniMaxSumV2(List<int> arr)
        {
            ulong total = 0;
            ulong min = ulong.MaxValue;
            ulong max = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if ((ulong)arr[i] < min)
                    min = (ulong)arr[i];
                if ((ulong)arr[i] > max)
                    max = (ulong)arr[i];
                total += (ulong)arr[i];
            }

            return $"{total - max} {total - min}";
        }
    }
}
