namespace LeetCode;

public class _0169_MajorityElement
{
    public int MajorityElement(int[] nums)
    {
        var candidate = nums[0];
        var count     = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }

            if (count == 0)
            {
                candidate = nums[i];
                count     = 1;
            }
        }

        return candidate;
    }
}
