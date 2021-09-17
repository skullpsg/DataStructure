using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.StringAlgo.WordCountInPara
{
    [TestFixture]
    public class kMostFrequesntWordTest
    {
        [Test]
        public void ShouldReturnKMostPriorityQueue()
        {
            kMostFrequentWord kMostFrequentWord = new kMostFrequentWord(5);
            string para = "v s v s v a b c d d s f f f e f v s v v a";
            kMostFrequentWord.Load(para);
            kMostFrequentWord.Display();
        }
    }
}
