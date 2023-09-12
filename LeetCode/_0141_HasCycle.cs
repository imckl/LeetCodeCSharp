using LeetCode.Structs;

namespace LeetCode;

public class _0141_HasCycle
{
    public bool HasCycle(ListNode? head)
    {
        var dummy = new ListNode(0, head);
        var fast  = head;
        var slow  = dummy;

        var i = 0;
        while (fast is not null)
        {
            if (fast == slow)
            {
                return true;
            }

            // 块二慢一
            if (i % 2 == 0)
            {
                slow = slow!.next;
            }

            fast = fast.next;

            i++;
        }

        return false;
    }

    // bad, 修改了链表
    public bool HasCycle_3(ListNode? head)
    {
        var dummy = new ListNode();
        var node  = head;

        while (node is not null)
        {
            if (node.next == dummy)
            {
                return true;
            }

            var cur = node;
            node     = node.next;
            cur.next = dummy;
        }

        return false;
    }

    public bool HasCycle_2(ListNode? head)
    {
        var nodes = new HashSet<ListNode>();
        var node  = head;

        while (node is not null)
        {
            if (nodes.Contains(node))
            {
                return true;
            }

            nodes.Add(node);

            node = node.next;
        }

        return false;
    }
}
