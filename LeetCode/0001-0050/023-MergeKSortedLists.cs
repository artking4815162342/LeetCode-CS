//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 42.6 MB
// Link: https://leetcode.com/submissions/detail/365343393/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _023_MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            return lists.Length == 0
                ? null
                : DeviceAndConquerMerge(lists, 0, lists.Length - 1);
        }

        private ListNode DeviceAndConquerMerge(ListNode[] lists, int left, int right)
        {
            if (left == right)
            {
                return lists[left];
            }
            else
            {
                var middle = (left + right) / 2;
                var mergedLeft = DeviceAndConquerMerge(lists, left, middle);
                var mergedRight = DeviceAndConquerMerge(lists, middle + 1, right);
                return MergeTwo(mergedLeft, mergedRight);
            }
        }

        private ListNode MergeTwo(ListNode list0, ListNode list1)
        {
            if (list1 == null && list0 == null)
            {
                return null;
            }

            if (list1 == null)
            {
                return list0;
            }

            if (list0 == null)
            {
                return list1;
            }

            if (list0.val < list1.val)
            {
                list0.next = MergeTwo(list0.next, list1);
                return list0;
            }
            else
            {
                list1.next = MergeTwo(list1.next, list0);
                return list1;
            }
        }
    }
}