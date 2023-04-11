namespace SeventyFive
{
    public class DayNine
    {
        // #733 Flood Fill
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int start = image[sr][sc];

            if (start == color) return image;

            Stack<(int, int)> locations = new();
            locations.Push((sr, sc));

            while (locations.Count != 0)
            {
                (int Row, int Col) = locations.Pop();

                image[Row][Col] = color;

                if (Row - 1 >= 0 && image[Row - 1][Col] == start) locations.Push((Row - 1, Col));
                if (Row + 1 < image.Length && image[Row + 1][Col] == start) locations.Push((Row + 1, Col));
                if (Col - 1 >= 0 && image[Row][Col - 1] == start) locations.Push((Row, Col - 1));
                if (Col + 1 < image[0].Length && image[Row][Col + 1] == start) locations.Push((Row, Col + 1));
            }

            return image;
        }

        // #200 Number of Islands
        public int NumIslands(char[][] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                        count += DFS(grid, i, j);
                }
            }
            return count;
        }

        public int DFS(char[][] grid, int x, int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length || grid[x][y] == '0') return 0;

            grid[x][y] = '0';

            DFS(grid, x + 1, y);
            DFS(grid, x - 1, y);
            DFS(grid, x, y + 1);
            DFS(grid, x, y - 1);

            return 1;
        }
    }

}
