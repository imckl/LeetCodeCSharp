namespace LeetCode;

public class _0228_SummaryRanges
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0)
        {
            return Array.Empty<string>();
        }

        if (nums.Length == 1)
        {
            return new[] { nums[0].ToString()! };
        }

        var results = new List<string>();

        var len = nums.Length;
        var i   = 1;

        var pair = new[] { nums[0], nums[0] };

        while (i < len)
        {
            if (nums[i] != nums[i - 1] + 1)
            {
                pair[1] = nums[i - 1];
                results.Add(pair[0] == pair[1] ? pair[0].ToString()! : $"{pair[0]}->{pair[1]}");
                pair = new[] { nums[i], nums[i] };
            }

            i++;
        }

        pair[1] = nums[len - 1];
        results.Add(pair[0] == pair[1] ? pair[0].ToString()! : $"{pair[0]}->{pair[1]}");

        return results;
    }

    public IList<string> SummaryRanges_02(int[] nums)
    {
        if (nums.Length == 0)
        {
            return Array.Empty<string>();
        }

        if (nums.Length == 1)
        {
            return new[] { nums[0].ToString()! };
        }

        var results = new List<string>();

        var len = nums.Length;
        var i   = 1;

        var pair = new[] { nums[0], nums[0] };

        while (i < len)
        {
            if (nums[i] == nums[i - 1] + 1)
            {
                pair[1] = nums[i];
            }
            else
            {
                results.Add(pair[0] == pair[1] ? pair[0].ToString()! : $"{pair[0]}->{pair[1]}");
                pair = new[] { nums[i], nums[i] };
            }

            i++;
        }

        results.Add(pair[0] == pair[1] ? pair[0].ToString()! : $"{pair[0]}->{pair[1]}");

        return results;
    }
}
