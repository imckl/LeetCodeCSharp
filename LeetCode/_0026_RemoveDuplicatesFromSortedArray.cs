namespace LeetCode;

public class _0026_RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        var duplicate = nums[0];

        var left = 0;

        for (var right = 1; right < nums.Length; right++)
        {
            if (nums[right] != duplicate)
            {
                nums[left + 1] = nums[right];
                duplicate      = nums[right];
                left++;
            }
        }

        return left + 1;
    }
}
