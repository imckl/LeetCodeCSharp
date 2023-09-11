namespace LeetCode.Structs;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class TreeNode
{
    // ReSharper disable InconsistentNaming
    public readonly int val;

    public TreeNode? left;
    public TreeNode? right;
    // ReSharper restore InconsistentNaming

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val   = val;
        this.left  = left;
        this.right = right;
    }

    public static TreeNode? FromArray(int?[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
        }

        if (nums[0] is null)
        {
            throw new NullReferenceException("Start node value cannot be null");
        }

        var root = new TreeNode(nums[0]!.Value);

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var i = 1;

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (i < nums.Length && nums[i].HasValue)
            {
                var left = new TreeNode(nums[i]!.Value);
                node.left = left;
                queue.Enqueue(left);
            }

            if (i + 1 < nums.Length && nums[i + 1].HasValue)
            {
                var right = new TreeNode(nums[i + 1]!.Value);
                node.right = right;
                queue.Enqueue(right);
            }

            i += 2;
        }

        return root;
    }
}
