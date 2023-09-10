namespace LeetCode.Test;

public class _0006_Convert_Test
{
    [Fact]
    public void ShortTest()
    {
        var s = "A";

        var solution = new _0006_Convert();
        var result   = solution.Convert(s, 1);

        Assert.Equal("A", result);
    }

    [Fact]
    public void ShortTest2()
    {
        var s = "AB";

        var solution = new _0006_Convert();
        var result   = solution.Convert(s, 2);

        Assert.Equal("AB", result);
    }

    [Fact]
    public void NormalTest()
    {
        // 012345678901234567890123456789012345678901234567890123456

        var s = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefg";

        var solution = new _0006_Convert();
        var result   = solution.Convert(s, 5);

        Assert.Equal("aigecaigbhjfhdfbdjbhjfcgaeicgaeicgaedfbdjbhjfhdfbdecaigec", result);
    }

    [Fact]
    public void NormalTest2()
    {
        var s = "PAYPALISHIRING";

        var solution = new _0006_Convert();
        var result   = solution.Convert(s, 3);

        Assert.Equal("PAHNAPLSIIGYIR", result);
    }

    [Fact]
    public void NormalTest3()
    {
        var s = "PAYPALISHIRING";

        var solution = new _0006_Convert();
        var result   = solution.Convert(s, 4);

        Assert.Equal("PINALSIGYAHRPI", result);
    }
}
