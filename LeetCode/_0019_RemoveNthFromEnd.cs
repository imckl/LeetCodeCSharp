using LeetCode.Structs;

namespace LeetCode;

public class _0019_RemoveNthFromEnd
{
    // 快慢指针, 注意慢指针选取的起点是dummy - 永远比快指针慢?
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        var fast  = head;
        var slow  = dummy;

        for (var i = 0; i < n; i++)
        {
            fast = fast!.next;
        }

        while (fast is not null)
        {
            fast = fast.next;
            slow = slow!.next;
        }

        slow!.next = slow.next!.next;

        return dummy.next;
    }

    public ListNode? RemoveNthFromEnd_3(ListNode head, int n)
    {
        var listNodesByIndexes = new Dictionary<int, ListNode>();

        var dummy = new ListNode(0, head);
        var node  = dummy;
        var i     = 0;

        while (node is not null)
        {
            listNodesByIndexes.Add(i, node);

            i++;
            node = node.next;
        }

        var len      = listNodesByIndexes.Count;
        var removeAt = len - n;

        listNodesByIndexes[removeAt - 1].next = listNodesByIndexes[removeAt].next;

        return dummy.next;
    }

    public int GetNodeLength(ListNode head)
    {
        var len  = 0;
        var node = head;

        while (node is not null)
        {
            node = node.next;
            len++;
        }

        return len;
    }

    public ListNode? RemoveNthNode(ListNode head, int n)
    {
        if (head.next is null)
        {
            return null;
        }

        var dummy = new ListNode(0, head);
        var node  = dummy;

        var m = n - 1;

        for (var i = 0; i < m; i++)
        {
            node = node!.next;
        }

        if (node!.next is not null)
        {
            node.next = node.next.next;
        }
        else
        {
            node.next = null;
        }

        return dummy.next;
    }

    public ListNode? RemoveNthFromEnd_2(ListNode head, int n)
    {
        var len      = GetNodeLength(head);
        var removeAt = len - n + 1;

        var node = RemoveNthNode(head, removeAt);

        return node;
    }
}
