Solution solution = new();

Console.WriteLine(solution.Fib(5));

public class Solution
{
    public int Fib(int n)
    {
        if (n < 1)
        {
            return 0;
        }

        var table = new int[n + 1];

        // Seed the trivial answer.
        table[1] = 1;

        // Iterate and fill further positions based on current values.
        for (var i = 0; i < n - 1; i++)
        {
            table[i + 2] = table[i] + table[i + 1];
        }
        return table[n];
    }
}