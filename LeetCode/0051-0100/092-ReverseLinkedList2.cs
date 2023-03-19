//-----------------------------------------------------------------------------
// Runtime: 104ms
// Runtime: 82ms
// Memory Usage: -
// Memory Usage: 38.2 MB
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _092_ReverseLinkedList2
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (m == n || head?.next == null)
            {
                return head;
            }

            ListNode beforeSublist = null;
            ListNode subHead = null;
            ListNode tail = null;

            FindSubList(head, m, n, 1, ref beforeSublist, ref subHead, ref tail);

            ListNode reversedSublist = null;
            var last = ReverseListInternal(subHead, ref reversedSublist);
            last.next = tail;

            if (beforeSublist != null)
            {
                beforeSublist.next = reversedSublist;
                return head;
            }
            else
            {
                return reversedSublist;
            }
        }

        private void FindSubList(
            ListNode head,
            int left,
            int right,
            int index,
            ref ListNode beforeSublist,
            ref ListNode sublistHead,
            ref ListNode tail)
        {
            if (head == null)
            {
                return;
            }

            if (index == left - 1)
            {
                beforeSublist = head;
            }

            if (index == left)
            {
                sublistHead = head;
            }

            if (index == right)
            {
                tail = head.next;
                head.next = null;
            }

            FindSubList(head.next, left, right, index + 1, ref beforeSublist, ref sublistHead, ref tail);
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