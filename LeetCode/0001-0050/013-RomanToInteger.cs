//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/342506469/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _013_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (i > 0 && Convert(s[i]) > Convert(s[i - 1]))
                {
                    result += Convert(s[i]) - Convert(s[i - 1]) * 2;
                }
                else
                {
                    result += Convert(s[i]);
                }
            }

            return result;
        }

        private int Convert(char ch)
        {
            return ch switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };
        }
    }
}