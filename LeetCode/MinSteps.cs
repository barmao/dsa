using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MinSteps
    {
        public static int MinStepsToTake(int[] pile)
        {
            int pileLength = pile.Length;
            int stepsToTake = 0; 
            int distinctNumbers = 0;
            Array.Sort(pile);

            if (pileLength < 1) return 0;

            for(int i = 1; i < pileLength; i++)
            {
                if (pile[i] == pile[i - 1])
                {
                    stepsToTake += distinctNumbers;
                }
                else
                {
                    ++distinctNumbers;
                    stepsToTake += distinctNumbers;
                }
            }

            return stepsToTake;
        }
    }
}
