using System.Text;

namespace Blind75.Two_Pointers
{
    /*
    You are given two strings word1 and word2. Merge the strings by 
    adding letters in alternating order, starting with word1. 
    If a string is longer than the other, append the additional letters 
    onto the end of the merged string.

    Return the merged string.

    Example 1:
    
    Input: word1 = "abc", word2 = "pqr"
    Output: "apbqcr"
    */
    public class MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            int p1 = 0;
            int p2 = 0;
            var result = new StringBuilder();

            while (p1 < word1.Length && p2 < word2.Length)
            {
                result.Append(word1[p1]);
                result.Append(word2[p2]);
                p1++;
                p2++;
            }

            while (p1 != word1.Length)
            {
                result.Append(word1[p1]);
                p1++;
            }

            while (p2 != word2.Length)
            {
                result.Append(word2[p2]);
                p2++;
            }

            return result.ToString();
        }
    }
}
