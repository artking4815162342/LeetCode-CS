using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public sealed class _0372_SuperPow_Test
    {
        [TestMethod]
        public void SuperPowPositive0()
        {
            var solution = new _0372_SuperPow();
            var result = solution.SuperPow(2, new[] {3});
            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void SuperPowPositive1()
        {
            var solution = new _0372_SuperPow();
            var result = solution.SuperPow(2, new[] {1, 0});
            Assert.AreEqual(result, 1024);
        }

        [TestMethod]
        public void SuperPowPositive2()
        {
            var solution = new _0372_SuperPow();
            var result = solution.SuperPow(1, new[] {4, 3, 3, 8, 5, 2});
            Assert.AreEqual(result, 1);
        }
        
        [TestMethod]
        public void SuperPowPositive3()
        {
            var solution = new _0372_SuperPow();
            var result = solution.SuperPow(2, new[] {1,2});
            Assert.AreEqual(result, 4096 % 1337);
        }

        [TestMethod]
        public void SuperPowPositive4()
        {
            var solution = new _0372_SuperPow();
            var result = solution.SuperPow(2147483647, new[] {2,0,0});
            Assert.AreEqual(result, 1198);
        }
        
        [TestMethod]
        public void SuperPowOne()
        {
            var solution = new _0372_SuperPow();
            var result = solution.SuperPow(2, new[] {1});
            Assert.AreEqual(result, 2);
        }
    }
}