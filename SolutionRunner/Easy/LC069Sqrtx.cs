using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Math, LeetCodeTag.BinarySearch)]
public class LC069Sqrtx {
    public int MySqrt(int x){
        for(long i = 0;i<=x/2+1;i++)
        {
            if(i*i==x)
                return (int)i;
            if(i*i>x)
                return (int)i-1;
        }
        return 1;
    }
}

