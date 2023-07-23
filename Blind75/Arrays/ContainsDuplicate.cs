using System.Collections.Generic;

namespace Blind75
{
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





