using LeetCode.Structs;

namespace LeetCode.Test;

public class _0098_IsValidBST_Test
{
    [Fact]
    public void NormalTest1()
    {
        var root = TreeNode.FromArray(new int?[] { 2, 1, 3 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.True(actual);
    }

    [Fact]
    public void NormalTest2()
    {
        var root = TreeNode.FromArray(new int?[] { 5, 1, 4, null, null, 3, 6 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.False(actual);
    }

    [Fact]
    public void NormalTest3()
    {
        var root = TreeNode.FromArray(new int?[] { 5, 2, 8, null, 1, 7, 9 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.False(actual);
    }

    [Fact]
    public void NormalTest4()
    {
        var root = TreeNode.FromArray(new int?[] { 5, 2, 8, null, 3, 7, 9 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.True(actual);
    }

    [Fact]
    public void NormalTest5()
    {
        var root = TreeNode.FromArray(new int?[] { 5, 2, 8, null, 3, 7, 9 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.True(actual);
    }

    [Fact]
    public void NormalTest6()
    {
        var root = TreeNode.FromArray(new int?[] { 1, 1, 1 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.False(actual);
    }

    [Fact]
    public void NormalTest7()
    {
        var root = TreeNode.FromArray(new int?[] { 1, 1 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.False(actual);
    }

    [Fact]
    public void NormalTest8()
    {
        var root = TreeNode.FromArray(new int?[] { 1, null, 1 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.False(actual);
    }

    [Fact]
    public void NormalTest9()
    {
        var root = TreeNode.FromArray(new int?[] { 1 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.True(actual);
    }

    [Fact]
    public void MinMaxIntTest()
    {
        var root = TreeNode.FromArray(new int?[] { 1, -2147483648, 2147483647 })!;

        var solution = new _NotSolved_0098_IsValidBST();
        var actual   = solution.IsValidBST(root);

        Assert.True(actual);
    }
}
