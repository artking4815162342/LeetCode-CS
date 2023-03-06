using System;
using System.Collections.Generic;

namespace LeetCode
{
    public sealed class _0248_StrobogrammaticNumber3
    {
        public int StrobogrammaticInRange(string low, string high)
        {
            var n = high.Length;
            var oddInfo = _ResultInfo.MakeOdd();
            var evenInfo = _ResultInfo.MakeEven();

            for (var i = 3; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Enrich(oddInfo);
                }
                else
                {
                    Enrich(evenInfo);
                }
            }

            return Calc(oddInfo, low.ToCharArray(), high.ToCharArray()) +
                   Calc(evenInfo, low.ToCharArray(), high.ToCharArray());
        }

        private int Calc(_ResultInfo resultInfo, char[] low, char[] high)
        {
            var sum = 0;
            foreach (var num in resultInfo.Chars)
            {
                if (num[0] == '0' && num.Length > 1)
                {
                    continue;
                }

                if (IsBiggerOrEqual(num, low) && IsBiggerOrEqual(high, num))
                {
                    sum++;
                }
            }

            return sum;
        }

        private bool IsBiggerOrEqual(char[] num0, char[] num1)
        {
            if (num0.Length > num1.Length)
            {
                return true;
            }

            if (num0.Length < num1.Length)
            {
                return false;
            }

            for (var i = 0; i < num0.Length; i++)
            {
                if (num0[i] > num1[i])
                {
                    return true;
                }

                if (num0[i] < num1[i])
                {
                    return false;
                }
            }

            return true;
        }

        private IEnumerable<(char, char)> GetPairs()
        {
            yield return ('0', '0');
            yield return ('1', '1');
            yield return ('6', '9');
            yield return ('8', '8');
            yield return ('9', '6');
        }

        private void Enrich(_ResultInfo resultInfo)
        {
            var beforeCount = resultInfo.Chars.Count;
            for (var i = resultInfo.Start; i < beforeCount; i++)
            {
                foreach (var pair in GetPairs())
                {
                    var old = resultInfo.Chars[i];
                    var @new = new char[old.Length + 2];

                    @new[0] = pair.Item1;
                    Array.Copy(old, 0, @new, 1, old.Length);
                    @new[@new.Length - 1] = pair.Item2;

                    resultInfo.Chars.Add(@new);
                }
            }

            resultInfo.Start = beforeCount;
        }

        private sealed class _ResultInfo
        {
            public List<char[]> Chars;
            public int Start;

            private _ResultInfo()
            {
            }

            public static _ResultInfo MakeOdd()
            {
                return new()
                {
                    Chars = new List<char[]>
                    {
                        new[] {'0'},
                        new[] {'1'},
                        new[] {'8'},
                    },
                    Start = 0,
                };
            }

            public static _ResultInfo MakeEven()
            {
                return new()
                {
                    Chars = new List<char[]>
                    {
                        new[] {'0', '0'},
                        new[] {'1', '1'},
                        new[] {'6', '9'},
                        new[] {'8', '8'},
                        new[] {'9', '6'},
                    },
                    Start = 0,
                };
            }
        }
    }
}