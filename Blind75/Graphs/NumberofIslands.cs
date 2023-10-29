using System;
using System.Collections.Generic;

namespace Blind75.Graphs
{
    public class NumberofIslands
    {
        //Number of Islands
        /*
        Given an m x n 2D binary grid grid which represents a map of '1's (land) 
        and '0's (water), return the number of islands.

        An island is surrounded by water and is formed by connecting adjacent 
        lands horizontally or vertically. You may assume all four edges of the 
        grid are all surrounded by water.
        */
        public static char[][] grid =
            {
                new char[]{'1', '1', '0', '0', '0'},
                new char[]{'1', '1', '0', '0', '0'},
                new char[]{'0', '0', '1', '0', '0'},
                new char[]{'0', '0', '0', '1', '1'}
            };
        public static int Handle()
        {
            var visited = new HashSet<string>();
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (Explore(grid, i, j, visited))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        private static bool Explore(char[][] grid, int r, int c, HashSet<string> visited)
        {
            if (!(0 <= r && r < grid.Length))
                return false;

            if (!(0 <= c && c < grid[0].Length))
                return false;

            if (grid[r][c] == '0')
                return false;

            var pos = r.ToString() + ',' + c.ToString();

            if (visited.Contains(pos))
                return false;

            visited.Add(pos);

            Explore(grid, r - 1, c, visited);
            Explore(grid, r + 1, c, visited);
            Explore(grid, r, c - 1, visited);
            Explore(grid, r, c + 1, visited);

            return true;
        }


        //Island Perimeter
        /*
        You are given row x col grid representing a map where grid[i][j] = 1 
        represents land and grid[i][j] = 0 represents water.

        Grid cells are connected horizontally/vertically (not diagonally). 
        The grid is completely surrounded by water, and there is exactly one 
        island (i.e., one or more connected land cells).

        The island doesn't have "lakes", meaning the water inside isn't 
        connected to the water around the island. One cell is a square with 
        side length 1. The grid is rectangular, width and height don't exceed 
        100. Determine the perimeter of the island.
        */
        public int IslandPerimeter(int[][] grid)
        {
            int res = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        res += 4;

                        //Check Top
                        if (row > 0 && grid[row - 1][col] == 1)
                            res -= 2;

                        //Check left
                        if (col > 0 && grid[row][col - 1] == 1)
                            res -= 2;
                    }
                }
            }
            return res;
        }

        //Max Area of Island
        /*
        You are given an m x n binary matrix grid. An island is a group of 
        1's (representing land) connected 4-directionally (horizontal or 
        vertical.) You may assume all four edges of the grid are surrounded by 
        water.

        The area of an island is the number of cells with a value 1 in the 
        island.

        Return the maximum area of an island in grid. If there is no island, 
        return 0.
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