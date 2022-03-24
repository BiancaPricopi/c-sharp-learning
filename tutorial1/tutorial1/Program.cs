using System;
using System.Collections;

namespace tutorial1
{
    public class Solution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            int numOfBoats = 0;
            int remainingSpace;
            Array.Sort(people);
            Array.Reverse(people);
            
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] < limit)
                {
                    remainingSpace = limit - people[i];
                    for (int j = people.Length - 1; j > i; j--)
                    {
                        if (people[j] <= remainingSpace)
                        {
                            people[j] = limit + 10;
                            break;
                        }
                    }
                    numOfBoats++;
                    people[i] = limit + 10;
                }
                else if (people[i] == limit)
                {
                    people[i] = limit + 10;  
                    numOfBoats++;
                }
            }
            return numOfBoats;
        }
    }
    public class Test
    {
        static void Main()
        {
            Solution s = new Solution();
            int[] array = new int[] { 3, 8, 7, 1, 4 };
            Console.WriteLine(s.NumRescueBoats(array, 9));
        }
    }
}
