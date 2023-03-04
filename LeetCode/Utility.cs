namespace LeetCode
{
    internal static class Utility
    {
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