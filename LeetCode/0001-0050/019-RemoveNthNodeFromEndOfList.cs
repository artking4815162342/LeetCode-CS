//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _019_RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var iterator = n;
            var count = RemoveNthFromEndInternal(head, ref iterator);
            return count == n ? head.next : head;
        }

        private int RemoveNthFromEndInternal(ListNode head, ref int n)
        {
            if (head == null)
            {
                return 0;
            }

            var count = 1 + RemoveNthFromEndInternal(head.next, ref n);

            n--;
            if (n == -1)
            {
                head.next = head.next?.next;
            }

            return count;
        }
    }
}