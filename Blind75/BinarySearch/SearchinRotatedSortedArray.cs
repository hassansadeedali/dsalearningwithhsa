namespace Blind75.BinarySearch
{
    /*
     * There is an integer array nums sorted in ascending order (with distinct values).
     
     * Prior to being passed to your function, nums is possibly 
     * rotated at an unknown pivot index k (1 <= k < nums.length) 
     * such that the resulting array is 
     * [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). 
     
     * For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 
     * and become [4,5,6,7,0,1,2].
     
     * Given the array nums after the possible rotation 
     * and an integer target, return the index of target 
     * if it is in nums, or -1 if it is not in nums.
     
     * You must write an algorithm with O(log n) runtime complexity.
    */
    public class SearchinRotatedSortedArray
    {
        /*
        Example 1:
        Input: nums = [4,5,6,7,0,1,2], target = 0
        Output: 4

        Example 2:      
        Input: nums = [4,5,6,7,0,1,2], target = 3
        Output: -1

        Example 3:    
        Input: nums = [1], target = 0
        Output: -1
        */

        public static readonly int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
        public static int target = 0;

        public static int Handle()
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] == target)
                    return mid;

                //Left sorted portion
                if (nums[left] <= nums[mid]) 
                {
                    //Search on right
                    if (target > nums[mid])
                        left = mid + 1;
                    else if (target < nums[left])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                //Right sorted portion
                else
                {
                    //Search on left
                    if (target < nums[mid])
                        right = mid - 1;
                    else if (target > nums[right])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }

            }

            return -1;
        }
    }
}
