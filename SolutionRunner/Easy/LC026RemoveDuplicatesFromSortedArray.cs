using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.TwoPointers)]
public class LC026RemoveDuplicatesFromSortedArray {
    public int RemoveDuplicates(int[] nums) {
        var distinct = new HashSet<int>(nums);
        int i = 0;
        foreach(int num in distinct)
        {
            nums[i] = num;
            i++;
        }
        return distinct.Count;
    }
}

