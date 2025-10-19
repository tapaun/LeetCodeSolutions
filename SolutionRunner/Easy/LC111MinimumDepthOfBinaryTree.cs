using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Tree, LeetCodeTag.DepthFirstSearch, LeetCodeTag.BreadthFirstSearch, LeetCodeTag.BinaryTree)]
public class LC111MinimumDepthOfBinaryTree {
    public int MinDepth(TreeNode root) {
        if (root == null) return 0;
        if (root.left == null && root.right == null) return 1;
        if (root.left == null) return MinDepth(root.right) + 1;
        if (root.right == null) return MinDepth(root.left) + 1;
        return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
    }
}
