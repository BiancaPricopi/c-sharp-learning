﻿public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int substringLenght = 0;
        int maxSubstringLength = 0;
        List<char> list = new List<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(!list.Contains(s[i]))
            {
                list.Add(s[i]);
                substringLenght++;
            }
            else
            {
                if(substringLenght > maxSubstringLength)
                {
                    maxSubstringLength = substringLenght;
                }
                substringLenght = 0;
                list.Clear();
            }
        }
        return maxSubstringLength;
    }
}

public class Test
{
    public static void Main()
    {
        Solution solution = new Solution();
        int l = solution.LengthOfLongestSubstring("pwwkew");
        Console.WriteLine("length = " + l);
    }
}