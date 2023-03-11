
Console.WriteLine(Solution.IsValid("()"));
public static class Solution
{
    public static bool IsValid(string s)
    {
        if (s.Length < 2)
        {
            return false;
        }

        Dictionary<char, int> bracketIndexMap = new()
        {
            {'(', 0},
            {'{', 1},
            {'[', 2},
            {')', 3},
            {'}', 4},
            {']', 5}
        };

        Stack<char> openingsStack = new();

        foreach (char bracket in s)
        {
            int indexOfCurrent = bracketIndexMap[bracket];

            if (indexOfCurrent < 3)
            {
                openingsStack.Push(bracket);
                continue;
            }
            // current is closing

            // if there nothing left to pop
            if (openingsStack.Count == 0)
            {
                return false;
            }

            int correspondingOpeningIndex = indexOfCurrent - 3;

            if (bracketIndexMap[openingsStack.Pop()] != correspondingOpeningIndex)
            {
                return false;
            }
        }

        return openingsStack.Count == 0;
    }
}