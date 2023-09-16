using System;

namespace Blind75.Greedy
{
    /*
    Given an integer array nums, find the subarray
    with the largest sum, and return its sum.
     */
    public class MaximumSubarray
    {
        // read input
        public static readonly int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        // Output: 6
        // Explanation: The subarray[4, -1, 2, 1] has the largest sum 6.

        public static int Handle()
        {
            int maxSum = nums[0];
            int currSum = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (currSum < 0)
                    currSum = 0;
                currSum = currSum + nums[i];

                maxSum = Math.Max(currSum, maxSum);
            }

            return maxSum;
        }
    
    }
}
