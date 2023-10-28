using System;
using System.Collections.Generic;

namespace Blind75.Backtracking
{
    /*
     * Given an m x n grid of characters board and a string word, 
     * return true if word exists in the grid.
     
     * The word can be constructed from letters of sequentially adjacent cells, 
     * where adjacent cells are horizontally or vertically neighboring. 
     * The same letter cell may not be used more than once.
     */
    public class WordSearch
    {
        public static char[][] board =
        {
            new char[]{'A', 'B', 'C', 'E'},
            new char[]{'S', 'F', 'C', 'S'},
            new char[]{'A', 'D', 'E', 'E'}
        };

        public static string word = "ABCCED";
        //Output : true

        public static bool Handle()
        {
            var rows = board.Length;
            var cols = board[0].Length;
            var visited = new bool[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (board[row][col] == word[0] && Search(row, col, 0, word, board, visited))
                        return true;
                }
            }
            return false;
        }

        public static bool Search(int row, int col, int index, string word, char[][] board, bool[,] visited)
        {
            var rows = board.Length;
            var cols = board[0].Length;

            if (index == word.Length)
                return true;

            if (row < 0 || row >= rows || col < 0 || col >= cols || visited[row, col])
                return false;

            if (word[index] != board[row][col])
                return false;

            visited[row, col] = true;

            var result =
            Search(row - 1, col, index + 1, word, board, visited) ||
            Search(row + 1, col, index + 1, word, board, visited) ||
            Search(row, col - 1, index + 1, word, board, visited) ||
            Search(row, col + 1, index + 1, word, board, visited);

            visited[row, col] = false;

            return result;
        }

        //Max Area of Island
        /*
        You are given an m x n binary matrix grid. An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.

        The area of an island is the number of cells with a value 1 in the island.

        Return the maximum area of an island in grid. If there is no island, return 0.
        */
        public int MaxAreaOfIsland(int[][] grid)
        {
            var visited = new HashSet<string>();
            int maxArea = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    var area = Explore(grid, i, j, visited);
                    maxArea = Math.Max(area, maxArea);
                }
            }

            return maxArea;
        }

        private int Explore(int[][] grid, int r, int c, HashSet<string> visited)
        {
            if (!(0 <= r && r < grid.Length))
                return 0;

            if (!(0 <= c && c < grid[0].Length))
                return 0;

            if (grid[r][c] == 0)
                return 0;

            var pos = r.ToString() + ',' + c.ToString();

            if (visited.Contains(pos))
                return 0;

            visited.Add(pos);

            return 1 + Explore(grid, r - 1, c, visited)
            + Explore(grid, r + 1, c, visited)
            + Explore(grid, r, c - 1, visited)
            + Explore(grid, r, c + 1, visited);

        }
    }
}
