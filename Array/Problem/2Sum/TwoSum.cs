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

        public int[] GetSumUsingHash(int[] nums, int target) {
            var ramainingsDict = new Dictionary<int, int>();
            for (int index = 0; index < nums.Count(); index++)
            {
                var current = nums[index];
                int remaining = target - nums[index];
                if (ramainingsDict.ContainsKey(current))
                {
                    int oldIndex = ramainingsDict[current];
                    return new int[] { oldIndex, index };
                }
                ramainingsDict.Add(remaining, index);
            }
            return null;
        }
    }
}
