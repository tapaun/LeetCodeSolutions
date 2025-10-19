using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.BinarySearch)]
public class LC035SearchInsertPosition {
    public int SearchInsert(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > target) return i;
            if (nums[i] == target) return i;
        }
        return nums.Length;
    }
}

