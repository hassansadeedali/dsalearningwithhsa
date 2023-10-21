using System.Collections.Generic;
using System.Linq;

namespace Blind75.Heap
{
    /*
    Given an array of points where points[i] = [xi, yi] 
    represents a point on the X-Y plane and an integer k, 
    return the k closest points to the origin (0, 0).
    
    The distance between two points on the X-Y plane 
    is the Euclidean distance (i.e., √(x1 - x2)2 + (y1 - y2)2).
    
    You may return the answer in any order. The answer is guaranteed 
    to be unique (except for the order that it is in).
    */
    public class KClosestPointstoOrigin
    {
        public static int[][] points = { new int[] { 1, 3 }, new int[] { -2, 2 } };
        public static int k = 1;
        //Input: points = [[1,3],[-2,2]], k = 1
        //Output: [[-2,2]]

        public static int[][] Handle()
        {
            int[][] result = new int[k][];

            var pair = points.Select
            (
                point =>
                {
                    long x = point[0];
                    long y = point[1];
                    return (point, x * x + y * y);
                }
            );

            var pq = new PriorityQueue<int[],long>(pair);

            for (int i = 0; i < k; i++)
            {
                result[i] = pq.Dequeue();
            }

            return result;
        }
    }
}
