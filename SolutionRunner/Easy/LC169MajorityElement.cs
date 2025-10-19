using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.HashTable, LeetCodeTag.DivideAndConquer, LeetCodeTag.Sorting, LeetCodeTag.Counting)]
public class LC169MajorityElement {
    public int MajorityElement(int[] nums) {
        ReadOnlySpan<int> span = nums;
        Dictionary<int, int> counts = new();
        int majorityCount = nums.Length / 2;
        foreach (var num in span) {
            if (counts.ContainsKey(num)) {
                counts[num]++;
            }
            else {
                counts[num] = 1;
            }

            if (counts[num] > majorityCount) {
                return num;
            }
        }

        return -1;
    }
}
