using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Math)]
public class LC009PalindromeNumber {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        long y = 0;
        for(int i = x;i!=0;){
            y = (y * 10 + i % 10);
            if(y > int.MaxValue) return false;
            i /= 10;
        }
        return x==y;
    }
}