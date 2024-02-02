namespace LeetCode.Test;

public class _0069_MySqrt_Test
{
    [Fact]
    public void Test_1()
    {
        var x = 1;

        var solution = new _0069_MySqrt();
        var actual   = solution.MySqrt(x);

        Assert.Equal(1, actual);
    }
    
    [Fact]
    public void Test_2()
    {
        var x = 2;

        var solution = new _0069_MySqrt();
        var actual   = solution.MySqrt(x);

        Assert.Equal(1, actual);
    }
    
    [Fact]
    public void Test_100()
    {
        var x = 100;

        var solution = new _0069_MySqrt();
        var actual   = solution.MySqrt(x);

        Assert.Equal(10, actual);
    }

    [Fact]
    public void Test_101()
    {
        var x = 101;

        var solution = new _0069_MySqrt();
        var actual   = solution.MySqrt(x);

        Assert.Equal(10, actual);
    }

    [Fact]
    public void Test_99()
    {
        var x = 99;

        var solution = new _0069_MySqrt();
        var actual   = solution.MySqrt(x);

        Assert.Equal(9, actual);
    }

    [Fact]
    public void Test_LeftBoundary()
    {
        var x = 0;

        var solution = new _0069_MySqrt();
        var actual   = solution.MySqrt(x);

        Assert.Equal(0, actual);
    }

    [Fact]
    public void Test_RightBoundary()
    {
        var x = int.MaxValue;

        var solution = new _0069_MySqrt();
        var actual   = solution.MySqrt(x);

        Assert.Equal(46340, actual);
    }
}
