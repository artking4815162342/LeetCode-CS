using System.Collections.Generic;
using System.Linq;

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
            var beforeCount = resultInfo.List.Count;
            for (var i = resultInfo.Start; i < beforeCount; i++)
            {
                foreach (var pair in GetPairs())
                {
                    resultInfo.List.Add($"{pair.Item1}{resultInfo.List[i]}{pair.Item2}");
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
                return oddInfo.List;
            }

            var evenInfo = _ResultInfo.MakeEven();
            if (n == 2)
            {
                evenInfo.List.RemoveAt(0);
                return evenInfo.List;
            }

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

            var resultInfo = n % 2 != 0 ? oddInfo : evenInfo;
            return resultInfo.List
                .Where((s, index) => s[0] != '0' && index >= resultInfo.Start)
                .ToList();
        }

        private sealed class _ResultInfo
        {
            public List<string> List;
            public int Start;

            private _ResultInfo()
            {
            }

            public static _ResultInfo MakeOdd()
            {
                return new()
                {
                    List = new List<string>() {"0", "1", "8"},
                    Start = 0,
                };
            }

            public static _ResultInfo MakeEven()
            {
                return new()
                {
                    List = new List<string>() {"00", "11", "69", "88", "96"},
                    Start = 0,
                };
            }
        }
    }
}