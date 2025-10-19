using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Math, LeetCodeTag.DynamicProgramming, LeetCodeTag.Memoization)]
public class LC070ClimbingStairs {
    public int FibonacciSequence(int n) {
        if (n <= 1) return n;
        int a = 1, b = 1, c = 0;
        for (int i = 2; i <= n; i++) {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
    public int ClimbStairs(int n) {
        return FibonacciSequence(n);
    }
}

