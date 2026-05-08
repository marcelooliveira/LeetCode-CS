using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _011_ContainerWithMostWater_Test
    {
        [TestMethod]
        public void MaxAreaTest_General_1()
        {
            int[] input = { 1, 1 };

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MaxAreaTest_General_2()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void MaxAreaTest_General_3()
        {
            int[] input = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.AreEqual(49, result);
        }
    }
}
