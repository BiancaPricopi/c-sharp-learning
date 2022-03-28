public class Solution
{
    public bool IsPalindrome(int x)
    {
        int num = 0;
        int copy = x;
        int pow = 1;
        int numOfDigits = 1;
        while(copy > 0)
        {
            numOfDigits *= 10;
            copy /= 10;
        }
        numOfDigits /= 10;
        copy = x;
        while (copy > 0)
        {
            int digit = copy % 10;

            num += numOfDigits * digit;
            numOfDigits /= 10;
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
        Console.WriteLine(solution.IsPalindrome(555));
    }
}