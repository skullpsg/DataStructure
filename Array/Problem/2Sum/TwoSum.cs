using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Array.Problem
{
    internal class TwoSum
    {
        public int[] GetSum(int[] nums, int target)
        {
            for (int index = 0; index < nums.Length; index++)
            {
                for (int secondIndex = index + 1; index < nums.Length; index++)
                {
                    if (nums[index] + nums[secondIndex] == target)
                    {
                        return new int[] { index, secondIndex };
                    }
                }
            }

            return null;
        }
    }
}
