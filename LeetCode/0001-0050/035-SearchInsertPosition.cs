//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.7 MB
// Link: https://leetcode.com/submissions/detail/351806714/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _035_SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int low = 0, high = nums.Length;

            while (low < high)
            {
                var mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }

                else high = mid;
            }

            return low;
        }
    }
}