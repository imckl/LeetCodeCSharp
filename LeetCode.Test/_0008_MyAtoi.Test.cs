namespace LeetCode.Test;

public class _0008_MyAtoi_Test
{
    [Fact]
    public void NormalTest1()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("42");

        Assert.Equal(42, result);
    }

    [Fact]
    public void NormalTest2()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("   -42");

        Assert.Equal(-42, result);
    }

    [Fact]
    public void NormalTest3()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("4193 with words");

        Assert.Equal(4193, result);
    }

    [Fact]
    public void NormalTest4()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("4193.31 with words");

        Assert.Equal(4193, result);
    }

    [Fact]
    public void NormalTest5()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("41-93.31 with words");

        Assert.Equal(41, result);
    }

    [Fact]
    public void NormalTest6()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi(" - 4193.31 with words");

        Assert.Equal(0, result);
    }

    [Fact]
    public void NormalTest7()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi(" -00004193.31 with words");

        Assert.Equal(-4193, result);
    }

    [Fact]
    public void NormalTest8()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi(" -0000.31 with words");

        Assert.Equal(0, result);
    }

    [Fact]
    public void OneTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("1");

        Assert.Equal(1, result);
    }

    [Fact]
    public void MinusOneTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("-1");

        Assert.Equal(-1, result);
    }

    [Fact]
    public void ZeroTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("0");

        Assert.Equal(0, result);
    }

    [Fact]
    public void MinusZeroTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("-0");

        Assert.Equal(0, result);
    }

    [Fact]
    public void MaxIntTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("2147483647");

        Assert.Equal(2147483647, result);
    }

    [Fact]
    public void MinIntTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("-2147483648");

        Assert.Equal(-2147483648, result);
    }

    [Fact]
    public void MaxIntPlusOneTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("2147483648");

        Assert.Equal(2147483647, result);
    }

    [Fact]
    public void MinIntMinusOneTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("-2147483649");

        Assert.Equal(-2147483648, result);
    }

    [Fact]
    public void EdgeCaseNegativeTest()
    {
        var solution = new _0008_MyAtoi();
        var result   = solution.MyAtoi("-91283472332");

        Assert.Equal(-2147483648, result);
    }
}
