using System.Collections.Generic;

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
    }
}
