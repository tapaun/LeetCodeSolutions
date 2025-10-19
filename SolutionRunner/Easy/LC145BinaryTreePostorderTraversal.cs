using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Stack, LeetCodeTag.Tree, LeetCodeTag.DepthFirstSearch, LeetCodeTag.BinaryTree)]
public class LC145BinaryTreePostorderTraversal {
    public IList<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();
        if (root == null) {
            return result;
        }
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0) {
            var node = stack.Pop();
            result.Add(node.val);
            if (node.left != null) {
                stack.Push(node.left);
            }
            if (node.right != null) {
                stack.Push(node.right);
            }
        }
        result.Reverse();
        return result;
    }
}
