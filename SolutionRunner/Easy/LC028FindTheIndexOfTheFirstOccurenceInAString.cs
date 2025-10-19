using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.String, LeetCodeTag.TwoPointers)]
public class LC028FindTheIndexOfTheFirstOccurenceInAString {
    public int StrStr(string haystack, string needle) {
        if(needle == "") return 0;
        for(int i = 0; i <= haystack.Length - needle.Length; i++){
            if(haystack.Substring(i, needle.Length) == needle)
                return i;
        }
        return -1;
    }
}

