Solution solution = new Solution();

Console.WriteLine(solution.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));

public class Solution
{
    public int MaxArea(int[] height)
    {
        int leftPointer = 0;
        int rightPointer = height.Length - 1;

        int maxArea = 0;
        while (leftPointer < rightPointer)
        {
            for (int i = leftPointer + 1; i < height.Length; i++)
            {
                int leftValue = height[leftPointer];
                int tempValue = height[i];

                int smaller = Math.Min(leftValue, tempValue);

                int currentArea = smaller * i;

                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                }
            }

            leftPointer++;
            rightPointer--;
        }

        return maxArea;
    }
}