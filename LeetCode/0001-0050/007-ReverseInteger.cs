//-----------------------------------------------------------------------------
// Runtime: 40ms
// Runtime: 30ms
// Memory Usage: 14.6 MB
// Memory Usage: 28.5 MB
// Link: https://leetcode.com/submissions/detail/359575927/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _007_ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x == int.MinValue)
            {
                return 0;
            }

            var sign = Math.Sign(x);
            x = Math.Abs(x);
            var result = 0;

            var lg = Math.Floor(Math.Log10(x));
            var @decimal = (int) Math.Pow(10, lg);

            while (x > 0)
            {
                try
                {
                    checked
                    {
                        result += @decimal * (x % 10);
                    }
                }
                catch (Exception)
                {
                    return 0;
                }

                x /= 10;
                @decimal /= 10;
            }

            return result * sign;
        }
    }
}