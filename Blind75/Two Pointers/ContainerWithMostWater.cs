using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Two_Pointers
{
    /*
    You are given an integer array height of length n.
    There are n vertical lines drawn such that the two endpoints 
    of the ith line are (i, 0) and(i, height[i]).

    Find two lines that together with the x-axis form a container, 
    such that the container contains the most water.

    Return the maximum amount of water a container can store.

    Notice that you may not slant the container.
    */
    public class ContainerWithMostWater
    {
        public static int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        public static int Handle()
        {
            var maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                var currArea = Math.Min(height[left], height[right])*(right-left);
                maxArea = Math.Max(currArea, maxArea);

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
    }
}
