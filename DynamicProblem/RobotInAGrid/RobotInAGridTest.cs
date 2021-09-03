using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datastructure.DynamicProblem.RobotInAGrid.RobotInAGrid;

namespace Datastructure.DynamicProblem.RobotInAGrid
{
    [TestFixture]
    class RobotInAGridTest
    {
        [Test]
        public void ShouldPrintPath()
        {
            char[,] matrix = {
        // 0   1   2   
        { '0','n','0' }, // 0
        { '0','n','n' }, // 1
        { '0','0','0' }, // 2
    }; // [8, 12]

            RobotInAGrid grid = new RobotInAGrid();
            grid.FindPath(matrix, 2, 2, new Dictionary<Path, bool>());
        }

    }
}
