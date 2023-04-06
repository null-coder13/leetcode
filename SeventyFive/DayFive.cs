namespace SeventyFive
{
    public class DayFive
    {
        // #121. Best Time to Buy and Sell Stock
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;
            int min = int.MaxValue;
            int max_profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if (prices[i] - min > max_profit)
                {
                    max_profit = prices[i] - min;
                }
            }
            return max_profit;
        }

        // #409. Longest Palindrome
        public int LongestPalindrome(string s)
        {
            Dictionary<char, int> charMap = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!charMap.ContainsKey(s[i]))
                {
                    charMap.Add(s[i], 1);
                }
                else
                {
                    charMap[s[i]] += 1;
                }
            }

            int count = 0;
            bool hasOdd = false;
            foreach (KeyValuePair<char, int> p in charMap)
            {
                if (p.Value % 2 == 0)
                {
                    count += p.Value;
                } else {
                    count += p.Value - 1;
                    hasOdd = true;
                }
            }

            if (hasOdd) count++;

            return count;
        }
    }

}
