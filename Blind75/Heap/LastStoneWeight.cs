using System.Collections.Generic;

namespace Blind75.Heap
{
    /*
    You are given an array of integers stones where stones[i] is the weight of the ith stone.
    
    We are playing a game with the stones. On each turn, we choose the heaviest 
    two stones and smash them together. Suppose the heaviest two stones have weights 
    x and y with x <= y. The result of this smash is:
    
    If x == y, both stones are destroyed, and
    If x != y, the stone of weight x is destroyed, and the stone of weight y has new weight y - x.
    
    At the end of the game, there is at most one stone left.
    
    Return the weight of the last remaining stone. If there are no stones left, return 0.
     */
    public class LastStoneWeight
    {
        private static int[] stones = { 2, 7, 4, 1, 8, 1 };
        //Output: 1
        //Explanation: 
        //We combine 7 and 8 to get 1 so the array converts to[2, 4, 1, 1, 1] then,
        //we combine 2 and 4 to get 2 so the array converts to[2, 1, 1, 1] then,
        //we combine 2 and 1 to get 1 so the array converts to[1, 1, 1] then,
        //we combine 1 and 1 to get 0 so the array converts to[1] then that's the value of the last stone.

        private static PriorityQueue<int, int> pq;

        //This method is required since we have to sort max to min
        public class MaxHeapComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y - x;
            }
        }
        public static int Handle()
        {
            pq = new PriorityQueue<int, int>(new MaxHeapComparer());
            //var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            AddStones(stones);
            ComputeLastStoneWeight();
            return pq.Count == 0 ? 0 : pq.Dequeue();
        }

        private static void AddStones(int[] stones)
        {
            foreach (var stone in stones)
            {
                pq.Enqueue(stone, stone);
            }
        }

        private static void ComputeLastStoneWeight()
        {
            //While dequeue, top weight will be removed(Element from index 0)
            while (pq.Count > 1)
            {
                var x = pq.Dequeue();
                var y = pq.Dequeue();

                if (x != y)
                {
                    var diff = x - y;
                    pq.Enqueue(diff, diff);
                }
            }
        }

    }
}
