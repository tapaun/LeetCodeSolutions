using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Tree, LeetCodeTag.DepthFirstSearch, LeetCodeTag.BinaryTree)]
public class LC110BalancedBinaryTree {
    private int difference = 0;
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        return Math.Abs(Height(root.left) - Height(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    public int Height(TreeNode node) {
        if (node == null) return 0;
        return Math.Max(Height(node.left), Height(node.right)) + 1;
    }
}
