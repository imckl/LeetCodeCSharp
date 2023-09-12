namespace LeetCode;

public class _2605_MinNumber
{
    public int MinNumber(int[] nums1, int[] nums2)
    {
        var sharedNums = nums1.Intersect(nums2).ToArray();
        if (sharedNums.Any())
        {
            return sharedNums.Min();
        }

        var num1 = nums1.Min();
        var num2 = nums2.Min();

        return num1 > num2 ? num2 * 10 + num1 : num1 * 10 + num2;
    }

    public int MinNumber_02(int[] nums1, int[] nums2)
    {
        var sharedNums = nums1.Intersect(nums2).ToArray();

        if (sharedNums.Length > 0)
        {
            Array.Sort(sharedNums);
            return sharedNums[0];
        }

        Array.Sort(nums1);
        Array.Sort(nums2);

        var num1 = nums1[0];
        var num2 = nums2[0];

        return num1 > num2 ? num2 * 10 + num1 : num1 * 10 + num2;
    }
}
