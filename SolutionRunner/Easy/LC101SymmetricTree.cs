using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Tree, LeetCodeTag.DepthFirstSearch, LeetCodeTag.BreadthFirstSearch, LeetCodeTag.BinaryTree)]
public class LC101SymmetricTree {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }
    public bool IsMirror(TreeNode leftNode, TreeNode rightNode) {
        if (leftNode == null && rightNode == null) return true;
        if (leftNode == null || rightNode == null) return false;
        if (leftNode.val != rightNode.val) return false;
        return IsMirror(leftNode.left, rightNode.right) && IsMirror(leftNode.right, rightNode.left);
    }
}
