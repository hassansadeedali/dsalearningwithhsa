using System.Collections.Generic;

namespace Blind75.Graphs
{
    public class NumberofIslands
    {
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
    }
}
