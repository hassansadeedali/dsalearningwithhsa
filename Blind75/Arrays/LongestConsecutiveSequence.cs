using System;
using System.Collections.Generic;

namespace Blind75.Arrays
{
    /*
     * Given an unsorted array of integers nums, 
     * return the length of the longest consecutive elements sequence.
     * 
     * You must write an algorithm that runs in O(n) time.
     */
    public class LongestConsecutiveSequence
    {
        public static readonly int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };

        public static int Handle()
        {
            if (nums.Length < 2) 
                return nums.Length;

            int longest = 0;

            //Since we cannot do contains in array
            var set = new HashSet<int>(nums);

            foreach(var n in nums)
            {
                //Passes for first number in the loop
                if (!set.Contains(n - 1))
                {
                    var length = 0;
                    while (set.Contains(n + length))
                    {
                        length++;
                        longest = Math.Max(longest, length);
                    }
                }
            }
            return longest;
        }

    }
}
