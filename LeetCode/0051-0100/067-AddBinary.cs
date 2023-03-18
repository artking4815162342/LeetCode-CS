//-----------------------------------------------------------------------------
// Runtime: 80ms
// Runtime: 77ms
// Memory Usage: 25 MB
// Memory Usage: 38.4 MB
// Link: https://leetcode.com/submissions/detail/352778888/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _067_AddBinary
    {
        public string AddBinary(string a, string b)
        {
            var sb = new StringBuilder();
            var mem = 0;
            var index1 = a.Length - 1;
            var index2 = b.Length - 1;

            while (true)
            {
                var sum = GetDigitByIndex(a, index1) + GetDigitByIndex(b, index2) + mem;
                var value = sum % 2;
                mem = sum / 2;

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

        private int GetDigitByIndex(string num, int index)
        {
            if (index >= num.Length || index < 0)
            {
                return 0;
            }

            return num[index] - '0';
        }
    }
}