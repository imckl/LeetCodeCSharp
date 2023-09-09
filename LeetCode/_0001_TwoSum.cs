namespace LeetCode;

public class _0001_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numsByNums = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (numsByNums.TryGetValue(target - nums[i], out var idx))
            {
                return new[] { idx, i };
            }

            numsByNums.TryAdd(nums[i], i);
        }

        return Array.Empty<int>();
    }
}
