using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.Math)]
public class LC066PlusOne {
    public int[] PlusOne(int[] digits) {
        if (digits[^1] < 9) {
            digits[^1]++;
            return digits;
        }
        List<int> list = new List<int>(digits);
        int i = digits.Length - 1;
        while (digits[i] == 9){
            list[i] = 0;
            i--;
            if (i < 0) {
                list.Insert(0, 1);
                return list.ToArray();
                break;
            }
        }
        list[i]++;
        return list.ToArray();
    }
}

