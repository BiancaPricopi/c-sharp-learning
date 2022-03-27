public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int substringLength = 0;
        int maxSubstringLength = 0;
        List<char> list = new List<char>();
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        for (int j = 0; j < s.Length; j++)
        {
            if (!list.Contains(s[j]))
            {
               list.Add(s[j]);
               substringLength++;
            }
            else
            {
                if (substringLength > maxSubstringLength)
                {
                    maxSubstringLength = substringLength;
                }
                substringLength = 0;
                list.Clear();
                j = dictionary[s[j]];
            }
            dictionary[s[j]] = j;
        }
            
        if (substringLength > maxSubstringLength)
        {
            maxSubstringLength = substringLength;
        }
        return maxSubstringLength;
    }
}

public class Test
{
    public static void Main()
    {
        Solution solution = new Solution();
        int l = solution.LengthOfLongestSubstring("bbbbbbbbb");
        Console.WriteLine("length = " + l);
        
    }
}