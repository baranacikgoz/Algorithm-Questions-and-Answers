Solution solution = new();
Console.WriteLine(solution.Tribonacci(1));

public class Solution
{
    public int Tribonacci(int n)
    {
        try
        {
            int[] dp = new int[n + 1];

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;

            for (int i = 0; i <= n - 3; i++)
            {
                dp[i + 3] = dp[i + 2] + dp[i + 1] + dp[i];
            }

            return dp[n];
        }
        catch (IndexOutOfRangeException)
        {
            return n == 0 ? 0 : 1;
        }
    }
}