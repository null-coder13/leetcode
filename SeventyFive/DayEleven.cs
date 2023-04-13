namespace SeventyFive
{
    public class DayEleven
    {
        // # 746. Min Cost Climbing Stairs
        public int MinCostClimbingStairs(int[] cost)
        {

            for (int i = cost.Length - 3; i >= 0; i--)
            {
                if (cost[i] + cost[i + 1] < cost[i] + cost[i + 2])
                {
                    cost[i] = cost[i] + cost[i + 1];
                }
                else
                {
                    cost[i] = cost[i] + cost[i + 2];
                }
            }
            return cost[0] < cost[1] ? cost[0] : cost[1];
        }

        // # 62. Unique Paths
        public int UniquePaths(int m, int n)
        {
            int[,] grid = new int[m, n];
            grid[m - 1, n - 1] = 1;

            for (int r = m - 1; r >= 0; r--)
            {
                for (int c = n - 1; c >= 0; c--)
                {
                    if (r == m - 1 && c == n - 1) continue;
                    if (r + 1 > m - 1)
                    {
                        grid[r, c] = 1;
                    }
                    else if (c + 1 > n - 1)
                    {
                        grid[r, c] = 1;
                    }
                    else
                    {
                        grid[r, c] = grid[r + 1, c] + grid[r, c + 1];
                    }
                }
            }
            return grid[0, 0];
        }
    }

}
