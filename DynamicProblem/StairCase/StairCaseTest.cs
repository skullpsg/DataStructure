using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.DynamicProblem.StairCase
{
    [TestFixture]
    class StairCaseTest
    {
        [Test]
        public void ShouldReturnNoOfPossibilities() {
            var stairCase = new StairCase();
            int possibilities = stairCase.GetPossibilities(3,new Dictionary<int, int>());
            Assert.AreEqual(4,possibilities);
        }

    }
}
