using LeetCode.Structs;

namespace LeetCode.Test;

public class _0141_HasCycle_Test
{
    [Fact]
    public void CycleItself()
    {
        var first = new ListNode(0);
        first.next = first;

        var solution = new _0141_HasCycle();
        var actual   = solution.HasCycle(first);

        Assert.True(actual);
    }

    [Fact]
    public void CycleToHead()
    {
        var first  = new ListNode(0);
        var second = new ListNode();
        var third  = new ListNode();
        first.next  = second;
        second.next = third;
        third.next  = first;

        var solution = new _0141_HasCycle();
        var actual   = solution.HasCycle(first);

        Assert.True(actual);
    }

    [Fact]
    public void CycleToMid()
    {
        var first  = new ListNode(0);
        var second = new ListNode();
        var third  = new ListNode();
        first.next  = second;
        second.next = third;
        third.next  = second;

        var solution = new _0141_HasCycle();
        var actual   = solution.HasCycle(first);

        Assert.True(actual);
    }

    [Fact]
    public void CycleToLast()
    {
        var first  = new ListNode(0);
        var second = new ListNode();
        var third  = new ListNode();
        first.next  = second;
        second.next = third;
        third.next  = third;

        var solution = new _0141_HasCycle();
        var actual   = solution.HasCycle(first);

        Assert.True(actual);
    }

    [Fact]
    public void NoCycle()
    {
        var first  = new ListNode(0);
        var second = new ListNode();
        var third  = new ListNode();
        first.next  = second;
        second.next = third;

        var solution = new _0141_HasCycle();
        var actual   = solution.HasCycle(first);

        Assert.False(actual);
    }

    [Fact]
    public void ZeroListNode()
    {
        ListNode? first = null;

        var solution = new _0141_HasCycle();
        var actual   = solution.HasCycle(first);

        Assert.False(actual);
    }
}
