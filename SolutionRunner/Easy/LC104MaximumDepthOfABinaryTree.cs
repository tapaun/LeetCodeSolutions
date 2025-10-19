using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Tree, LeetCodeTag.DepthFirstSearch, LeetCodeTag.BreadthFirstSearch, LeetCodeTag.BinaryTree)]
public class LC104MaximumDepthOfABinaryTree {
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
