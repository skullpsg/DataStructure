using System.Collections.Generic;

namespace Datastructure.DynamicProblem.StairCase
{
    public class StairCase
    {
        public int GetPossibilities(int NoOfSteps, Dictionary<int, int> cache)
        {

            if (NoOfSteps < 0)
            {
                return 0;
            }
            if (cache.ContainsKey(NoOfSteps))
            {
                return cache[NoOfSteps];
            }

            if (NoOfSteps == 0)
            {
                return 1;
            }
            int result = GetPossibilities(NoOfSteps - 1,cache) + GetPossibilities(NoOfSteps - 2,cache) + GetPossibilities(NoOfSteps - 3,cache);
            cache.Add(NoOfSteps, result);
            return result;
        }
    }
}
