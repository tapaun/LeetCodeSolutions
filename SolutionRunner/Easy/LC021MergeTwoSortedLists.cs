using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.LinkedList, LeetCodeTag.Recursion)]
public class LC021MergeTwoSortedLists {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                current.next = list1;
                list1 = list1.next;
            } else {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        current.next = list1 ?? list2;
        return dummy.next;
    }
}

