using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.HashTable, LeetCodeTag.LinkedList, LeetCodeTag.TwoPointers)]
public class LC141LinkedListCycle {
    public bool HasCycle(ListNode head) {
        var fast = head;
        while (fast != null && fast.next != null) {
            head = head.next;
            fast = fast.next.next;
            if (head == fast) {
                return true;
            }
        }
        return false;
    }
}

