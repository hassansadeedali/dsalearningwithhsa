using System.Collections.Generic;
using System.Linq;

namespace Blind75.Arrays
{
    /*
    Given an array of strings strs, group the anagrams together. 
    You can return the answer in any order.
    
    An Anagram is a word or phrase formed by rearranging the letters 
    of a different word or phrase, typically using all the original letters exactly once.
    */
    public static class GroupAnagrams
    {
        public static string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        // Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
        public static IList<IList<string>> Handle()
        {
            var groups = new Dictionary<string, IList<string>>();

            foreach(string s in strs)
            {
                char[] hash = new char[26];
                foreach(char ch in s)
                {
                    hash[ch - 'a']++;
                }

                string key = new string(hash);

                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }

                groups[key].Add(s);

            }

            return groups.Values.ToList();
        }
    }
}
