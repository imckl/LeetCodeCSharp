using LeetCode.Structs;

namespace LeetCode.Test;

public static class TestHelper
{
    public static ListNode? ArrayToSinglyLinkedList(int[] nums)
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

    public static int[] SinglyLinkedListToArray(ListNode? ln)
    {
        var list = new List<int>();

        while (ln is not null)
        {
            list.Add(ln.val);
            ln = ln.next;
        }

        return list.ToArray();
    }

    // public static TreeNode GenerateTree(int?[] nums)
    // {
    //     if (nums == null || nums.Length == 0)
    //     {
    //         return null;
    //     }
    //
    //     var i     = 0;
    //     var first = new TreeNode(nums[i++].Value);
    //     var queue = new Queue<TreeNode>();
    //     queue.Enqueue(first);
    //
    //     while (queue.Count > 0)
    //     {
    //         var current = queue.Dequeue();
    //         if (i < nums.Length && nums[i].HasValue)
    //         {
    //             var node = new TreeNode(nums[i].Value);
    //             current.left = node;
    //             queue.Enqueue(node);
    //         }
    //
    //         if (i + 1 < nums.Length && nums[i + 1].HasValue)
    //         {
    //             var node = new TreeNode(nums[i + 1].Value);
    //             current.right = node;
    //             queue.Enqueue(node);
    //         }
    //
    //         i += 2;
    //     }
    //
    //     return first;
    // }
    //
    // public static TreeLinkNode GenerateLinkTree(int?[] nums)
    // {
    //     if (nums == null || nums.Length == 0)
    //     {
    //         return null;
    //     }
    //
    //     var i     = 0;
    //     var first = new TreeLinkNode(nums[i++].Value);
    //     var queue = new Queue<TreeLinkNode>();
    //     queue.Enqueue(first);
    //
    //     while (queue.Count > 0)
    //     {
    //         var current = queue.Dequeue();
    //         if (i < nums.Length && nums[i].HasValue)
    //         {
    //             var node = new TreeLinkNode(nums[i].Value);
    //             current.left = node;
    //             queue.Enqueue(node);
    //         }
    //
    //         if (i + 1 < nums.Length && nums[i + 1].HasValue)
    //         {
    //             var node = new TreeLinkNode(nums[i + 1].Value);
    //             current.right = node;
    //             queue.Enqueue(node);
    //         }
    //
    //         i += 2;
    //     }
    //
    //     return first;
    // }
}
