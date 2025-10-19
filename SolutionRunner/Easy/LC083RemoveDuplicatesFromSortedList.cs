using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.LinkedList, LeetCodeTag.TwoPointers)]
public class LC083RemoveDuplicatesFromSortedList {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode dummyHead = new ListNode(0);
        ListNode newCurrent = dummyHead;
        ListNode current = head;
        while (current != null) {
            if (newCurrent == dummyHead || newCurrent.val != current.val) {
                newCurrent.next = new ListNode(current.val);
                newCurrent = newCurrent.next;
            }
            current = current.next;
        }
        return dummyHead.next;
    }
}

