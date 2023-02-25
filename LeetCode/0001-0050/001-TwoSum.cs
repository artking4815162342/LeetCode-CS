//-----------------------------------------------------------------------------
// Runtime: 232ms
// Runtime: 176ms
// Memory Usage: 31.3 MB
// Memory Usage: 44.1 MB
// Link: https://leetcode.com/submissions/detail/352344600/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; ++i)
            {
                for (var j = i + 1; j < nums.Length; ++j)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }

            return new int[] { };
        }
    }
}