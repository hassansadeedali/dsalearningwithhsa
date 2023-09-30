using System.Collections.Generic;

namespace Blind75
{
    /*
     * Given an integer array nums, return true if any value appears at
     * twice in the array, and return false if every element is distinct.
     */
    public static class ContainsDuplicate
    {
        // read input
        public static readonly int[] nums = new int[] { 1, 2, 1 };

        public static bool Handle()
        {
            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    numbers.Add(nums[i]);
                }
            }

            return false;
        }
    }
}





