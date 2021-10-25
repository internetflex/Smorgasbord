namespace TestProject
{
    public static class LeftOrRightOfBinaryTreeSumLarger
    {
        // -1 means empty node
        public static string Solution(long[] arr)
        {
            if (arr.Length <= 1)
                return "";

            var leftSum = arr[0];
            var rightSum = arr[0];
            var sideCount = 1; // Number of nodes to fill on Left Or Right side - increasing x2 each level
            var index = 0;

            // Breath first binary tree filling values in arr
            while (true)
            {
                for (var i = 0; i < sideCount; i++)
                {
                    if (++index >= arr.Length)
                        break;

                    if (arr[index] > 0)
                        leftSum += arr[index];
                }

                for (var i = 0; i < sideCount; i++)
                {
                    if (++index >= arr.Length)
                        break;

                    if (arr[index] > 0)
                        rightSum += arr[index];
                }

                if (index >= arr.Length)
                    break;

                sideCount *= 2;
            }

            if (leftSum > rightSum)
                return "Left";

            if (leftSum < rightSum)
                return "Right";

            return "";
        }
    }
}
