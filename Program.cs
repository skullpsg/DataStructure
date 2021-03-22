using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructure.LinkedList;

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var list= new LinkedListDS();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Reverse();
            list.Result();
            Console.WriteLine("completed");
        }
    }
}
