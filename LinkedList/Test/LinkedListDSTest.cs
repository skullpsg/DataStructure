using Moq;
using NUnit.Framework;

namespace Datastructure.LinkedList.Test
{

    [TestFixture]
    public class LinkedListDSTest
    {

        [Test]
        public void LinkedListDSPrint()
        {

            var seq = new MockSequence();


            var writerMock = new Mock<IConsoleWriter>(MockBehavior.Strict);
            LinkedListDS linkedList = new LinkedListDS(writerMock.Object);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            writerMock.InSequence(seq).Setup(m => m.WriteLine(1));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(2));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(3));

            linkedList.Result();
        }


        [Test]
        public void Reverse()
        {

            var seq = new MockSequence();


            var writerMock = new Mock<IConsoleWriter>(MockBehavior.Strict);
            LinkedListDS linkedList = new LinkedListDS(writerMock.Object);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            linkedList.Reverse();

            writerMock.InSequence(seq).Setup(m => m.WriteLine(3));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(2));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(1));

            linkedList.Result();
        }


        [Test]
        public void AddAfterSomeNode()
        {

            var seq = new MockSequence();


            var writerMock = new Mock<IConsoleWriter>(MockBehavior.Strict);
            LinkedListDS linkedList = new LinkedListDS(writerMock.Object);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            linkedList.AddNodeAfter(2,4);

            writerMock.InSequence(seq).Setup(m => m.WriteLine(1));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(2));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(4));
            writerMock.InSequence(seq).Setup(m => m.WriteLine(3));

            linkedList.Result();
        }


    }
}
