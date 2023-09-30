using System;

namespace Blind75.Sliding_Window
{
    /*
    You are given a string s and an integer k. 
    You can choose any character of the string 
    and change it to any other uppercase English character. 
    You can perform this operation at most k times.
    
    Return the length of the longest substring containing 
    the same letter you can get after performing the above operations.
    */
    public class LongestRepeatingCharacterReplacement
    {
        public static string s = "AABABBA";
        public static int k = 1;

        //Input: s = "AABABBA", k = 1
        //Output: 4
        //Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
        //The substring "BBBB" has the longest repeating letters, which is 4.
        //There may exists other ways to achive this answer too.

        public static int Handle()
        {
            int left = 0;
            int maxLength = 0;
            int mostFrequentLetterCount = 0; // Count of most frequent letter in the window
            int[] charCounts = new int[26]; // Counts per letter

            for(int right=0; right < s.Length; right++)
            {
                charCounts[s[right] - 'A']++;
                mostFrequentLetterCount = Math.Max(mostFrequentLetterCount, charCounts[s[right] - 'A']);

                int lettersToChange = (right - left + 1) - mostFrequentLetterCount;

                //Out of the window
                if (lettersToChange > k)
                {
                    charCounts[s[left] - 'A']--;
                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
