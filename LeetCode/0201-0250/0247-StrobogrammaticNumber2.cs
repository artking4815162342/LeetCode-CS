using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public sealed class _0247_StrobogrammaticNumber2
    {
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
            var beforeCount = resultInfo.Builders.Count;
            for (var i = resultInfo.Start; i < beforeCount; i++)
            {
                foreach (var pair in GetPairs())
                {
                    var oldBuilder = resultInfo.Builders[i];
                    var sb = new StringBuilder(oldBuilder.Length + 2);
                    sb.Append(pair.Item1);
                    sb.Append(oldBuilder);
                    sb.Append(pair.Item2);

                    resultInfo.Builders.Add(sb);
                }
            }

            resultInfo.Start = beforeCount;
        }

        public IList<string> FindStrobogrammatic(int n)
        {
            if (n < 1)
            {
                return new List<string>();
            }

            var oddInfo = _ResultInfo.MakeOdd();
            if (n == 1)
            {
                return oddInfo.Builders.Select(b => b.ToString()).ToList();
            }

            var evenInfo = _ResultInfo.MakeEven();
            if (n == 2)
            {
                evenInfo.Builders.RemoveAt(0);
                return evenInfo.Builders.Select(b => b.ToString()).ToList();
            }

            if (n % 2 != 0)
            {
                for (var i = 3; i <= n; i += 2)
                {
                    Enrich(oddInfo);
                }
            }
            else
            {
                for (var i = 4; i <= n; i += 2)
                {
                    Enrich(evenInfo);
                }
            }

            var resultInfo = n % 2 != 0 ? oddInfo : evenInfo;
            return resultInfo.Builders
                .Where((sb, index) => sb[0] != '0' && index >= resultInfo.Start)
                .Select(builder => builder.ToString())
                .ToList();
        }

        private sealed class _ResultInfo
        {
            public List<StringBuilder> Builders;
            public int Start;

            private _ResultInfo()
            {
            }

            public static _ResultInfo MakeOdd()
            {
                return new()
                {
                    Builders = new List<StringBuilder>()
                    {
                        new("0"),
                        new("1"),
                        new("8"),
                    },
                    Start = 0,
                };
            }

            public static _ResultInfo MakeEven()
            {
                return new()
                {
                    Builders = new List<StringBuilder>()
                    {
                        new("00"),
                        new("11"),
                        new("69"),
                        new("88"),
                        new("96"),
                    },
                    Start = 0,
                };
            }
        }
    }
}