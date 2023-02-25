using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0415_AddStrings_Test
    {
        [TestMethod]
        public void AddStrings_1()
        {
            var solution = new _0415_AddStrings();
            var result = solution.AddStrings("123", "987");
            Assert.AreEqual("1110", result);
        }

        [TestMethod]
        public void AddStrings_2()
        {
            var solution = new _0415_AddStrings();
            var result = solution.AddStrings("111", "1");
            Assert.AreEqual("112", result);
        }
        
        [TestMethod]
        public void AddStrings_3()
        {
            var solution = new _0415_AddStrings();
            var result = solution.AddStrings("11", "123");
            Assert.AreEqual("134", result);
        }
          
        [TestMethod]
        public void AddStrings_4()
        {
            var solution = new _0415_AddStrings();
            var result = solution.AddStrings("456", "77");
            Assert.AreEqual("533", result);
        }
    }
}
