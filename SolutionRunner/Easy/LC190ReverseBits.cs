using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.DivideAndConquer, LeetCodeTag.BitManipulation)]
public class LC190ReverseBits {
    public int ReverseBits(int n) {
        int result = 0;
        for (int i = 0; i < 32; i++) {
            result <<= 1;
            result |= (n & 1);
            n >>= 1;
        }
        return result;
    }
}
