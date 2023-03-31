namespace AnswerLib
{
    // Easy Problems
    public class ArrayStudy
    {
        public int[] GetConcatenation(int[] nums)
        {
            return nums.Concat(nums).ToArray();
        }

        public int[] Shuffle(int[] nums, int n)
        {
            int[] ans = new int[nums.Length];
            int x = 0;
            int y = n;
            for (int i = 0; i < nums.Length - 2; i += 2)
            {
                ans[i] = nums[x++];
                ans[i + 1] = nums[y++];
            }
            return ans;
        }

        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            foreach (string op in operations)
            {
                if (op == "++X" || op == "X++")
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }

            return x;
        }

        public int[] LeftRighDifference(int[] nums) 
        {
            int[] answer = new int[nums.Length];
            int numsTotal = nums.Sum();

            int leftSum = 0;
            int rightSum = numsTotal - nums[0];

            for (int i = 0; i < nums.Length - 1; i++) 
            {
                answer[i] = Math.Abs(leftSum - rightSum);
                leftSum += nums[i];
                rightSum -= nums[i + 1];
            }

            answer[answer.Length - 1] = Math.Abs(numsTotal - nums[nums.Length - 1]);
            foreach(int num in answer) 
            {
                Console.Write(num + " ");
            }

            return answer;
        }

        public int NumIdenticalPairs(int[] nums)
        {
            int pairs = 0;
            IDictionary<int, int> prev = new Dictionary<int, int>();
            
            // loop through nums and add to counts
            foreach(int n in nums) 
            {
                if (!prev.ContainsKey(n)) 
                {
                    prev[n] = 1;
                }
                else 
                {
                    pairs += prev[n];
                    prev[n] = prev[n] + 1;
                }
            }

            return pairs;
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            // Get max value of candies
            int max = candies.Max();

            // Create a IList of bool and loop through candies
            List<bool> result = new List<bool>();
            foreach(int c in candies)
            {
                result.Add(c + extraCandies >= max);
            }
            return result;
        }
    }
    

    // Medium Problems
    class SubrectangleQueries
    {
        public int[][] rectangle;
        public SubrectangleQueries(int[][] rectangle)
        {
            this.rectangle = rectangle;
        }
        
        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for(int r = row1; r <= row2; r++)
            {
                for (int c = col1; c <= col2; c++)
                {
                    this.rectangle[r][c] = newValue;
                }
            }
        }

        public int GetValue(int row, int col) 
        {
            return this.rectangle[row][col];
        }
    }
}
