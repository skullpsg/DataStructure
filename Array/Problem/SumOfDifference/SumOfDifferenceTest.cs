using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Array.Problem.SumOfDifference
{
    [TestFixture]
    public class SumOfDifferenceTest
    {
        [Test]
        public void ShouldReturnSumOfDiff()
        {
            int[] arr = new int[2] { 2, 1 };
            var sum = new SumOfDifference();
            int resulted = sum.Sum(arr);
            Assert.AreEqual(resulted, 3);
        }
    }
}
