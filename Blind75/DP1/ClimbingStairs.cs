using System;
using System.Collections.Generic;

namespace Blind75.DP1
{
    public class ClimbingStairs
    {
        /*
        You are climbing a staircase. It takes n steps to reach the top.

        Each time you can either climb 1 or 2 steps. 
        In how many distinct ways can you climb to the top?
        */

        public int ClimbStairs(int n)
        {

            var dict = new Dictionary<int, int>();

            if (n <= 2)
            {
                return n;
            }

            dict[0] = 0;
            dict[1] = 1;
            dict[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dict[i] = dict[i - 1] + dict[i - 2];
            }

            return dict[n];
        }


        //Min Cost Climbing Stairs
        /*
        You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.

        You can either start from the step with index 0, or the step with index 1.

        Return the minimum cost to reach the top of the floor.
        */

        public int MinCostClimbingStairs(int[] cost)
        {
            int length = cost.Length;

            //Add zero to the last index
            //cost[length] = 0;

            //Iterate leaving last two indexes
            for (int i = cost.Length - 3; i >= 0; i--)
            {
                cost[i] = Math.Min(cost[i] + cost[i + 1], cost[i] + cost[i + 2]);
            }

            return Math.Min(cost[0], cost[1]);
        }
    }
}
