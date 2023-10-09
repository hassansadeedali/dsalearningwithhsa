using System.Collections.Generic;

namespace Blind75.Heap
{
    /*
    Design a class to find the kth largest element in a stream. 
    Note that it is the kth largest element in the sorted order, 
    not the kth distinct element.
    
    Implement KthLargest class:
    1. KthLargest(int k, int[] nums) Initializes the object with the integer k 
    and the stream of integers nums.
    2. int add(int val) Appends the integer val to the stream and returns the element 
    representing the kth largest element in the stream.
    */
    public class KthLargestElementinaStream
    {
        //Example 1:
        //
        //Input
        //["KthLargest", "add", "add", "add", "add", "add"]
        //[[3, [4, 5, 8, 2]], [3], [5], [10], [9], [4]]
        //Output
        //[null, 4, 5, 5, 8, 8]

        //Elements sorted in min to max
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int k;

        public KthLargestElementinaStream(int k, int[] nums)
        {
            this.k = k;

            foreach (var num in nums)
            {
                Add(num);
            }
        }

        public int Add(int val)
        {
            if (pq.Count < k)
                pq.Enqueue(val, val);

            else if (pq.Peek() < val)
            {
                pq.Dequeue();
                pq.Enqueue(val, val);
            }

            return pq.Peek();
        }

    }



}
