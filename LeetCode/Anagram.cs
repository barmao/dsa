using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Anagram
    {
        //Minimum number of adjacent swaps to convert a string into its given anagram
        //Given two strings s1 and s2, the task is to find the minimum number of steps required to convert s1 into s2.
        //The only operation allowed is to swap adjacent elements in the first string. Every swap is counted as a single step.


        //Approach: Use two pointers i and j for first and second strings respectively. Initialise i and j to 0. 
        //Iterate over the first string and find the position j such that s1[j] = s2[i] by incrementing the value to j.
        //Keep on swapping the adjacent elements j and j – 1 and decrement j until it is greater than i.
        //Now the ith element of the first string is equal to the second string, hence increment the value of i.
        //This technique will give the minimum number of steps as there are zero unnecessary swaps.

        //https://www.geeksforgeeks.org/minimum-number-of-adjacent-swaps-to-convert-a-string-into-its-given-anagram/
        public static Boolean isAnagram(String s1, String s2)
        {
            s1 = sortString(s1);
            s2 = sortString(s1);

            return (s2.Equals(s1));
        }

        public static String sortString(String inputString)
        {
            char[] tempArray = inputString.ToCharArray();

            Array.Sort(tempArray);

            return new String(tempArray);
        }

        public static int CountSteps(char []s1, char []s2, int size)
        {
            int i=0, j = 0;
            int result = 0;

            while(i < size)
            {
                j = i;

                while(s1[j] != s2[i])
                {
                    j += 1;
                }

                while(i < j)
                {
                    char temp = s1[j];
                    s1[j] = s1[j - 1];
                    s1[j - 1] = temp;
                    j -= 1;
                    result += 1;
                }
                i += 1;
            }
            return result;
        }

    }
}
