//-----------------------------------------------------------------------------
// Runtime: 44ms
// Runtime: 29ms
// Memory Usage: 14.7 MB
// Memory Usage: 26.7 MB
// Link: https://leetcode.com/submissions/detail/359211280/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _069_Sqrt
    {
        public int MySqrt(int x)
        {
            if (x is 0 or 1)
            {
                return x;
            }

            const double half = 0.5d;
            var x0 = x * half;
            double x1;

            while (true)
            {
                x1 = half * (x0 + x / x0);

                if (Math.Abs(x0 - x1) <= half)
                {
                    break;
                }

                x0 = x1;
            }

            return (int) x1;
        }
    }
}