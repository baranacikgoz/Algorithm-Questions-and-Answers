var solution = new Solution();

var prices = new int[] { 7, 1, 5, 3, 6, 4 };

Console.WriteLine(solution.MaxProfit(prices));

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var minPrice = int.MaxValue;

        var maxProfit = 0;

        foreach (var price in prices)
        {
            minPrice = Math.Min(minPrice, price);

            maxProfit = Math.Max(maxProfit, price - minPrice);
        }

        return maxProfit;
    }
}