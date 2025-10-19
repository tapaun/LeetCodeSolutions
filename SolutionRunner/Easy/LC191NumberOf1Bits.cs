using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.DivideAndConquer, LeetCodeTag.BitManipulation)]
public class LC191NumberOf1Bits {
    public int HammingWeight(int n) {
        int counter = 0;
        while (n != 1) {
            counter += n & 1;
            n >>= 1;
        }
        return ++counter;
    }
}
