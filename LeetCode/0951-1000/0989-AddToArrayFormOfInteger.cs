//-----------------------------------------------------------------------------
// Runtime: 284ms
// Runtime: 167ms
// Memory Usage: 38.8 MB
// Memory Usage: 55.6 MB
// Link: https://leetcode.com/submissions/detail/352428880/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0989_AddToArrayFormOfInteger
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            return AddStrings(num, k.ToString());
        }

        private int GetDigitByIndex(string num, int index)
        {
            if (index >= num.Length || index < 0)
            {
                return 0;
            }

            return num[index] - '0';
        }

        private int GetDigitByIndex(int[] num, int index)
        {
            if (index >= num.Length || index < 0)
            {
                return 0;
            }

            return num[index];
        }

        private IList<int> AddStrings(int[] num1, string num2)
        {
            var result = new List<int>(num1.Length);
            var mem = 0;
            var index1 = num1.Length - 1;
            var index2 = num2.Length - 1;

            while (true)
            {
                var sum = GetDigitByIndex(num1, index1) + GetDigitByIndex(num2, index2) + mem;
                var value = sum % 10;
                mem = sum / 10;

                result.Add(value);
                index1--;
                index2--;

                if (index1 < 0 && index2 < 0 && mem <= 0)
                {
                    break;
                }
            }

            result.Reverse();
            return result;
        }
    }
}