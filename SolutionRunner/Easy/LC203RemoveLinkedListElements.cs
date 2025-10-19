using SolutionRunner.LCAttributes;
using SolutionRunner.LCClasses;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.LinkedList, LeetCodeTag.Recursion)]
public class LC203RemoveLinkedListElements {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        while(head != null) {
            if(head.val != val) {
                current.next =  head;
                current = current.next;
            }
            head = head.next;
        }
        current.next = null;
        return dummy.next;
    }
}

