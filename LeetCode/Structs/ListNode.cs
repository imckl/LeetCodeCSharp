namespace LeetCode.Structs;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class ListNode
{
    // ReSharper disable InconsistentNaming
    public readonly int val;

    public ListNode? next;
    // ReSharper restore InconsistentNaming

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val  = val;
        this.next = next;
    }

    public static ListNode? FromArray(int[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
        }

        var head = new ListNode(nums[0]);
        var ln   = head;

        for (var i = 1; i < nums.Length; i++)
        {
            ln.next = new ListNode(nums[i]);
            ln      = ln.next;
        }

        return head;
    }

    public static int[] ToArray(ListNode? node)
    {
        var list = new List<int>();

        while (node is not null)
        {
            list.Add(node.val);
            node = node.next;
        }

        return list.ToArray();
    }
}
