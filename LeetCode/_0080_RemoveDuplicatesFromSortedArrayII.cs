namespace LeetCode;

public class _0080_RemoveDuplicatesFromSortedArrayII
{
    public int RemoveDuplicates_Reference(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.Length;
        }

        var slow = 2;
        var fast = 2;

        while (fast < nums.Length)
        {
            if (nums[slow - 2] != nums[fast])
            {
                nums[slow] = nums[fast];
                slow++;
            }

            fast++;
        }

        return slow;
    }

    public int RemoveDuplicates(int[] nums)
    {
        var duplicate = nums[0];

        var slow = 0;
        var fast = 1;

        var isDuplicated = false;

        while (fast < nums.Length)
        {
            if (nums[fast] == duplicate)
            {
                if (!isDuplicated)
                {
                    isDuplicated   = true;
                    nums[slow + 1] = duplicate;
                    slow++;
                }
            }
            else
            {
                if (isDuplicated)
                {
                    isDuplicated = false;
                }

                nums[slow + 1] = nums[fast];
                duplicate      = nums[fast];
                slow++;
            }

            fast++;
        }

        return slow + 1;
    }
}
