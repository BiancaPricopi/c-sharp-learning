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
            List<int> peopleInBoats = new List<int>();
            Array.Sort(people);
            Array.Reverse(people);

            for(int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i]);
            }
            
            for (int i = 0; i < people.Length; i++)
            {
                if(!peopleInBoats.Contains(i))
                {
                    if (people[i] < limit)
                    {
                        peopleInBoats.Add(i);
                        remainingSpace = limit - people[i];
                        for (int j = i + 1; j < people.Length; j++)
                        {
                            if (people[j] <= remainingSpace && !peopleInBoats.Contains(j))
                            {
                                peopleInBoats.Add(j);
                                break;
                            }
                        }
                        numOfBoats++;
                    }
                    else if (people[i] == limit)
                    {
                        peopleInBoats.Add(i);
                        numOfBoats++;
                    }

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
