//-----------------------------------------------------------------------------
// Runtime: 140ms
// Runtime: 133ms
// Memory Usage: - 
// Memory Usage: 47.4 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _043_MultiplyStrings
    {
        private readonly object locker = new();
        private List<string> multipliedList;

        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
            {
                return "0";
            }

            if (num2.Length > num1.Length)
            {
                (num1, num2) = (num2, num1);
            }

            multipliedList = new List<string>(num2.Length);
            System.Threading.Tasks.Parallel.For(0, num2.Length, MultiplyDigit);

            return multipliedList.Aggregate(AddStrings);

            void MultiplyDigit(int index)
            {
                var sum = MultiplyStringByDigit(num1, num2, index);
                lock (locker)
                {
                    multipliedList.Add(sum);
                }
            }
        }

        private int GetDigitByIndex(string num, int index)
        {
            if (index >= num.Length || index < 0)
            {
                return 0;
            }

            return num[index] - '0';
        }

        private string MultiplyStringByDigit(string num1, string num2, int index)
        {
            var sb = new StringBuilder();
            var mem = 0;
            var index1 = num1.Length - 1;
            var digitByIndex = GetDigitByIndex(num2, index);

            while (true)
            {
                var sum = GetDigitByIndex(num1, index1) * digitByIndex + mem;
                var value = sum % 10;
                mem = sum / 10;

                sb.Insert(0, value);
                index1--;

                if (index1 < 0 && mem <= 0)
                {
                    break;
                }
            }

            for (var i = 0; i < num2.Length - index - 1; i++)
            {
                sb.Append('0');
            }

            return sb.ToString();
        }

        private string AddStrings(string num1, string num2)
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