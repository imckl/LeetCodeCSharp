using LeetCode.Structs;

namespace LeetCode.Test;

public class _0019_RemoveNthFromEnd_Test
{
    [Fact]
    public void GetNodeLength_Len1()
    {
        var node = ListNode.FromArray(new[] { 1 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.GetNodeLength(node);

        Assert.Equal(1, actual);
    }

    [Fact]
    public void GetNodeLength_Len2()
    {
        var node = ListNode.FromArray(new[] { 1, 2 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.GetNodeLength(node);

        Assert.Equal(2, actual);
    }

    [Fact]
    public void GetNodeLength_Len3()
    {
        var node = ListNode.FromArray(new[] { 1, 2, 3 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.GetNodeLength(node);

        Assert.Equal(3, actual);
    }

    [Fact]
    public void RemoveNthNode_TestLengthOne()
    {
        var node = ListNode.FromArray(new[] { 1 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthNode(node, 1);

        var expected = ListNode.FromArray(Array.Empty<int>());

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void RemoveNthNode_TestFirstOne()
    {
        var node = ListNode.FromArray(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthNode(node, 1);

        var expected = ListNode.FromArray(new[] { 2, 3, 4, 5 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void RemoveNthNode_TestMidOne()
    {
        var node = ListNode.FromArray(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthNode(node, 3);

        var expected = ListNode.FromArray(new[] { 1, 2, 4, 5 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void RemoveNthNode_TestLast()
    {
        var node = ListNode.FromArray(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthNode(node, 5);

        var expected = ListNode.FromArray(new[] { 1, 2, 3, 4 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void Normal_TestLengthOne()
    {
        var node = ListNode.FromArray(new[] { 1 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthFromEnd(node, 1);

        var expected = ListNode.FromArray(Array.Empty<int>());

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void Normal_TestFirstOne()
    {
        var node = ListNode.FromArray(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthFromEnd(node, 5);

        var expected = ListNode.FromArray(new[] { 2, 3, 4, 5 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void Normal_TestMidOne()
    {
        var node = ListNode.FromArray(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthFromEnd(node, 3);

        var expected = ListNode.FromArray(new[] { 1, 2, 4, 5 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void Normal_TestLastOne()
    {
        var node = ListNode.FromArray(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthFromEnd(node, 1);

        var expected = ListNode.FromArray(new[] { 1, 2, 3, 4 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }
}
