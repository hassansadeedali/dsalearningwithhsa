using System;
using System.Collections.Generic;

namespace Blind75.Sliding_Window
{
    /*
    Given a string s, find the length of the longest substring
    without repeating characters.
    */
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static string s = "abcabcbb";
        //Input: s = "abcabcbb"
        //Output: 3
        //Explanation: The answer is "abc", with the length of 3.

        public static int Handle()
        {
            int left = 0;
            int right = 0;
            int max = 0;
            HashSet<int> chars = new();

            //Iterate until right has reached the length
            while (right < s.Length)
            {
                var currChar = s[right];
                if (chars.Contains(currChar))
                {
                    //If Hashset has the character, then remove it from hashet and move the left pointer
                    chars.Remove(s[left]);
                    left++;
                }
                else
                {
                    //If Hashset doesnt have the character, then add to hashet and move the right pointer
                    chars.Add(currChar);
                    max = Math.Max(max, right - left + 1);
                    right++;
                }

            }

            return max;
        }
    }
}
