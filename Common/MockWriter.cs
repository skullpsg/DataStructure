using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Common
{
    public class MockWriter
    {
        public static IConsoleWriter GetInstance(List<int> expectedOutputs)
        {
            var writerMock = new Mock<IConsoleWriter>(MockBehavior.Strict);
            var seq = new MockSequence();
            foreach (var expectedOutput in expectedOutputs)
            {
                writerMock.InSequence(seq).Setup(m => m.WriteLine(expectedOutput));
            }
            return writerMock.Object;
        }
        public static IConsoleWriter GetInstanceForString(List<String> expectedOutputs)
        {
            var writerMock = new Mock<IConsoleWriter>(MockBehavior.Strict);
            var seq = new MockSequence();
            foreach (var expectedOutput in expectedOutputs)
            {
                writerMock.InSequence(seq).Setup(m => m.WriteLine(expectedOutput));
            }
            return writerMock.Object;
        }
    }
}
