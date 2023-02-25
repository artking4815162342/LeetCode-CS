using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _009_PalindromeNumber_Test
    {
        [TestMethod]
        public void IsPalindromeTest_SingleDigit()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(0);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindromeTest_NegativeNumber()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(-1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindromeTest_MultipleDigit()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(11);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(121);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(1231);
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void IsPalindromeTest_MultipleDigit1()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(123321);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(10001);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(600);
            Assert.IsFalse(result);
        }
    }
}
