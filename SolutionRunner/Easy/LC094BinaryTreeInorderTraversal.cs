using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Stack, LeetCodeTag.Tree, LeetCodeTag.DepthFirstSearch, LeetCodeTag.BinaryTree)]
public class LC094BinaryTreeInorderTraversal {
    List<int> result = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null) return result;
        InorderTraversal(root.left);
        result.Add(root.val);
        InorderTraversal(root.right);
        return result;
    }
}
