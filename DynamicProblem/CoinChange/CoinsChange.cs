using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.DynamicProblem
{
    public class CoinsChange
    {
   
        int[,] cache = new int[6,6];

        // O( amount * index)
        public int GetChangePossibilities(int amount,int index, int[] coins){
            if (cache[amount, index] > 0) {
                return cache[amount, index];
            }
            int paths = 0;
            if (amount == 0)
            {
                return 1;
            }

            if (index >= coins.Length)
                return 0;
            for (int loopCount = 0; loopCount * coins[index] <= amount; loopCount++) {
                paths += GetChangePossibilities(amount - (loopCount * coins[index]), index + 1, coins);
             }
            cache[amount, index]= paths;
            return paths;
        }
    }
}
