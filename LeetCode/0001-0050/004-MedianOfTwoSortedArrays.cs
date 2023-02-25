//-----------------------------------------------------------------------------
// Runtime: 112ms
// Runtime: 104ms
// Memory Usage: 51 MB
// Link: https://leetcode.com/submissions/detail/378077964/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _004_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 && nums2.Length == 0)
            {
                return 0d;
            }

            var merged = new List<int>(Math.Max(nums1.Length, nums1.Length));
            var index1 = 0;
            var index2 = 0;

            while (true)
            {
                var has1 = TryGetCurrentNumber(nums1, index1, out var num1);
                var has2 = TryGetCurrentNumber(nums2, index2, out var num2);

                if (!has1 && !has2)
                {
                    break;
                }

                if (!has1)
                {
                    merged.Add(num2);
                    index2++;
                }
                else if (!has2)
                {
                    merged.Add(num1);
                    index1++;
                }
                else if (num1 < num2)
                {
                    merged.Add(num1);
                    index1++;
                }
                else
                {
                    merged.Add(num2);
                    index2++;
                }
            }

            return GetMedian(merged);
        }

        private bool TryGetCurrentNumber(int[] nums, int index, out int result)
        {
            if (index >= nums.Length)
            {
                result = default;
                return false;
            }

            result = nums[index];
            return true;
        }

        private double GetMedian(List<int> merged)
        {
            var position = merged.Count / 2;
            if (merged.Count % 2 == 0)
            {
                return (merged[position] + merged[position - 1]) / 2d;
            }
            else
            {
                return merged[position];
            }
        }
    }
}