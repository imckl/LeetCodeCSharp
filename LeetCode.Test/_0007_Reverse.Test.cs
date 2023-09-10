namespace LeetCode.Test;

public class _0007_Reverse_Test
{
    [Fact]
    public void EdgeCaseTest1()
    {
        var x = 1534236469;
        // int y = 9646324351;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(0, result);
    }

    [Fact]
    public void ZeroTest()
    {
        var x = 0;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(0, result);
    }

    [Fact]
    public void ShortTest()
    {
        var x = 1;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(1, result);
    }

    [Fact]
    public void ShortNegativeTest()
    {
        var x = -1;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void OutOfBoundaryTest()
    {
        var x = 2147483647;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(0, result);
    }

    [Fact]
    public void OutOfBoundaryNegativeTest()
    {
        var x = -2147483647;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(0, result);
    }

    [Fact]
    public void NormalTest()
    {
        var x = 214748364;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(463847412, result);
    }

    [Fact]
    public void NormalNegativeTest()
    {
        var x = -214748364;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(-463847412, result);
    }

    [Fact]
    public void ZeroPaddingTest()
    {
        var x = 214748300;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(3847412, result);
    }

    [Fact]
    public void ZeroPaddingNegativeTest()
    {
        var x = -214748300;

        var solution = new _0007_Reverse();
        var result   = solution.Reverse(x);

        Assert.Equal(-3847412, result);
    }
}
