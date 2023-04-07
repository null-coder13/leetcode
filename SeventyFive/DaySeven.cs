namespace SeventyFive
{
    public class DaySeven
    {
        // #704. Binary Search
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }

        // #278. First Bad Version
        public int FirstBadVersion(int n)
        {
            if (n == 1 && IsBadVersion(n)) return n;

            int left = 0, right = n;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);
                bool isBad = IsBadVersion(mid);
                if (!isBad && IsBadVersion(mid + 1))
                {
                    return mid;

                }
                else if (isBad)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return 0;
        }

        // Provided by leetcode
        public bool IsBadVersion(int n)
        {
            return n >= 4;
        }

    }

}
