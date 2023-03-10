using LeetCode.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode
{
    [TestClass]
    public sealed class _1721_SwappingNodesLinkedList_Test
    {
        [TestMethod]
        public void SwapPairsTest0()
        {
            var input = TestHelper.GenerateList(new int[] {1, 2, 3, 4, 5});

            var solution = new _1721_SwappingNodesLinkedList();
            var result = solution.SwapNodes(input, 2);

            AssertHelper.AssertLinkList(new int[] {1, 4, 3, 2, 5}, result);
        }

        [TestMethod]
        public void SwapPairsTest1()
        {
            var input = TestHelper.GenerateList(new int[] {1, 2, 3, 4});

            var solution = new _1721_SwappingNodesLinkedList();
            var result = solution.SwapNodes(input, 2);

            AssertHelper.AssertLinkList(new int[] {1, 3, 2, 4}, result);
        }

        [TestMethod]
        public void SwapPairsTest2()
        {
            var input = TestHelper.GenerateList(new int[] {7, 9, 6, 6, 7, 8, 3, 0, 9, 5});

            var solution = new _1721_SwappingNodesLinkedList();
            var result = solution.SwapNodes(input, 5);

            AssertHelper.AssertLinkList(new int[] {7, 9, 6, 6, 8, 7, 3, 0, 9, 5}, result);
        }

        [TestMethod]
        public void SwapPairsTest3()
        {
            var input = TestHelper.GenerateList(new int[] {1, 2});

            var solution = new _1721_SwappingNodesLinkedList();
            var result = solution.SwapNodes(input, 1);

            AssertHelper.AssertLinkList(new int[] {2, 1}, result);
        }

        [TestMethod]
        public void SwapPairsTest4()
        {
            var input = TestHelper.GenerateList(new int[] {80, 46, 66, 35, 64});

            var solution = new _1721_SwappingNodesLinkedList();
            var result = solution.SwapNodes(input, 1);

            AssertHelper.AssertLinkList(new int[] {64, 46, 66, 35, 80}, result);
        }

        [TestMethod]
        public void SwapPairsTest5()
        {
            var input = TestHelper.GenerateList(new int[] {1, 2, 3, 4});

            var solution = new _1721_SwappingNodesLinkedList();
            var result = solution.SwapNodes(input, 3);

            AssertHelper.AssertLinkList(new int[] {1, 3, 2, 4}, result);
        }

        [TestMethod]
        public void SwapPairsTest6()
        {
            var input = TestHelper.GenerateList(new int[] {1, 2});

            var solution = new _1721_SwappingNodesLinkedList();
            var result = solution.SwapNodes(input, 2);

            AssertHelper.AssertLinkList(new int[] {2, 1}, result);
        }
    }
}