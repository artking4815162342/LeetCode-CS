//-----------------------------------------------------------------------------
// Runtime: 88ms
// Runtime: 90ms
// Memory Usage: 39.6 MB
// Link: https://leetcode.com/submissions/detail/343624394/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            if (l2.val < l1.val)
            {
                l2.next = MergeTwoLists(l2.next, l1);
                return l2;
            }
            else
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
        }
    }
}
