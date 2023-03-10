//-----------------------------------------------------------------------------
// Runtime: 148ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _024_SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            var next = head.next;
            var nextNext = next.next;

            next.next = head;
            head.next = SwapPairs(nextNext);

            return next;
        }
    }
}