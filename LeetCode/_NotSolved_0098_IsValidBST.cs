using LeetCode.Structs;

namespace LeetCode;

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
// 搞清楚二叉树后，再尝试中序遍历，前序遍历，后序遍历，及以上递归版本
public class _NotSolved_0098_IsValidBST
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, long.MinValue, long.MaxValue);
    }

    bool IsValidBST(TreeNode? node, long lower, long upper)
    {
        if (node is null)
        {
            return true;
        }

        if (node.val <= lower || node.val >= upper)
        {
            return false;
        }

        return IsValidBST(node.left, lower, node.val) && IsValidBST(node.right, node.val, upper);
    }
}
