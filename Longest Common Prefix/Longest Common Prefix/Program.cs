using System.Text;

Solution solution = new Solution();

Console.WriteLine(solution.LongestCommonPrefix(new[] { "cir", "car" }));

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        // Find the shortest string to iterate over its length at most (avoid IndexOutOfRange)
        string minElementString = strs[0];
        foreach (string str in strs)
        {
            if (str.Length < minElementString.Length)
            {
                minElementString = str;
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < minElementString.Length; i++)
        {
            char currentChar = minElementString[i];

            foreach (string str in strs)
            {
                if (str[i] != currentChar)
                {
                    return sb.ToString();
                }
            }

            sb.Append(currentChar);
        }

        return sb.ToString();
    }
}