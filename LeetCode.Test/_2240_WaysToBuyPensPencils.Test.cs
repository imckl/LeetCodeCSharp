namespace LeetCode.Test;

public class _2240_WaysToBuyPensPencils_Test
{
    [Fact]
    public void Test_111()
    {
        var total = 1;
        var cost1 = 1;
        var cost2 = 1;

        var solution = new _2240_WaysToBuyPensPencils();
        var actual   = solution.WaysToBuyPensPencils(total, cost1, cost2);

        Assert.Equal(3, actual);
    }

    [Fact]
    public void Test_NotEnoughTotal()
    {
        var total = 1;
        var cost1 = 10;
        var cost2 = 10;

        var solution = new _2240_WaysToBuyPensPencils();
        var actual   = solution.WaysToBuyPensPencils(total, cost1, cost2);

        Assert.Equal(1, actual);
    }

    [Fact]
    public void Test_Normal()
    {
        var total = 20;
        var cost1 = 10;
        var cost2 = 5;

        var solution = new _2240_WaysToBuyPensPencils();
        var actual   = solution.WaysToBuyPensPencils(total, cost1, cost2);

        Assert.Equal(9, actual);
    }

    [Fact]
    public void Test_NotEnoughCost1()
    {
        var total = 11;
        var cost1 = 99;
        var cost2 = 2;

        var solution = new _2240_WaysToBuyPensPencils();
        var actual   = solution.WaysToBuyPensPencils(total, cost1, cost2);

        Assert.Equal(6, actual);
    }

    [Fact]
    public void Test_Normal3()
    {
        var total = 89;
        var cost1 = 2;
        var cost2 = 1;

        var solution = new _2240_WaysToBuyPensPencils();
        var actual   = solution.WaysToBuyPensPencils(total, cost1, cost2);

        Assert.Equal(2070, actual);
    }

    [Fact]
    public void Test_Normal4()
    {
        var total = 10;
        var cost1 = 2;
        var cost2 = 1;

        var solution = new _2240_WaysToBuyPensPencils();
        var actual   = solution.WaysToBuyPensPencils(total, cost1, cost2);

        Assert.Equal(36, actual);
    }

    [Fact]
    public void Test_Normal5()
    {
        var total = 11;
        var cost1 = 2;
        var cost2 = 1;

        var solution = new _2240_WaysToBuyPensPencils();
        var actual   = solution.WaysToBuyPensPencils(total, cost1, cost2);

        Assert.Equal(42, actual);
    }

    [Fact]
    public void Test_BiggerThanMaxIntResult()
    {
        var total = 1000000;
        var cost1 = 1;
        var cost2 = 1;

        var solution = new _2240_WaysToBuyPensPencils();
        var actual   = solution.WaysToBuyPensPencils(total, cost1, cost2);

        Assert.Equal(500001500001, actual);
    }
}
