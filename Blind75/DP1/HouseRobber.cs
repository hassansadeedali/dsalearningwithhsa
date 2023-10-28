using System;
using System.Linq;

namespace Blind75.DP1
{
    public class HouseRobber
    {
        /*
        You are a professional robber planning to rob houses along a street.
        Each house has a certain amount of money stashed, the only 
        constraint stopping you from robbing each of them is that adjacent 
        houses have security systems connected and it will automatically 
        contact the police if two adjacent houses were broken into on the 
        same night.

        Given an integer array nums representing the amount of money of each
        house, return the maximum amount of money you can rob tonight 
        without alerting the police.
        */

        public int Rob(int[] nums)
        {

            //rob1, rob2, n, n+1, n+2 .....
            int rob1 = 0;
            int rob2 = 0;

            for (int n = 0; n < nums.Length; n++)
            {
                var maxVal = Math.Max(rob1 + nums[n], rob2);
                rob1 = rob2;
                rob2 = maxVal;
            }

            return rob2;
        }

        //House Robber 2
        /*
        You are a professional robber planning to rob houses along a street.
        Each house has a certain amount of money stashed. 
        All houses at this place are arranged in a circle. That means the 
        first house is the neighbor of the last one. Meanwhile, adjacent 
        houses have a security system connected, and it will automatically 
        contact the police if two adjacent houses were broken into on the 
        same night.

        Given an integer array nums representing the amount of money of each
        house, return the maximum amount of money you can rob tonight 
        without alerting the police.
        */

        public int Rob2(int[] nums)
        {
            if (nums.Length < 3)
                return nums.Max();

            var firstRes = Helper(nums, 0, nums.Length - 1);
            var secondRes = Helper(nums, 1, nums.Length);

            return Math.Max(firstRes, secondRes);

        }

        public int Helper(int[] nums, int start, int end)
        {
            //rob1, rob2, n, n+1, n+2 .....
            int rob1 = 0;
            int rob2 = 0;

            for (int n = start; n < end; n++)
            {
                var maxVal = Math.Max(rob1 + nums[n], rob2);
                rob1 = rob2;
                rob2 = maxVal;
            }

            return rob2;
        }
    }
}
