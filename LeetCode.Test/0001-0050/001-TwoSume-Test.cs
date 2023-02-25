using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _001_TwoSum_Test
    {
        [TestMethod]
        public void TwoSumTest_Ordered()
        {
            var nums = new int[] {2, 7, 11, 15};
            var target = 9;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void TwoSumTest_Unordered()
        {
            var nums = new int[] {5, 75, 25};
            var target = 100;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod]
        public void TwoSumTest_Duplicate()
        {
            var nums = new int[] {4, 5, 15, 30};
            var target = 20;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod]
        public void TwoSumTest_AllSame()
        {
            var nums = new int[] {5, 5, 5, 5, 5};
            var target = 10;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void TwoSumTest_NoTarget()
        {
            var nums = new int[] {2, 7, 11, 15};
            var target = 5;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(0, result.Length);
        }
    }
}