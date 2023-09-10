using System;

namespace Blind75.Sliding_Window
{
    public static class BestTimetoBuyandSellStock
    {
        // read input
        public static readonly int[] nums = new int[] { 1, 2, 1 };
        public static int Handle()
        {
            int maxProfit = 0;
            int minPrice = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                var currentPrice = nums[i];
                minPrice = Math.Min(minPrice, currentPrice);
                maxProfit = Math.Max(maxProfit, currentPrice - minPrice);
            }
            return maxProfit;
        }
    }
}
