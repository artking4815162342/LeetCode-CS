//-----------------------------------------------------------------------------
// Runtime: 228ms
// Runtime: 145ms
// Memory Usage: 30.1 MB
// Memory Usage: 41.8 MB
// Link: https://leetcode.com/submissions/detail/352820219/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _066_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            return AddStrings(digits, "1").Reverse().ToArray();
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

        private IEnumerable<int> AddStrings(int[] num1, string num2)
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

            return result;
        }
    }
}