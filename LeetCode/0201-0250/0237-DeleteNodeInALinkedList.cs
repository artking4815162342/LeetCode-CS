//-----------------------------------------------------------------------------
// Runtime: 96ms
// Runtime: 84ms
// Memory Usage: 24.2 MB
// Memory Usage: 39.1 MB
// Link: https://leetcode.com/submissions/detail/263755695/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0237_DeleteNodeInALinkedList
    {
        public void DeleteNode(ListNode node)
        {
            if (node?.next == null)
            {
                return;
            }

            node.val = node.next.val;

            if (node.next.next == null)
            {
                node.next = null;
                return;
            }

            DeleteNode(node.next);
        }
    }
}