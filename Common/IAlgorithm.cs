using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Common
{
    interface IAlgorithm<TIn,TOut>
    {
        TOut Recursion(TIn root);
        TOut NonRecursion(TIn root);
    }
}
