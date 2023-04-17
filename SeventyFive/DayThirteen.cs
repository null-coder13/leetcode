namespace SeventyFive
{
    public class DayThirteen
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, List<int>> numMap = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numMap.ContainsKey(nums[i]))
                {
                    numMap[nums[i]].Add(i);
                }
                else
                {
                    numMap.Add(nums[i], new List<int> { i });
                }

            }

            int[] answer = new int[2];

            foreach (KeyValuePair<int, List<int>> kv in numMap)
            {
                int key = kv.Key;

                int result = target - key;

                if (numMap.ContainsKey(result) && result == key)
                {
                    if (numMap[result].Count > 1)
                    {
                        answer[0] = numMap[result][0];
                        answer[1] = numMap[result][1];
                    }
                }
                else if (numMap.ContainsKey(result))
                {
                    answer[0] = kv.Value[0];
                    answer[1] = numMap[result][0];
                }
            }

            return answer;
        }

    }

}
