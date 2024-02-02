namespace LeetCode.Test;

public class _0169_MajorityElement_Test
{
    [Fact]
    public void Test1()
    {
        var nums = new[] { 3, 2, 3 };

        var solution = new _0169_MajorityElement();
        var answer   = solution.MajorityElement(nums);

        Assert.Equal(answer, 3);
    }

    [Fact]
    public void Test2()
    {
        var nums = new[] { 3 };

        var solution = new _0169_MajorityElement();
        var answer   = solution.MajorityElement(nums);

        Assert.Equal(answer, 3);
    }

    [Fact]
    public void Test3()
    {
        var nums = new[]
        {
            3, 5463, 6534, 63, 6534, 6534, 6, 346, 6534, 6, 5346, 3456, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 453, 6, 365,
            436534, 634, 5634, 5634, 8, 8, 8, 8, 8, 8, 8, 8, 8, 432
        };

        var solution = new _0169_MajorityElement();
        var answer   = solution.MajorityElement(nums);

        Assert.Equal(answer, 8);
    }
}
