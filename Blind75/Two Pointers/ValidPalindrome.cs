namespace Blind75.Two_Pointers
{
    /*
     * A phrase is a palindrome if, after converting all 
     * uppercase letters into lowercase letters and 
     * removing all non-alphanumeric characters, 
     * it reads the same forward and backward. 
     * Alphanumeric characters include letters and numbers.
     *
     * Given a string s, return true if it is a palindrome, or false otherwise.
     */
    public static class ValidPalindrome
    {
        public static readonly string input = "A man, a plan, a canal: Panama";
        public static bool Handle()
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }
            var newInput = input.ToLower();

            int i = 0;
            int j = newInput.Length-1;

            while (i<j)
            {
                while(i<j && !char.IsLetter(newInput[i]))
                {
                    i++;
                }
                while (i<j && !char.IsLetter(newInput[j]))
                {
                    j--;
                }
                if (i<j && newInput[i].Equals(newInput[j]))
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
