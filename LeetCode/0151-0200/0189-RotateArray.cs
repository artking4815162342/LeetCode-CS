//-----------------------------------------------------------------------------
// Runtime: 232ms
// Runtime: 159ms
// Memory Usage: 32.8 MB
// Memory Usage: 70.8 MB
// Link: https://leetcode.com/submissions/detail/409217846/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0189_RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            var list = ArrayToList(nums);
            var resultList = RotateRight(list, k);
            ListToArrayBuffer(resultList, nums);
        }

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

        private static ListNode ArrayToList(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            var head = new ListNode(nums[0]);
            var node = head;

            if (nums.Length == 1)
            {
                return head;
            }

            for (var i = 1; i < nums.Length; i++)
            {
                node.next = new ListNode(nums[i]);
                node = node.next;
            }

            return head;
        }

        private static void ListToArrayBuffer(ListNode head, int[] buffer)
        {
            var index = 0;
            while (head != null)
            {
                buffer[index] = head.val;
                index++;
                head = head.next;
            }
        }
    }
}