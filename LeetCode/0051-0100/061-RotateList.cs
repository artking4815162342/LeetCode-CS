//-----------------------------------------------------------------------------
// Runtime: 84ms
// Runtime: 85ms
// Memory Usage: 39.1 MB
// Link: https://leetcode.com/submissions/detail/408819041/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _061_RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k <= 0)
            {
                return head;
            }

            var listInfo = GetListInfo(head, 0);

            k %= listInfo.cout;

            if (listInfo.cout <= 1 || k == 0)
            {
                return head;
            }

            var index = 0;
            var target = listInfo.cout - k;
            var node = head;
            while (index < target - 1)
            {
                node = node.next;
                index++;
            }

            var result = node.next;
            listInfo.tail.next = head;
            node.next = null;

            return result;
        }

        private (int cout, ListNode tail) GetListInfo(ListNode head, int count)
        {
            if (head.next == null)
            {
                return (count + 1, head);
            }

            return GetListInfo(head.next, count + 1);
        }
    }
}