//-----------------------------------------------------------------------------
// Runtime: 112ms
// Runtime: 94ms
// Memory Usage: 27.3 MB
// Link: https://leetcode.com/submissions/detail/378602405/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode();
            var current = result;
            
            var mem = 0;

            while (true)
            {
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + mem;
                var value = sum % 10;
                mem = sum / 10;

                l1 = l1?.next;
                l2 = l2?.next;

                if (l1 == null && l2 == null && mem <= 0 && value <= 0)
                {
                    break;
                }

                var node = new ListNode(value);
                current.next = node;
                current = node;
            }

            return result.next ?? result;
        }
    }
}