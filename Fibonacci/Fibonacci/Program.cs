Solution solution = new Solution();
Console.WriteLine(solution.Fib(5));
public class Solution
{
    public int Fib(int n)
    {
        if (n < 1)
        {
            return 0;
        }

        int[] table = new int[n + 1];

        // Seed the trivial answer.
        table[1] = 1;

        // Iterate and fill further positions based on current values.

        //My first try
        //for (int i = 0; i < n; i++)
        //{
        //    try
        //    {
        //        table[i + 2] = table[i] + table[i + 1];
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        // Out of array bounds.
        //    }
        //}

        // n - 1 is a wiser choice
        for (int i = 0; i < n - 1; i++)
        {

            table[i + 2] = table[i] + table[i + 1];

        }
        return table[n];
    }
}