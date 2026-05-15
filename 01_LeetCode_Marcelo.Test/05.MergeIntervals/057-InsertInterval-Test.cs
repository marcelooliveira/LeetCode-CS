using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _057_InsertInterval_Test
    {
        [TestMethod]
        public void InsertTest_NoOverlap_Before()
        {
            var input = new[]
            {
                new Interval(4, 6),
                new Interval(8, 10)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(1, 3));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(3, result[0].end);
            Assert.AreEqual(4, result[1].start);
            Assert.AreEqual(6, result[1].end);
            Assert.AreEqual(8, result[2].start);
            Assert.AreEqual(10, result[2].end);
        }

        [TestMethod]
        public void InsertTest_NoOverlap_Middle()
        {
            var input = new[]
            {
                new Interval(1, 3),
                new Interval(8, 10)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(4, 6));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(3, result[0].end);
            Assert.AreEqual(4, result[1].start);
            Assert.AreEqual(6, result[1].end);
            Assert.AreEqual(8, result[2].start);
            Assert.AreEqual(10, result[2].end);
        }

        [TestMethod]
        public void InsertTest_NoOverlap_Last()
        {
            var input = new[]
            {
                new Interval(1, 3),
                new Interval(4, 6)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(8, 10));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(3, result[0].end);
            Assert.AreEqual(4, result[1].start);
            Assert.AreEqual(6, result[1].end);
            Assert.AreEqual(8, result[2].start);
            Assert.AreEqual(10, result[2].end);
        }

        [TestMethod]
        public void InsertTest_Overlap()
        {
            var input = new[]
            {
                new Interval(1, 3),
                new Interval(6, 9)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(2, 5));

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(5, result[0].end);
            Assert.AreEqual(6, result[1].start);
            Assert.AreEqual(9, result[1].end);
        }

        [TestMethod]
        public void InsertTest_MultipleOverlap()
        {
            var input = new[]
            {
                new Interval(1, 2),
                new Interval(3, 5),
                new Interval(6, 7),
                new Interval(8, 10),
                new Interval(12, 16)
            };

            var solution = new _057_InsertInterval();
            var result = solution.Insert(input, new Interval(4, 9));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].start);
            Assert.AreEqual(2, result[0].end);
            Assert.AreEqual(3, result[1].start);
            Assert.AreEqual(10, result[1].end);
            Assert.AreEqual(12, result[2].start);
            Assert.AreEqual(16, result[2].end);
        }

        [TestMethod]
        public void InsertTest_EmptyIntervals()
        {
            var solution = new _057_InsertInterval();
            var result = solution.Insert(new Interval[] { }, new Interval(4, 6));

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(4, result[0].start);
            Assert.AreEqual(6, result[0].end);
        }

		[TestMethod]
		public void InsertTest_OneInterval()
		{
			var input = new[]
			{
				new Interval(1, 5)
			};

			var solution = new _057_InsertInterval();
			var result = solution.Insert(input, new Interval(2, 3));

			Assert.AreEqual(1, result.Count);
			Assert.AreEqual(1, result[0].start);
			Assert.AreEqual(5, result[0].end);
		}

		[TestMethod]
		public void InsertTest_Overlap2()
		{
			var input = new[]
			{
				new Interval(0,0),
				new Interval(2,2),
				new Interval(3,3),
				new Interval(5,20)
			};

			var solution = new _057_InsertInterval();
			var result = solution.Insert(input, new Interval(15, 17));

			Assert.AreEqual(4, result.Count);
			Assert.AreEqual(0, result[0].start);
			Assert.AreEqual(0, result[0].end);
			Assert.AreEqual(2, result[1].start);
			Assert.AreEqual(2, result[1].end);
			Assert.AreEqual(3, result[2].start);
			Assert.AreEqual(3, result[2].end);
			Assert.AreEqual(5, result[3].start);
			Assert.AreEqual(20, result[3].end);
		}

		[TestMethod]
		public void InsertTest_3()
		{
			var input = new[]
			{
				new Interval(6,10),
				new Interval(13,16),
				new Interval(19,19),
				new Interval(23,25),
				new Interval(34,39),
				new Interval(41,43),
				new Interval(49,51)
			};

			var solution = new _057_InsertInterval();
			var result = solution.Insert(input, new Interval(27,27));

			Assert.AreEqual(8, result.Count);

			Assert.AreEqual(6, result[0].start);
			Assert.AreEqual(10, result[0].end);
			Assert.AreEqual(13, result[1].start);
			Assert.AreEqual(16, result[1].end);
			Assert.AreEqual(19, result[2].start);
			Assert.AreEqual(19, result[2].end);
			Assert.AreEqual(23, result[3].start);
			Assert.AreEqual(25, result[3].end);
			Assert.AreEqual(27, result[4].start);
			Assert.AreEqual(27, result[4].end);
			Assert.AreEqual(34, result[5].start);
			Assert.AreEqual(39, result[5].end);
			Assert.AreEqual(41, result[6].start);
			Assert.AreEqual(43, result[6].end);
			Assert.AreEqual(49, result[7].start);
			Assert.AreEqual(51, result[7].end);
		}
	}
}
