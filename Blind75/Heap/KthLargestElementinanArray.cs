using System.Collections.Generic;

namespace Blind75.Heap
{
    /*
    Given an integer array nums and an integer k, 
    return the kth largest element in the array.
    
    Note that it is the kth largest element in the sorted order, 
    not the kth distinct element.
    
    Can you solve it without sorting?   
    */
    public class KthLargestElementinanArray
    {
        int[] nums = { 3, 2, 1, 5, 6, 4 };
        int k = 2;
        //Ouput : 5
        public int Handle()
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            foreach (var num in nums)
            {
                if (pq.Count < k)
                    pq.Enqueue(num, num);
                else
                {
                    if (num <= pq.Peek())
                        continue;
                    pq.Dequeue();
                    pq.Enqueue(num, num);
                }
            }

            return pq.Dequeue();
        }
    }
}
