namespace LeetCode;

public class _0088_MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var p1 = 0;
        var p2 = 0;

        var i = 0;

        var nums3 = new int[m + n];

        while (i < m + n && p1 < m && p2 < n)
        {
            if (nums1[p1] < nums2[p2])
            {
                nums3[i] = nums1[p1];
                p1++;
            }
            else
            {
                nums3[i] = nums2[p2];
                p2++;
            }

            i++;
        }

        while (p1 < m)
        {
            nums3[i] = nums1[p1];
            p1++;
            i++;
        }

        while (p2 < n)
        {
            nums3[i] = nums2[p2];
            p2++;
            i++;
        }

        for (var j = 0; j < nums3.Length; j++)
        {
            nums1[j] = nums3[j];
        }
    }
}
