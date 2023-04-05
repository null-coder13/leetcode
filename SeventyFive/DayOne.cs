namespace SeventyFive;
public class DayOne
{
    // Running Sum of 1d Array
    public int[] RunningSum(int[] nums) 
    {
        for (int i = 1; i < nums.Length; i++) 
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }

    // 724. Find Pivot Index
    public int PivotIndex(int[] nums)
    {
        int right = nums.Sum() - nums[0];
        int left = 0;

        if (left == right) return 0;

        for (int i = 1; i < nums.Length - 1; i++)
        {
            // next iteration
            left += nums[i - 1];
            right -= nums[i];
            
            // checked
            if (left == right) {
                return i;
            }

        }

        return -1;
    }


}
