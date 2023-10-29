using System;
using System.Collections.Generic;
using System.Linq;

namespace Blind75.Backtracking
{
    /*
    Given an array of distinct integers candidates and a target integer target, 
    return a list of all unique combinations of candidates where the chosen 
    numbers sum to target. You may return the combinations in any order.
    
    The same number may be chosen from candidates an unlimited number of times. 
    Two combinations are unique if the frequency of at least one of the chosen 
    numbers is different.
    
    The test cases are generated such that the number of unique combinations that 
    sum up to target is less than 150 combinations for the given input.
    */
    public class CombinationSum
    {
        public static readonly int[] candidates = new int[] { 2, 3, 6, 7 };
        public static int target = 7;
        public static List<IList<int>> result = new();
        //Output: [[2,2,3],[7]]

        public static IList<IList<int>> Handle()
        {
            DFS(0, candidates, target, new List<int>());
            return result;
        }

        private static void DFS(int index, int[] candidates, int target, List<int> combination)
        {
            if(index>=candidates.Length)
            {
                return;
            }

            if (target == 0)
            {
                //Add the result as new List to avoid reference issue
                result.Add(new List<int>(combination));                
            }

            var currElement = candidates[index];
            if (currElement <= target)
            {
                combination.Add(currElement);
                DFS(index, candidates, target- currElement, combination);

                //Remove last element for next iteration
                combination.Remove(combination.Count - 1);
            }

            DFS(index+1, candidates, target, combination);

        }


        /*
        private static void DFS(int index, List<int> combination, int sum, int[] candidates, int target)
        {
            if (sum == target)
            {
                result.Add(new List<int>(combination));
                return;
            }

            if (sum > target || index >= candidates.Length)
                return;

            combination.Add(candidates[index]);
            DFS(index, combination, sum + candidates[index], candidates, target);

            combination.Remove(combination.Last());

            DFS(index + 1, combination, sum, candidates, target);

        }
        */

        /*
        Given a collection of candidate numbers (candidates) and a target number 
        (target), find all unique combinations in candidates where the candidate 
        numbers sum to target.

        Each number in candidates may only be used once in the combination.
        
        Note: The solution set must not contain duplicate combinations.

        Example 1:
        
        Input: candidates = [10,1,2,7,6,1,5], target = 8
        Output: 
        [
        [1,1,6],
        [1,2,5],
        [1,7],
        [2,6]
        ]
        */

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            DFS(0, new List<int>(), 0, candidates, target);
            return result;
        }

        private void DFS(int index, List<int> combination, int sum, int[] candidates, int target)
        {
            if (sum == target)
            {
                result.Add(new List<int>(combination));
                return;
            }

            if (sum > target || index >= candidates.Length)
                return;

            combination.Add(candidates[index]);
            DFS(index + 1, combination, sum + candidates[index], candidates, target);

            combination.Remove(combination.Last());
            while (index + 1 < candidates.Length && candidates[index] == candidates[index + 1])
                index += 1;

            DFS(index + 1, combination, sum, candidates, target);

        }
    }
}
