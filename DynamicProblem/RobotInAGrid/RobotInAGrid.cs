using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.DynamicProblem.RobotInAGrid
{
    public class RobotInAGrid
    {
        public class Path : IEquatable<Path>
        {
            public Path(int row, int col)
            {
                this.row = row;
                this.column = col;
            }
            public int row;
            public int column;

            public override bool Equals(object obj) => this.Equals(obj as Path);

            public bool Equals(Path p)
            {
                if (p is null)
                {
                    return false;
                }

                // Optimization for a common success case.
                if (Object.ReferenceEquals(this, p))
                {
                    return true;
                }
                if (this.GetType() != p.GetType())
                {
                    return false;
                }

                // Return true if the fields match.
                // Note that the base class is not invoked because it is
                // System.Object, which defines Equals as reference equality.
                return (row == p.row) && (column == p.column);
            }

            public override int GetHashCode() => (row, column).GetHashCode();

            public static bool operator ==(Path lhs, Path rhs)
            {
                if (lhs is null)
                {
                    if (rhs is null)
                    {
                        return true;
                    }

                    // Only the left side is null.
                    return false;
                }
                // Equals handles case of null on right side.
                return lhs.Equals(rhs);
            }

            public static bool operator !=(Path lhs, Path rhs) => !(lhs == rhs);

        }

        // Time and space -> O(Row * Col)
        public Boolean FindPath(char[,] grid, int row, int col, Dictionary<Path, Boolean> cache)
        {

            if (row < 0 || col < 0)
                return false;

            var path = new Path(row, col);

            if (cache.ContainsKey(path))
            {
                return cache[path];
            }

            if (row == 0 && col == 0)
            {
                return true;
            }
            var result = false;
            if (isValid(grid, row, col) || (row == grid.Rank && col == grid.GetLength(0)-1))
            {
                result = FindPath(grid, row - 1, col, cache) || FindPath(grid, row, col - 1, cache);
                if (result)
                {
                    Console.WriteLine($"Row: {row}, col: {col}");               
                }
            }
            cache.Add(path, result);
            return result;
        }

        private bool isValid(char[,] grid, int row, int col)
        {
            if (grid[row, col] == 'n')
                return true;
            return false;
        }
    }
}
