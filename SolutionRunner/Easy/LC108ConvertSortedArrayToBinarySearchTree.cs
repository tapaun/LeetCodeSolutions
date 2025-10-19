using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.DivideAndConquer, LeetCodeTag.Tree, LeetCodeTag.BinarySearchTree, LeetCodeTag.BinaryTree)]
public class LC108ConvertSortedArrayToBinarySearchTree {
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums == null || nums.Length == 0) return null;
        return BSTBuilder(nums, 0, nums.Length - 1);
    }
    public TreeNode BSTBuilder(int[] nums, int left, int right) {
        if (left > right) return null;
        int mid = left + (right - left) / 2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = BSTBuilder(nums, left, mid - 1);
        node.right = BSTBuilder(nums, mid + 1, right);
        return node;
    }
}
