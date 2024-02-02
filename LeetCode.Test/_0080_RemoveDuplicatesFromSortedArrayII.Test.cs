namespace LeetCode.Test;

public class _0080_RemoveDuplicatesFromSortedArrayII_Test
{
    [Fact]
    public void Test1()
    {
        var nums = new[] { 1, 1, 1, 2, 2, 3 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 1, 1, 2, 2, 3 });
    }

    [Fact]
    public void Test2()
    {
        var nums = new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 0, 1, 1, 2, 3, 3 });
    }

    [Fact]
    public void TestSingle()
    {
        var nums = new[] { 0 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0 });
    }

    [Fact]
    public void TestTwoSame()
    {
        var nums = new[] { 0, 0 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 0 });
    }

    [Fact]
    public void TestAllSame()
    {
        var nums = new[] { 0, 0, 0, 0, 0, 0 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 0 });
    }

    [Fact]
    public void TestTwoDiff()
    {
        var nums = new[] { 0, 1 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 1 });
    }

    [Fact]
    public void TestTwoGroupDiff()
    {
        var nums = new[] { 0, 0, 1, 1 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 0, 1, 1 });
    }

    [Fact]
    public void TestAllLongerThanOne()
    {
        var nums = new[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 4, 4 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 });
    }

    [Fact]
    public void TestAllLongerThanTwo()
    {
        var nums = new[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4 };

        var solution = new _0080_RemoveDuplicatesFromSortedArrayII();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 });
    }
}
