namespace LeetCode.Test;

public class _0026_RemoveDuplicatesFromSortedArray_Test
{
    [Fact]
    public void Test1()
    {
        var nums = new[] { 1, 1, 2 };

        var solution = new _0026_RemoveDuplicatesFromSortedArray();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 1, 2 });
    }

    [Fact]
    public void Test2()
    {
        var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        var solution = new _0026_RemoveDuplicatesFromSortedArray();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 1, 2, 3, 4 });
    }

    [Fact]
    public void TestSingle()
    {
        var nums = new[] { 0 };

        var solution = new _0026_RemoveDuplicatesFromSortedArray();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0 });
    }

    [Fact]
    public void TestAllSame()
    {
        var nums = new[] { 0, 0, 0, 0, 0 };

        var solution = new _0026_RemoveDuplicatesFromSortedArray();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0 });
    }

    [Fact]
    public void TestSequence()
    {
        var nums = new[] { 0, 1, 2, 3, 4 };

        var solution = new _0026_RemoveDuplicatesFromSortedArray();
        var length   = solution.RemoveDuplicates(nums);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equal(results, new[] { 0, 1, 2, 3, 4 });
    }
}
