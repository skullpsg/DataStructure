using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Array.Problem._2Sum
{
    [TestFixture]
    class TwoSumTest
    {
        [Test]
        public void ShouldReturnIndexes()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            TwoSum twoSum = new TwoSum();
            int target = 9;
            var expectedResult = new int[] { 0, 1 };
            var actualResult = twoSum.GetSum(nums, target);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
