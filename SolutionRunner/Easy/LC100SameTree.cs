using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Tree, LeetCodeTag.DepthFirstSearch, LeetCodeTag.BreadthFirstSearch, LeetCodeTag.BinaryTree)]
public class LC100SameTree {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        if (p.val != q.val) return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
