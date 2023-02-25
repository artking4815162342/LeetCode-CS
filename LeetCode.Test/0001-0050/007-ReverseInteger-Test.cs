using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _007_ReverseInteger_Test
    {
        [TestMethod]
        public void ReverseTest_Positive()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(1);
            Assert.AreEqual(1, result);

            result = solution.Reverse(123);
            Assert.AreEqual(321, result);

            result = solution.Reverse(321);
            Assert.AreEqual(123, result);
        }
        
        [TestMethod]
        public void ReverseTest_Positive2()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(900000);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void ReverseTest_Negative()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(-1);
            Assert.AreEqual(-1, result);

            result = solution.Reverse(-123);
            Assert.AreEqual(-321, result);

            result = solution.Reverse(-321);
            Assert.AreEqual(-123, result);
        }
        
        [TestMethod]
        public void ReverseTest_Negative2()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(-2147483412);
            Assert.AreEqual(-2143847412, result);
        }

        [TestMethod]
        public void ReverseTest_EqualZero()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReverseTest_PositiveOverflow()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(1534236469);
            Assert.AreEqual(0, result);
            
            result = solution.Reverse(1563847412);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReverseTest_PositiveOverflow2()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(2147483647);
            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void ReverseTest_NegativeOverflow()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(-1534236469);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReverseTest_OverflowExtremum()
        {
            var solution = new _007_ReverseInteger();
            var result = solution.Reverse(int.MinValue);
            Assert.AreEqual(0, result);

            result = solution.Reverse(int.MaxValue);
            Assert.AreEqual(0, result);
        }
    }
}