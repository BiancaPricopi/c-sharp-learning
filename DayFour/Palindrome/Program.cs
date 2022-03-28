public class Solution
{
    public bool IsPalindrome(int x)
    {
        int num = 0;
        int copy = x;
        while(copy > 0)
        {
            int digit = copy % 10;
            num = num * 10 + digit;
            copy /= 10;
        }
        return num == x;
    }
}

public class Test
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsPalindrome(1000001));
    }
}