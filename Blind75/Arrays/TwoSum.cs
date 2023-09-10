using System.Collections.Generic;

namespace Blind75.Arrays
{
    public static class TwoSum
    {
        public static readonly int[] nums = new int[] { 1, 2, 1 };
        public static readonly int target = 9;
        public static int[] Handle()
        {
            Dictionary<int, int> indices = new ();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (indices.ContainsKey(diff))
                {
                    return new int[] { indices[diff], i };
                }
                indices[nums[i]] = i;
            }
            return null;
        }
    }
}
