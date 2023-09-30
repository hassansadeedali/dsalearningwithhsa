using System.Collections.Generic;

namespace Blind75.Arrays
{
    /*
    Given two strings s and t, return true if t is an anagram of s, 
    and false otherwise.
    An Anagram is a word or phrase formed by rearranging the letters 
    of a different word or phrase, typically using all the original 
    letters exactly once.
    
    Example 1:

    Input: s = "anagram", t = "nagaram"
    Output: true
    */

    public class ValidAnagram
    {
        // read input
        public static readonly string s = "anagram";
        public static readonly string t = "nagaram";
        public static bool Handle()
        {
            if (s.Length != t.Length)
                return false;

            if (s == t)
                return true;

            var sCount = new Dictionary<char, int>();
            var tCount = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                sCount[s[i]] = sCount.ContainsKey(s[i]) ? 1 + sCount[s[i]] : 1;
                tCount[t[i]] = tCount.ContainsKey(t[i]) ? 1 + tCount[t[i]] : 1;
            }

            foreach(char c in sCount.Keys)
            {
                int tCounts = tCount.ContainsKey(c) ? tCount[c] : 0;
                if (sCount[c] != tCounts)
                    return false;
            }

            return true;
        }
    }
}
