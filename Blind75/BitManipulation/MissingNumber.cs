namespace Blind75.BitManipulation
{
    public class MissingNumber
    {
        /*
        Given an array nums containing n distinct numbers in the range 
        [0, n], return the only number in the range that is missing from 
        the array.
        */
        public int Handle(int[] nums)
        {
            int length = nums.Length;

            var sumOfFirstN = (length) * (length + 1) / 2;

            for (int i = 0; i < length; i++)
            {
                sumOfFirstN = sumOfFirstN - nums[i];
            }

            return sumOfFirstN;
        }
    }
}
