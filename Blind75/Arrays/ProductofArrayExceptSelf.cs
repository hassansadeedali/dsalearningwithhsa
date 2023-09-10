namespace Blind75.Arrays
{
    public static class ProductofArrayExceptSelf
    {
        // read input
        public static readonly int[] nums = new int[] { 1, 2, 1 };
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
