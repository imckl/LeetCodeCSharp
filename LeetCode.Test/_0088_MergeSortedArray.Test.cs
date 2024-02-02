namespace LeetCode.Test;

public class _0088_MergeSortedArray_Test
{
    [Fact]
    public void Test1()
    {
        var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
        var m     = 3;

        var nums2 = new[] { 2, 5, 6 };
        var n     = 3;

        var solution = new _0088_MergeSortedArray();
        solution.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }

    [Fact]
    public void Test2()
    {
        var nums1 = new[] { 1 };
        var m     = 1;

        var nums2 = Array.Empty<int>();
        var n     = 0;

        var solution = new _0088_MergeSortedArray();
        solution.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 1 }, nums1);
    }

    [Fact]
    public void Test3()
    {
        var nums1 = new int[1];
        var m     = 0;

        var nums2 = new[] { 1 };
        var n     = 1;

        var solution = new _0088_MergeSortedArray();
        solution.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 1 }, nums1);
    }

    [Fact]
    public void Test4()
    {
        var nums1 = new[] { -100, -99, -99, 0, 1, 2, 0, 0, 0 };
        var m     = 6;

        var nums2 = new[] { -101, 5, 6 };
        var n     = 3;

        var solution = new _0088_MergeSortedArray();
        solution.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { -101, -100, -99, -99, 0, 1, 2, 5, 6 }, nums1);
    }
}
