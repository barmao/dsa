using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get the minimun deletions");
            int min = MinimumDeletions.MinDeletions("aaabbbcc");

            String s1 = "abcd";
            String s2 = "cdab";

            int size = s2.Length;

            if (Anagram.isAnagram(s1, s2))
                Console.WriteLine(Anagram.CountSteps(s1.ToCharArray(), s2.ToCharArray(), size));
            else
                Console.WriteLine(-1);

            Console.WriteLine("Get Min Steps to Make Piles Equal Height");
            int[] pile = { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 };
            int minSteps = MinSteps.MinStepsToTake(pile);
            Console.WriteLine("Get Min Steps to Make Are " + minSteps);
        }
    }
}
