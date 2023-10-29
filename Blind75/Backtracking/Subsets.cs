using System;
using System.Collections.Generic;

namespace Blind75.Backtracking
{
    public class Subsets
    {
        /*
        Given an integer array nums of unique elements, return all possible 
        subsets (the power set).
        
        The solution set must not contain duplicate subsets. Return the 
        solution in any order.

        Example 1:
        
        Input: nums = [1,2,3]
        Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
        */

        private List<int> subset = new List<int>();
        private List<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> Subsets1(int[] nums)
        {
            BackTrack(nums, 0);
            return result;
        }
        private void BackTrack(int[] nums, int index)
        {
            if (index >= nums.Length)
            {
                result.Add(new List<int>(subset));
                return;
            }

            //Decide to add
            subset.Add(nums[index]);
            BackTrack(nums, index + 1);

            //Decide not to add
            subset.Remove(nums[index]);
            BackTrack(nums, index + 1);

        }

        /*
        Given an integer array nums that may contain duplicates, return all 
        possible subsets (the power set).
        
        The solution set must not contain duplicate subsets. Return the solution 
        in any order.

        Example 1:
        Input: nums = [1,2,2]
        Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
        */

        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            BackTrack2(nums, 0);
            return result;
        }

        private void BackTrack2(int[] nums, int index)
        {

            if (index >= nums.Length)
            {
                result.Add(new List<int>(subset));
                return;
            }

            //Subsets that include nums[i]
            subset.Add(nums[index]);
            BackTrack(nums, index + 1);
            subset.Remove(nums[index]);

            //Subsets that dont include nums[i]
            while (index + 1 < nums.Length && nums[index] == nums[index + 1])
            {
                index++;
            }

            BackTrack(nums, index + 1);

        }
    }
}
