using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Intervals
{
    /*
    Given an array of intervals where intervals[i] = [starti, endi], 
    merge all overlapping intervals, and return an array of the 
    non-overlapping intervals that cover all the intervals in the input.
    */
    public class MergeIntervals
    {
        public static int[][] intervals = { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
        // Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
        // Output: [[1,6],[8,10],[15,18]]

        public static int[][] Handle()
        {
            //Sort the given array by giving preference to start interval
            var sortedInterval = intervals.Clone() as int[][];
            Array.Sort(sortedInterval, (a, b) => a[0] - b[0]);

            var mergedInterval = new List<int[]>();

            //Consider the first interval and add to the result array
            var lastInterval = sortedInterval[0];
            mergedInterval.Add(lastInterval);

            for(int i = 1; i < sortedInterval.Length; i++)
            {
                var current = sortedInterval[i];
                var lastIntervalEnd = lastInterval[1];
                var currentStart = current[0];
                var currentEnd = current[1];

                if (lastIntervalEnd >= currentStart)
                {
                    //If current start is lesser than last interval end, then take max of both end
                    lastInterval[1] = Math.Max(lastIntervalEnd, currentEnd);
                }
                else
                {
                    //Else add the interval to the result array
                    lastInterval = current;
                    mergedInterval.Add(lastInterval);
                }
            }

            return mergedInterval.ToArray();
        }
    }
}
