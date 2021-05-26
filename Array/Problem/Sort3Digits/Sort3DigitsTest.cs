using Datastructure.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Array.Problem.Sort3Digits
{
    [TestFixture]
    class Sort3DigitsTest
    {

        [Test]
        public void ShouldSort3DigitUsingDutchFlagForSortedNumbers()
        {
            var expectedOutputs = new List<int>() { 1, 2, 3 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            var Sort3Digits = new Sort3Digits(writerMock);
            var input = new int[] { 1, 2, 3 };
            Sort3Digits.Sort(input);
        }

        [Test]
        public void ShouldSort3DigitUsingDutchFlag()
        {
            var expectedOutputs = new List<int>() { 0, 0, 1, 1, 1, 2, 2 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            var Sort3Digits = new Sort3Digits(writerMock);
            var input = new int[] { 1, 0, 2, 0, 1, 1, 2 };
            Sort3Digits.Sort(input);
        }
    }
}
