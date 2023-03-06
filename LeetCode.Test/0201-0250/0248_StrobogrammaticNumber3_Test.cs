using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public sealed class _0248_StrobogrammaticNumber3_Test
    {
        [TestMethod]
        public void StrobogrammaticInRange0()
        {
            var solution = new _0248_StrobogrammaticNumber3();
            var result = solution.StrobogrammaticInRange("0", "0");
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void StrobogrammaticInRange1()
        {
            var solution = new _0248_StrobogrammaticNumber3();
            var result = solution.StrobogrammaticInRange("50", "100");
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void StrobogrammaticInRange2()
        {
            var solution = new _0248_StrobogrammaticNumber3();
            var result = solution.StrobogrammaticInRange("1000", "9999");
            Assert.AreEqual(result, 20);
        }
    }
}