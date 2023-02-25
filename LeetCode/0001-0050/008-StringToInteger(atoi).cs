//-----------------------------------------------------------------------------
// Runtime: 144ms
// Runtime: 63ms
// Memory Usage: 
// Memory Usage: 38.9 MB
// Link: 
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _008_StringToInteger
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            var trimStart = true;
            var findingSign = true;
            var sign = 1;
            var builder = new StringBuilder();

            for (var i = 0; i < str.Length; i++)
            {
                var letter = str[i];
                if (trimStart)
                {
                    if (letter == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        trimStart = false;
                    }
                }

                if (findingSign && letter == '-')
                {
                    sign = -1;
                    findingSign = false;
                    continue;
                }

                if (findingSign && letter == '+')
                {
                    sign = 1;
                    findingSign = false;
                    continue;
                }

                if (char.IsDigit(letter))
                {
                    findingSign = false;
                    builder.Append(letter);
                }
                else
                {
                    break;
                }
            }

            if (builder.Length == 0)
            {
                return 0;
            }

            if (!int.TryParse(builder.ToString(), out var result))
            {
                return sign > 0 ? int.MaxValue : int.MinValue;
            }

            return result * sign;
        }
    }
}