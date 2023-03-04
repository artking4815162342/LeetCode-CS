using System;
using System.Numerics;

namespace LeetCode
{
    public sealed class _0372_SuperPow
    {
        public int SuperPow(int a, int[] b)
        {
            //TODO: solve issue
            return default;
            
            if (Math.Abs(a) < double.Epsilon)
            {
                return 0;
            }

            var n = MakePow(b);
            if (n == 0)
            {
                return 1;
            }

            if (n == 1)
            {
                return a;
            }

            var ln = Math.Log(a);
            var bigFractionLn = new BigFraction(ln);
            var firstMember = bigFractionLn * n;
            var result = BigFraction.One + firstMember + TaylorRow(
                n, n, bigFractionLn, bigFractionLn, 1, 2);

            var temp = new BigInteger(Math.Round(result.ToDouble()));
            return (int) (temp % 1337);
        }

        private BigInteger MakePow(int[] b)
        {
            BigInteger result = 0;
            var @decimal = 1;

            for (int i = b.Length - 1; i >= 0; i--)
            {
                result += @decimal * b[i];
                @decimal *= 10;
            }

            return result;
        }

        private BigFraction TaylorRow(
            BigInteger xOriginal,
            BigInteger xResult,
            BigFraction lnOriginal,
            BigFraction lnResult,
            BigInteger factorial,
            int iteration)
        {
            var newX = xResult * xOriginal;
            var newFactorial = factorial * iteration;
            var newLn = lnResult * lnOriginal;

            var member = new BigFraction(newX, newFactorial) * newLn;

            if (member.ToDouble() > double.Epsilon)
            {
                return member + TaylorRow(
                    xOriginal, newX, lnOriginal, newLn, newFactorial, iteration + 1);
            }
            else
            {
                return member;
            }
        }

        private struct BigFraction
        {
            private BigInteger numerator;
            private BigInteger denominator;

            public BigFraction(BigInteger numerator, BigInteger denominator)
            {
                if (denominator == BigInteger.Zero)
                {
                    throw new DivideByZeroException();
                }

                var commonDevisor = BigInteger.GreatestCommonDivisor(numerator, denominator);

                this.numerator = numerator / commonDevisor;
                this.denominator = denominator / commonDevisor;
            }

            public BigFraction(BigInteger value)
            {
                numerator = value;
                denominator = BigInteger.One;
            }

            public BigFraction(double decimalFraction)
            {
                if (Math.Abs(decimalFraction) < double.Epsilon)
                {
                    this = Zero;
                    return;
                }

                var lg = Math.Log10(decimalFraction);
                var pow = 308 - Math.Ceiling(lg);
                var maxDecimal = Math.Pow(10, pow);

                numerator = new BigInteger(decimalFraction * maxDecimal);
                denominator = new BigInteger(maxDecimal);
            }

            public void Multiply(BigInteger value)
            {
                numerator *= value;
            }

            public void Devide(BigInteger value)
            {
                denominator *= value;
            }

            public double ToDouble()
            {
                return Math.Exp(BigInteger.Log(numerator) - BigInteger.Log(denominator));
            }

            public static BigFraction operator +(BigFraction a) => a;
            public static BigFraction operator -(BigFraction a) => new(-a.numerator, a.denominator);

            public static BigFraction operator +(BigFraction a, BigFraction b)
                => new(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);

            public static BigFraction operator -(BigFraction a, BigFraction b)
                => new(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);

            public static BigFraction operator *(BigFraction a, BigFraction b)
                => new(a.numerator * b.numerator, a.denominator * b.denominator);

            public static BigFraction operator *(BigFraction a, BigInteger b)
                => new(a.numerator * b, a.denominator);

            public static BigFraction operator /(BigFraction a, BigFraction b)
            {
                if (b.numerator == 0)
                {
                    throw new DivideByZeroException();
                }

                return new BigFraction(a.numerator * b.denominator, a.denominator * b.numerator);
            }

            public static BigFraction Zero => new BigFraction(BigInteger.Zero);
            public static BigFraction One => new BigFraction(BigInteger.One);
        }
    }
}