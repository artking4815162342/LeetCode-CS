//-----------------------------------------------------------------------------
// Runtime: 248ms
// Runtime: 143ms
// Memory Usage: 33.4 MB
// Memory Usage: 45.9 MB
// Link: https://leetcode.com/submissions/detail/352419066/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _026_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length;
            }

            var nextIndex = 1;
            var memory = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] == memory)
                {
                    continue;
                }

                nums[nextIndex] = nums[i];
                
                memory = nums[i];
                nextIndex++;
            }
            
            return nextIndex;
        }
    }
}