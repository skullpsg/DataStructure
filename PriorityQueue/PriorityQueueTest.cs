using Datastructure.PriorityQueue.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.PriorityQueue
{
    [TestFixture]
    public class PriorityQueueTest
    {
        [Test]
        public void ShouldReturnMinValue()
        {
            var PriorityQueue = new PriorityQueue(Model.PriorityQueueType.MIN, 8);
            PriorityQueue.Enqueue(new PriorityQueueNode(7));
            PriorityQueue.Enqueue(new PriorityQueueNode(3));
            PriorityQueue.Enqueue(new PriorityQueueNode(9));
            PriorityQueue.Enqueue(new PriorityQueueNode(2));
            PriorityQueue.Enqueue(new PriorityQueueNode(6));
            PriorityQueue.Enqueue(new PriorityQueueNode(1));
            Assert.AreEqual(1, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(2, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(3, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(6, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(7, PriorityQueue.Dequeue().priority);
            Assert.AreEqual(9, PriorityQueue.Dequeue().priority);
        }
    }
}
