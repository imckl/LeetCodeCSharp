namespace LeetCode.Test;

public class _0019_RemoveNthFromEnd_Test
{
    [Fact]
    public void GetNodeLength_Len1()
    {
        var ln = TestHelper.ArrayToSinglyLinkedList(new[] { 1 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.GetNodeLength(ln);

        Assert.Equal(1, actual);
    }

    [Fact]
    public void GetNodeLength_Len2()
    {
        var ln = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.GetNodeLength(ln);

        Assert.Equal(2, actual);
    }

    [Fact]
    public void GetNodeLength_Len3()
    {
        var ln = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.GetNodeLength(ln);

        Assert.Equal(3, actual);
    }

    [Fact]
    public void RemoveNthNode_TestLengthOne()
    {
        var ln = TestHelper.ArrayToSinglyLinkedList(new[] { 1 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthNode(ln, 1);

        var expected = TestHelper.ArrayToSinglyLinkedList(Array.Empty<int>());

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void RemoveNthNode_TestFirstOne()
    {
        var ln = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthNode(ln, 1);

        var expected = TestHelper.ArrayToSinglyLinkedList(new[] { 2, 3, 4, 5 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void RemoveNthNode_TestMidOne()
    {
        var ln = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthNode(ln, 3);

        var expected = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 4, 5 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void RemoveNthNode_TestLast()
    {
        var ln = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthNode(ln, 5);

        var expected = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3, 4 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void Normal_TestLengthOne()
    {
        var link = TestHelper.ArrayToSinglyLinkedList(new[] { 1 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthFromEnd(link, 1);

        var expected = TestHelper.ArrayToSinglyLinkedList(Array.Empty<int>());

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void Normal_TestFirstOne()
    {
        var link = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthFromEnd(link, 5);

        var expected = TestHelper.ArrayToSinglyLinkedList(new[] { 2, 3, 4, 5 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void Normal_TestMidOne()
    {
        var link = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthFromEnd(link, 3);

        var expected = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 4, 5 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }

    [Fact]
    public void Normal_TestLastOne()
    {
        var link = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3, 4, 5 })!;

        var solution = new _0019_RemoveNthFromEnd();
        var actual   = solution.RemoveNthFromEnd(link, 1);

        var expected = TestHelper.ArrayToSinglyLinkedList(new[] { 1, 2, 3, 4 });

        AssertHelper.AssertSinglyLinkList(expected, actual);
    }
}
