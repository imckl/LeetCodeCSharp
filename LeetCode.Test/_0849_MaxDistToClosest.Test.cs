namespace LeetCode.Test;

public class _0849_MaxDistToClosest_Test
{
    [Fact]
    public void Test_OnlyStartIsOne()
    {
        var seats    = new[] { 1, 0, 0, 0, 0 };
        var solution = new _0849_MaxDistToClosest();
        var actual   = solution.MaxDistToClosest(seats);

        Assert.Equal(4, actual);
    }

    [Fact]
    public void Test_OnlyEndIsOne()
    {
        var seats    = new[] { 0, 0, 0, 0, 1 };
        var solution = new _0849_MaxDistToClosest();
        var actual   = solution.MaxDistToClosest(seats);

        Assert.Equal(4, actual);
    }

    [Fact]
    public void Test_ZeroOne()
    {
        var seats    = new[] { 0, 1 };
        var solution = new _0849_MaxDistToClosest();
        var actual   = solution.MaxDistToClosest(seats);

        Assert.Equal(1, actual);
    }

    [Fact]
    public void Test_OneZero()
    {
        var seats    = new[] { 1, 0 };
        var solution = new _0849_MaxDistToClosest();
        var actual   = solution.MaxDistToClosest(seats);

        Assert.Equal(1, actual);
    }

    [Fact]
    public void Test_OneOnEachSide()
    {
        var seats    = new int[] { 1, 0, 0, 1, 0, 1 };
        var solution = new _0849_MaxDistToClosest();
        var actual   = solution.MaxDistToClosest(seats);

        Assert.Equal(1, actual);
    }

    [Fact]
    public void Test_OneOnEachSide2()
    {
        var seats    = new int[] { 1, 0, 0, 0, 1, 0, 1 };
        var solution = new _0849_MaxDistToClosest();
        var actual   = solution.MaxDistToClosest(seats);

        Assert.Equal(2, actual);
    }

    [Fact]
    public void Test_ZeroOnEachSide()
    {
        var seats    = new[] { 0, 0, 0, 1, 0, 0 };
        var solution = new _0849_MaxDistToClosest();
        var actual   = solution.MaxDistToClosest(seats);

        Assert.Equal(3, actual);
    }
}
