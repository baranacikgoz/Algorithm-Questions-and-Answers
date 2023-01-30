int[][] costs = new int[][] {
    new int[] {10, 20},
    new int[] {30, 200},
    new int[] {400, 50},
    new int[] {30, 20}
};

Solution solution = new();
Console.WriteLine(solution.TwoCitySchedCost(costs));

public class Solution
{
    public int TwoCitySchedCost(int[][] costs)
    {
        int n = costs.Length / 2;

        int totalCost = 0;

        int[] bCityRefunds = new int[n * 2];

        for (int i = 0; i < n * 2; i++)
        {
            totalCost += costs[i][0]; // First, send all people to city A.

            bCityRefunds[i] = costs[i][1] - costs[i][0]; // Calculate the refund if we send B instead.
        }

        Array.Sort(bCityRefunds);

        for (int i = 0; i < n; i++)
        {
            totalCost += bCityRefunds[i]; // Send n person to B instead of A.
        }

        return totalCost;
    }
}