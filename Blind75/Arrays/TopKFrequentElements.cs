using System.Collections.Generic;

namespace Blind75.Arrays
{
    /*
     * Given an integer array nums and an integer k, 
     * return the k most frequent elements. 
     * You may return the answer in any order.
     */
    public static class TopKFrequentElements
    {
        // read input
        public static readonly int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
        public static readonly int k = 2;
        //Output: [1,2]
        public static int[] Handle()
        {
            int[] res = new int[k];
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]]++;
                else
                    dict[nums[i]] = 1;
            }

            //No support for PriorityQueue in .Net 5

            //Elements sorted in min to max of frequency
            //While dequeue, minimum frequency will be removed(Element from index 0)
            var pq = new PriorityQueue<int, int>();

            foreach(var item in dict)
            {
                pq.Enqueue(item.Key, item.Value);

                if (pq.Count > k)
                    pq.Dequeue();
            }

            for (int i=0;i< k; i++)
            {
                res[i] = pq.Dequeue();
            }

            return res;
        }
    }
}
