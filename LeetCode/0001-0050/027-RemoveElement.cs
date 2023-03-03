//-----------------------------------------------------------------------------
// Runtime: 236ms
// Runtime: 130ms
// Memory Usage: 30.1 MB
// Memory Usage: 42.7  MB
// Link: https://leetcode.com/submissions/detail/351897187/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _027_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            var nextIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[nextIndex] = nums[i];
                    nextIndex++;
                }
            }

            return nextIndex;
        }
    }
}