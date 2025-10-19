using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.TwoPointers)]
public class LC027RemoveElement {
    public int RemoveElement(int[] nums, int val) {
        int j = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val)
                nums[j++] = nums[i];
        }
        return j;
    }
}

