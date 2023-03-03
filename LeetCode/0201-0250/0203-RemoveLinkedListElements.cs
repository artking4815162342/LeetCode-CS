//-----------------------------------------------------------------------------
// Runtime: 79ms
// Memory Usage: 42.2 MB
// Link: https://leetcode.com/submissions/detail/358364330/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class _0203_RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }

            if (head.val != val)
            {
                head.next = RemoveElements(head.next, val);
                return head;
            }

            return RemoveElements(head.next, val);
        }
    }
}