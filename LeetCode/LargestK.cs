using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Write a function that, given an array A of N integers,
    //returns the lagest integer K > 0 such that both values K and -K exist in array A.
    //If there is no such integer, the function should return 0.

    /*

        Example 1:
        Input: [3, 2, -2, 5, -3]
        Output: 3


        Example 2:
        Input: [1, 2, 3, -4]
        Output: 0
     
     */
    class LargestK
    {
        public static int FindLargestK(int[] arrayOfIntegers)
        {
            //Get length of array
            //Sort the array to start from smallest to larget
            //Check against each other and find the largest
            //Insert to hashset?

            int largest = 0;
            Array.Sort(arrayOfIntegers);

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (!set.Contains(arrayOfIntegers[i]))
                {
                    set.Add(arrayOfIntegers[i]);
                }
            }

            int maxSetValue = set.Max(); 
            
            //Get the largest value in the set
            //Check if the negative value of it exists in the array
            Console.WriteLine("Absolute value of {0} = {1}",
                                    set.Max(), Math.Abs(set.Max()) * -1);

            if (set.Max() > 0 && set.Contains(Math.Abs(set.Max()) * -1))
            {
                largest = set.Max();
            }
            else
            {
                largest = 0;
            }

            return largest;
        }

    }
}
