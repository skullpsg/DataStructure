using Datastructure.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.DynamicProblem.NQueen
{
    [TestFixture]
    public class NQueenTest
    {
        [Test]
        public void ShouldPrintNQueen()
        {
            var expectedOutputs = new List<String>() { "0,0", "1,4", "2,7", "3,5", "4,2", "5,6", "6,1", "7,3" };
            IConsoleWriter writerMock = MockWriter.GetInstanceForString(expectedOutputs);
            NQueen nqueen = new NQueen(writerMock);
            int[] cols = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };
            nqueen.PlaceNQueen(cols, 0);
        }
    }
}
