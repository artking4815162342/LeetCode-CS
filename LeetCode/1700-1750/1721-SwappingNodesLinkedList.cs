// Runtime: 261ms
// Memory Usage: 65.9 MB

namespace LeetCode
{
    public sealed class _1721_SwappingNodesLinkedList
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            if (head?.next == null)
            {
                return head;
            }

            var count = 0;
            ListNode target0 = null;
            ListNode target1 = null;

            FindThrees(head, k, 1, ref count, ref target0, ref target1);

            (target0.val, target1.val) = (target1.val, target0.val);

            return head;
        }

        private void FindThrees(
            ListNode head,
            int findIndex,
            int currentIndex,
            ref int count,
            ref ListNode target0,
            ref ListNode before1)
        {
            if (head == null)
            {
                return;
            }

            if (findIndex == currentIndex)
            {
                target0 = head;
            }

            count++;
            FindThrees(head.next, findIndex, currentIndex + 1, ref count, ref target0, ref before1);

            if (findIndex == count - currentIndex + 1)
            {
                before1 = head;
            }
        }
    }
}