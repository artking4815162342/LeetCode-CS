//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 40.8 MB
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _025_ReverseNodesInKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k <= 1)
            {
                return head;
            }

            var count = CountList(head);
            if (k > count)
            {
                return head;
            }

            ListNode result = null;
            ListNode iterationNode = null;
            ListNode iterationTail = head;

            var reverseCount = count / k;
            for (var i = 0; i < reverseCount; i++)
            {
                var groupTail = iterationNode;
                var group = ReverseKGroupInternal(iterationTail, out iterationTail, out iterationNode, k);
                if (result == null)
                {
                    result = group;
                }
                else
                {
                    groupTail.next = group;
                }
            }

            if (iterationNode != null)
            {
                iterationNode.next = iterationTail;
            }

            return result;
        }

        private ListNode ReverseKGroupInternal(ListNode head, out ListNode tail, out ListNode node, int k)
        {
            if (k <= 1 || head.next == null)
            {
                node = head;
                tail = head.next;
                return head;
            }

            var result = ReverseKGroupInternal(head.next, out tail, out node, k - 1);
            node.next = head;
            node = node.next;

            return result;
        }

        private int CountList(ListNode head)
        {
            if (head == null)
            {
                return 0;
            }

            return 1 + CountList(head.next);
        }
    }
}