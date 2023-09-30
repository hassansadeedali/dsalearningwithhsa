namespace Blind75.Arrays
{
    /*
     * Given an integer array nums, return an array answer 
     * such that answer[i] is equal to the product of all 
     * the elements of nums except nums[i].
      
     * The product of any prefix or suffix of nums is 
     * guaranteed to fit in a 32-bit integer.
     *
     * You must write an algorithm that runs in O(n) time 
     * and without using the division operation.
     */
    public static class ProductofArrayExceptSelf
    {
        // read input
        public static readonly int[] nums = new int[] { 1, 2, 3, 4 };
        //Output: [24,12,8,6]
        public static int[] Handle()
        {
            int prefix = 1;
            int postfix = 1;
            int[] result = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }

            return result;
        }
    }
}
