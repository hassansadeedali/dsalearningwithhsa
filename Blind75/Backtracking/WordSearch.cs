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
    }
}
