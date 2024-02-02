namespace LeetCode.Test;

public class _0027_RemoveElement_Test
{
    [Fact]
    public void Test1()
    {
        var nums = new[] { 3, 2, 2, 3 };
        var val  = 3;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, new[] { 2, 2 });
    }

    [Fact]
    public void Test2()
    {
        var nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        var val  = 2;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, new[] { 0, 1, 3, 0, 4 });
    }

    [Fact]
    public void Test3()
    {
        var nums = new[] { 0, 0, 1, 0, 0 };
        var val  = 0;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, new[] { 1 });
    }

    [Fact]
    public void Test4()
    {
        var nums = new[] { 1, 0, 0, 0, 0 };
        var val  = 0;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, new[] { 1 });
    }

    [Fact]
    public void Test5()
    {
        var nums = new[] { 0, 0, 0, 0, 1 };
        var val  = 0;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, new[] { 1 });
    }

    [Fact]
    public void TestAllIsVal()
    {
        var nums = new[] { 0, 0, 0, 0, 0 };
        var val  = 0;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, Array.Empty<int>());
    }

    [Fact]
    public void TestAllIsNotVal()
    {
        var nums = new[] { 1, 1, 1, 1, 1 };
        var val  = 0;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, new[] { 1, 1, 1, 1, 1 });
    }

    [Fact]
    public void TestSingleIsNotVal()
    {
        var nums = new[] { 2 };
        var val  = 3;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, new[] { 2 });
    }

    [Fact]
    public void TestSingleIsVal()
    {
        var nums = new[] { 2 };
        var val  = 2;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, Array.Empty<int>());
    }
    
    [Fact]
    public void TestEmpty()
    {
        var nums = Array.Empty<int>();
        var val  = 2;

        var solution = new _0027_RemoveElement();
        var length   = solution.RemoveElement(nums, val);

        var results = new int[length];
        for (var i = 0; i < results.Length; i++)
        {
            results[i] = nums[i];
        }

        Assert.Equivalent(results, Array.Empty<int>());
    }
}
