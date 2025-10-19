using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.String)]
public class LC058LengthOfLastWord {
    public int LengthOfLastWord(string s) {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Last().Length;
    }
}

