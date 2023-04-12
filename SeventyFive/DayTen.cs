namespace SeventyFive
{
    public class DayTen
    {

        // # 509. Fibonacci Number
        public int Fib(int n)
        {
            if (n == 1) return 1;
            if (n == 0) return 0;

            int[] cached = new int[n + 1];

            cached[0] = 0;
            cached[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                cached[i] = cached[i - 2] + cached[i - 1];
            }
            return cached[n];
        }

        // # Climbing Stairs
        public int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int[] cached = new int[n + 1];
            cached[0] = 0;
            cached[1] = 1;
            cached[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                cached[i] = cached[i - 1] + cached[i - 2];
            }

            return cached[n];
        }

    }

}
