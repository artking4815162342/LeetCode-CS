//-----------------------------------------------------------------------------
// Runtime: 149ms
// Memory Usage: 43.9
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _080_RemoveDuplicatesFromSortedArray2
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return nums.Length;
            }

            var nextIndex = 1;
            var memoryCount = 1;
            var memory = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] == memory)
                {
                    if (memoryCount < 2)
                    {
                        nums[nextIndex] = memory;
                        nextIndex++;
                    }

                    memoryCount++;
                    continue;
                }

                nums[nextIndex] = nums[i];
                nextIndex++;

                memoryCount = 1;
                memory = nums[i];
            }

            return nextIndex;
        }
    }
}