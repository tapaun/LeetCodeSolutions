using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Math, LeetCodeTag.String, LeetCodeTag.BitManipulation, LeetCodeTag.Simulation)]
public class LC067AddBinary {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        string result = "";
        while (i >= 0 || j >= 0 || carry != 0) {
            int bitA = i >= 0 ? a[i] - '0' : 0;
            int bitB = j >= 0 ? b[j] - '0' : 0;
            int sum = bitA + bitB + carry;
            result += (sum & 1).ToString();
            carry = sum >> 1;
            i--;
            j--;
        }
        var arr = result.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

