using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Maximum Length of a Concatenated String with Unique Characters
    //Given an array of strings arr. String s is a concatenation of a sub-sequence of arr which have unique characters.
    //Return the maximum possible length of s.
    class ConcatenatedString
    {
        public static int MaxLength(IList<string> arr)
        {

            /*
                ----------------------------------------------------------------
                Algorithm
                -----------------------------------------------------------------
                - Initialize a results list with an empty string.
                - Iterate through each entry in arr, and for each entry:
                - Iterate through each entry in results, and for each entry:
                    -> Form a new result combination.
                    -> Check for duplicate characters with the use of a set.
                    -> If the new result is valid, then add it to results.
                    -> Keep track of the longest valid result so far in best.
                - Return best.
                ------------------------------------------------------------------
            */
            List<string> set = new List<string>();

            int best = 0;
            set.Add("");

            foreach (var item in arr)
            {
                var len = set.Count();

                for (int i = 0; i < len; i++)
                {
                    var newCombination = set[i] + item;
                    HashSet<char> newResSet = new HashSet<char>();
                    foreach (var character in newCombination)
                    {
                        newResSet.Add(character);
                    }
                    if (newCombination.Length != newResSet.Count())
                        continue;

                    set.Add(newCombination);
                    best = Math.Max(best, newCombination.Length);
                }
            }   
            
            return best;
        }
    }
}
