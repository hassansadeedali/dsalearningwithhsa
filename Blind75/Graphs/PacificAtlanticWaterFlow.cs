using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Graphs
{
    public class PacificAtlanticWaterFlow
    {
        public static int[][] heights =
            {
                new int[]{1,2,2,3,5},
                new int[]{3,2,3,4,4},
                new int[]{2,4,5,3,1},
                new int[]{ 6, 7, 1, 4, 5 },
                new int[]{ 5,1,1,2,4 }
            };

        public static IList<IList<int>> Handle()
        {
            var result = new List<IList<int>>();

            int rows = heights.Length;
            int cols = heights[0].Length;

            //var pacific = new HashSet<int>();
            //var atlantic = new HashSet<int>();

            bool[,] isPacific = new bool[rows, cols];
            bool[,] isAtlantic = new bool[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                DFS(row, 0, heights, isPacific, heights[row][0]);
                DFS(row, cols, heights, isAtlantic, heights[row][cols]);
            }

            for (int col = 0; col < cols; col++)
            {
                DFS(0, col, heights, isPacific, heights[0][col]);
                DFS(rows, col, heights, isAtlantic, heights[0][col]);
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (isPacific[row, col] && isAtlantic[row, col])
                        result.Add(new List<int> { row, col });

                }
            }

            return result;
        }

        public static void DFS(int row, int col, int[][] heights, bool[,] visits, int prevHeight)
        {
            int m = heights.Length;
            int n = heights[0].Length;

            if (row < 0 || row >= m || col < 0 || col >= n || visits[row, col] || heights[row][col] < prevHeight)
                return;

            visits[row, col] = true;

            DFS(row - 1, col, heights, visits, heights[row][col]);
            DFS(row + 1, col, heights, visits, heights[row][col]);
            DFS(row, col - 1, heights, visits, heights[row][col]);
            DFS(row, col + 1, heights, visits, heights[row][col]);

        }
    }
}
