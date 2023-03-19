//-----------------------------------------------------------------------------
// Runtime: 88ms
// Runtime: 94ms
// Memory Usage: 23.5 MB
// Memory Usage: 38.9 MB MB
// Link: https://leetcode.com/submissions/detail/260382381/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode result = null;
            var last = ReverseListInternal(head, ref result);
            last.next = null;

            return result;
        }

        private ListNode ReverseListInternal(ListNode current, ref ListNode result)
        {
            if (current.next == null)
            {
                result = current;
                return result;
            }

            var node = ReverseListInternal(current.next, ref result);
            node.next = current;

            return node.next;
        }
    }
}