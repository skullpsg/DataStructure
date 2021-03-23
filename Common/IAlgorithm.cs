using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Common
{
    interface IAlgorithm<T>
    {
        T Recursion(T root);
        T NonRecursion(T root);
    }
}
