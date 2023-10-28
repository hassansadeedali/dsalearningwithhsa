using System.Collections.Generic;

namespace Blind75.Arrays
{
    /*
    Given an array of integers nums and an integer target, 
    return indices of the two numbers such that they add up to target.
    
    You may assume that each input would have exactly one solution, 
    and you may not use the same element twice.
    
    You can return the answer in any order.
    */
    public static class TwoSum
    {
        public static readonly int[] nums = new int[] { 2, 7, 11, 15 };
        public static readonly int target = 9;
        //Output: [0,1]
        //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        public static int[] Handle()
        {
            Dictionary<int, int> indices = new();

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

        //Two Sum II - Input Array Is Sorted
        public static int[] TwoSumSorted(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[left] + nums[right];
                if (sum > target)
                {
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    return new int[] { left + 1, right + 1 };
                }
            }

            return new int[0];
        }
    }
}
