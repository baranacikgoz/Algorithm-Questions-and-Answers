// See https://aka.ms/new-console-template for more information
Solution solution = new();
var result = solution.CountBits(5);

Console.WriteLine("[{0}]", string.Join(", ", result));

public class Solution
{
    public int[] CountBits(int n)
    {
        var table = new int[n + 1];

        int lastPowerOfTwo = 1; // 1,2,4,8,16,32,....

        for (int i = 1; i < n + 1; i++)
        {
            if (i == lastPowerOfTwo * 2)
            {
                lastPowerOfTwo = i;
            }

            table[i] = table[i - lastPowerOfTwo] + 1;
        }

        return table;
    }
}