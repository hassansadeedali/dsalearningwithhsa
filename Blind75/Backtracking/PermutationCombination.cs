using System.Collections.Generic;
using System.Linq;

namespace Blind75.Backtracking
{
    public class PermutationCombination
    {
        //Combination
        /*
        Given two integers n and k, return all possible combinations of k 
        numbers chosen from the range [1, n].

        You may return the answer in any order.

        Example 1:
        
        Input: n = 4, k = 2
        Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
        Explanation: There are 4 choose 2 = 6 total combinations.
        Note that combinations are unordered, i.e., [1,2] and [2,1] are 
        considered to be the same combination.
        */

        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> Combine(int n, int k)
        {
            BackTrack(new List<int>(), k, 1, n);
            return result;
        }

        public void BackTrack(List<int> combination, int k, int start, int n)
        {
            if (combination.Count == k)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                combination.Add(i);
                BackTrack(combination, k, i + 1, n);
                combination.Remove(combination.Last());
            }
        }

        //Permutation
        /*
        Given an array nums of distinct integers, return all the possible 
        permutations. You can return the answer in any order.

        Example 1:
        
        Input: nums = [1,2,3]
        Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
        */

        public IList<IList<int>> Permute(int[] nums)
        {
            BackTrack(new List<int>(), nums);
            return result;
        }

        public void BackTrack(List<int> combination, int[] nums)
        {
            if (combination.Count == nums.Length)
            {
                result.Add(new List<int>(combination));
                return;
            }

            foreach (var num in nums)
            {
                if (combination.Contains(num))
                    continue;
                combination.Add(num);
                BackTrack(combination, nums);
                combination.Remove(combination.Last());
            }

        }
    }
}
