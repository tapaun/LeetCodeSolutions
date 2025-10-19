using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.TwoPointers, LeetCodeTag.Sorting)]
public class LC088MergeSortedArray {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int left = m - 1;
        int right = n - 1;
        int index = m + n - 1;
        while (left >= 0 && right >= 0) {
            if (nums1[left] > nums2[right]) {
                nums1[index--] = nums1[left--];
            }
            else {
                nums1[index--] = nums2[right--];
            }
        }

        while (right >= 0) {
            nums1[index--] = nums2[right--];
        }
    }
}

