public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] indices = new int[2];
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] + nums[i] == target)
                {
                    indices[0] = i;
                    indices[1] = j;
                    return indices;
                }
            }    
        }
        indices[0] = -1;
        indices[1] = -1;
        return indices;
    }
}

public class Test
{
    public static void Main()
    {
        Solution solution = new Solution();
        int[] nums = new int[] { -1, -2, -3, -4, -5 };
        int[] result = solution.TwoSum(nums, -8);
        for( int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
