using Datastructure.PriorityQueueNS.Model;
using NUnit.Framework;

namespace Datastructure.PriorityQueueNS
{
    [TestFixture]
    public class PriorityQueueTest
    {
        [Test]
        public void ShouldReturnMinValue()
        {
            var PriorityQueue = new PriorityQueue<PriorityQueueNode<int>, int>(Model.PriorityQueueType.MIN, 8);
            PriorityQueue.Enqueue(new PriorityQueueNode<int>(7));
            PriorityQueue.Enqueue(new PriorityQueueNode<int>(3));
            PriorityQueue.Enqueue(new PriorityQueueNode<int>(9));
            PriorityQueue.Enqueue(new PriorityQueueNode<int>(2));
            PriorityQueue.Enqueue(new PriorityQueueNode<int>(6));
            PriorityQueue.Enqueue(new PriorityQueueNode<int>(1));
            Assert.AreEqual(1, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(2, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(3, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(6, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(7, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(9, PriorityQueue.Dequeue().priority);
        }
    }
}
