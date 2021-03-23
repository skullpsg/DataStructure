using Datastructure.Common;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Datastructure.LinkedList.Test
{

    [TestFixture]
    public class LinkedListDSTest
    {

        [Test]
        public void ShouldPrintLinkedList()
        {
            var expectedOutputs = new List<int>() { 1, 2, 3 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);

            LinkedListDS linkedList = GetLinkedList(writerMock);

            linkedList.Result();
        }


        [Test]
        public void ShouldReverseLinkedList()
        {

            var expectedOutputs = new List<int>() { 3, 2, 1 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);

            LinkedListDS linkedList = GetLinkedList(writerMock);

            linkedList.Reverse();

            linkedList.Result();
        }


        [Test]
        public void ShouldAddNodeAfterGivenValue()
        {
            var expectedOutputs = new List<int>() { 1, 2, 4, 3 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);

            LinkedListDS linkedList = GetLinkedList(writerMock);

            linkedList.AddNodeAfter(2, 4);

            linkedList.Result();
        }

        private LinkedListDS GetLinkedList(IConsoleWriter writerMock)
        {
            var linkedList = new LinkedListDS(writerMock);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            return linkedList;
        }


    }
}
