// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// [7,1,5,3,6,4]
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;

        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);

            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }

        return maxProfit;
    }
}