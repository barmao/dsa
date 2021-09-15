using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MinimumDeletions
    {
        //A string s is called good if there are no two different characters in s that have the same frequency.
        //Given a string s, return the minimum number of characters you need to delete to make s good.

        public static int MinDeletions(string s)
        {
            

            char[] characters = s.ToCharArray();
            int[] count = new int[128];

            foreach (var character in characters)
            {
                count[character]++;
            }

            Array.Sort(count);

            HashSet<int> set = new HashSet<int>();

            int r = 0;

            for (int i = 0; i < count.Length; i++)
            {
                if(count[i] != 0)
                {
                    if (!set.Contains(count[i]))
                    {
                        set.Add(count[i]);
                    }
                    else
                    {
                        int cur = count[i];
                        while (cur != 0 && set.Contains(cur))
                        {
                            cur--;
                        }
                        set.Add(cur);
                        r += count[i] - cur;
                    }
                }
            }

            return r;
        }
    }
}
