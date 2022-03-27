public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> pascal = new List<IList<int>>();
        IList<int> list = new List<int>();
        IList<int> temp = new List<int>();
        int sum;
        list.Add(1);
        pascal.Add(new List<int>(list));
        
        if(numRows == 1)
        {
            return pascal;
        }
        list.Add(1);
        pascal.Add(new List<int>(list));
       
        if(numRows == 2)
        {
            return pascal;
        }
       
        for(int i = 2; i < numRows; i++)
        {
            sum = 0;
            for(int j = 0; j < list.Count; j++)
            {
                sum += list[j];
                temp.Add(sum);
                if (j != 0)
                {
                    sum -= list[j - 1];
                }
                

            }
            temp.Add(1);
            pascal.Add(new List<int>(temp));
            list.Clear();
            list = new List<int>(temp);
            
            temp.Clear();
        }
        
        return pascal;
    }
}
public class Test
{
    public static void Main()
    {
        Solution solution = new Solution();
        IList<IList<int>> result = solution.Generate(7);
        foreach (IList<int> i in result)
        {
            foreach(int num in i)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine(" ");
        }
    }
}