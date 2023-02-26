//-----------------------------------------------------------------------------
// Runtime: 48ms
// Runtime: 23ms
// Memory Usage: 26.8 MB
// Link: https://leetcode.com/submissions/detail/367515347/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _050_Pow
    {
        public double MyPow(double x, int n)
        {
            if (Math.Abs(x) < double.Epsilon)
            {
                return 0;
            }

            switch (n)
            {
                case 0:
                    return 1;
                case 1:
                    return x;
            }

            var half = MyPow(x, Math.Abs(n / 2));

            if (n % 2 == 0)
            {
                return n > 0 ? half * half : 1 / (half * half);
            }
            else
            {
                return n > 0 ? half * half * x : 1 / (half * half * x);
            }
        }
    }
}