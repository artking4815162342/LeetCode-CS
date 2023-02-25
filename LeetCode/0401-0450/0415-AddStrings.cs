//-----------------------------------------------------------------------------
// Runtime: 84ms
// Runtime: 82ms
// Memory Usage: 25.6 MB
// Memory Usage: 39.3 MB
// Link: https://leetcode.com/submissions/detail/352313138/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _0415_AddStrings
    {
        private int GetDigitByIndex(string num, int index)
        {
            if (index >= num.Length || index < 0)
            {
                return 0;
            }

            return num[index] - '0';
        }

        public string AddStrings(string num1, string num2)
        {
            var sb = new StringBuilder();
            var mem = 0;
            var index1 = num1.Length - 1;
            var index2 = num2.Length - 1;

            while (true)
            {
                var sum = GetDigitByIndex(num1, index1) + GetDigitByIndex(num2, index2) + mem;
                var value = sum % 10;
                mem = sum / 10;

                sb.Insert(0, value);
                index1--;
                index2--;

                if (index1 < 0 && index2 < 0 && mem <= 0)
                {
                    break;
                }
            }

            return sb.ToString();
        }
    }
}