using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.BitManipulation)]
public class LC136SingleNumber {
    public int SingleNumber(int[] nums) {
        int result = 0;
        foreach (int num in nums) {
            result ^= num;
        }
        return result;
    }
}

