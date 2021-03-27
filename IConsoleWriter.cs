using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public interface IConsoleWriter
    {
        void Write(string format);
        void WriteLine(string format);
        void WriteLine(int value);
    }

}
