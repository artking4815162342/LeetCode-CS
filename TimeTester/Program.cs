using LeetCode;

namespace TimeTester;

public static class TimeTester
{
    public static void Main(string[] args)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        var times = 100000;

        var solution = new _0248_StrobogrammaticNumber3();
        for (int i = 0; i < times; i++)
        {
            var result = solution.StrobogrammaticInRange("0", "9999999999");
        }

        watch.Stop();
        var time = watch.ElapsedMilliseconds / (double) times;
        Console.WriteLine($"Time: {time}");
    }
}