using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.HashTable)]
public class LC001TwoSum {
        public int[] FindTwoSum(int[] nums, int target) {
            var hashMap = new Dictionary<int, int>();
            for(int i = 0;i<nums.Length;i++)
            {
                int numNeeded = target - nums[i];
                if(hashMap.TryGetValue(numNeeded, out var value))
                    return [value, i];
                hashMap[nums[i]] = i;
            }
            return [];
        }
}