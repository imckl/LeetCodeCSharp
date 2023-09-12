namespace LeetCode.Test;

public class _228_SummaryRanges_Test
{
    [Fact]
    public void LengthZero()
    {
        var nums     = Array.Empty<int>();
        var solution = new _0228_SummaryRanges();
        var actual   = solution.SummaryRanges(nums);

        Assert.Equal(Array.Empty<string>(), actual);
    }

    [Fact]
    public void LengthOne()
    {
        var nums     = new[] { 0 };
        var solution = new _0228_SummaryRanges();
        var actual   = solution.SummaryRanges(nums);

        Assert.Equal(new[] { "0" }, actual);
    }

    [Fact]
    public void SingleStart()
    {
        var nums     = new[] { -1, 1, 2, 4, 5, 7, 8 };
        var solution = new _0228_SummaryRanges();
        var actual   = solution.SummaryRanges(nums);

        Assert.Equal(new[] { "-1", "1->2", "4->5", "7->8" }, actual);
    }

    [Fact]
    public void SingleEnd()
    {
        var nums     = new[] { 0, 1, 2, 4, 5, 7 };
        var solution = new _0228_SummaryRanges();
        var actual   = solution.SummaryRanges(nums);

        Assert.Equal(new[] { "0->2", "4->5", "7" }, actual);
    }

    [Fact]
    public void SingleStartAndEnd()
    {
        var nums     = new[] { -1, 1, 2, 4, 5, 7 };
        var solution = new _0228_SummaryRanges();
        var actual   = solution.SummaryRanges(nums);

        Assert.Equal(new[] { "-1", "1->2", "4->5", "7" }, actual);
    }

    [Fact]
    public void EdgeCase()
    {
        var nums     = new[] { int.MinValue, 0, int.MaxValue };
        var solution = new _0228_SummaryRanges();
        var actual   = solution.SummaryRanges(nums);

        Assert.Equal(new[] { "-2147483648", "0", "2147483647" }, actual);
    }

    [Fact]
    public void EdgeCase2()
    {
        var nums     = new[] { int.MinValue, -1, 0, 1, int.MaxValue };
        var solution = new _0228_SummaryRanges();
        var actual   = solution.SummaryRanges(nums);

        Assert.Equal(new[] { "-2147483648", "-1->1", "2147483647" }, actual);
    }
}
