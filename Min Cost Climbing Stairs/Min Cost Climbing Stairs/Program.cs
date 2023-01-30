// See https://aka.ms/new-console-template for more information
int[] cost = new int[] { 10, 15, 20 };
Solution solution = new Solution();
int minCost = solution.MinCostClimbingStairs(cost);
Console.WriteLine(minCost);

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int firstStep = cost[0];
        int secondStep = cost[1];

        for (int i = 2; i < cost.Length; i++)
        {
            int current = cost[i] + Math.Min(firstStep, secondStep);

            firstStep = secondStep;
            secondStep = current;
        }

        return Math.Min(firstStep, secondStep);
    }
}