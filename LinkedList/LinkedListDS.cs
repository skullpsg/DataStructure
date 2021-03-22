using Datastructure.LinkedList.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.LinkedList
{

    public class LinkedListDS
    {
        public LinkedListNode FirstNode = null;
        public LinkedListNode LastNode = null;
        public IConsoleWriter console = null;
        public LinkedListDS(IConsoleWriter console = null)
        {
            this.console = console;
        }

        public LinkedListDS Add(int Value)
        {
            var CurrentNode = LinkedListNode.create(Value);

            if (FirstNode == null)
            {
                FirstNode = CurrentNode;
            }
            else
            {
                LastNode.Next = CurrentNode;
            }
            LastNode = CurrentNode;

            return this;
        }

        public void Result()
        {
            var CurrentNode = FirstNode;
            while (CurrentNode != null)
            {
                PrintNode(CurrentNode);
                CurrentNode = CurrentNode.Next;
            }
        }

        private void PrintNode(LinkedListNode node)
        {
            if (console != null)
                console.WriteLine(node.Value);
            else
                System.Console.Out.WriteLine(node.Value);
        }

        public void Reverse()
        {
            LinkedListNode temp = null;
            LinkedListNode next = null;
            var CurrentNode = FirstNode;
            while (CurrentNode != null)
            {
                next = CurrentNode.Next;
                CurrentNode.Next = temp;
                temp = CurrentNode;
                CurrentNode = next;
            }
            FirstNode = temp;
        }

        public bool AddNodeAfter(int value, int valueToAdd)
        {
            var newNode = LinkedListNode.create(valueToAdd);
            var expectedNode = GetNode(value);
            if (expectedNode == null)
            {
                return false;
            }
            newNode.Next = expectedNode.Next;
            expectedNode.Next = newNode;
            return true;
        }

        private LinkedListNode GetNode(int NodeValue)
        {
            var CurrentNode = FirstNode;
            while (CurrentNode != null)
            {
                if (CurrentNode.Value == NodeValue)
                {
                    return CurrentNode;
                }

                CurrentNode = CurrentNode.Next;
            }
            return null;
        }


    }

}

