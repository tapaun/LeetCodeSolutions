using System.Text;
using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.TwoPointers, LeetCodeTag.String)]
public class LC125ValidPalindrome {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                sb.Append(char.ToLower(c));
            }
        }
        string filtered = sb.ToString();
        int left = 0, right = filtered.Length - 1;
        while (left < right) {
            if (filtered[left] != filtered[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}

