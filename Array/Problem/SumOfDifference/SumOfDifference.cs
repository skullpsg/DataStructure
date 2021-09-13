using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Array.Problem.SumOfDifference
{
    public class SumOfDifference
    {

        public int Sum(int[] arr)
        {
            int result = 0;
            int indexToAdd = 0;
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (indexToAdd == i)
                {
                    result += arr[i];
                    indexToAdd += count;
                    count++;
                }
                else
                {
                    result -= arr[i];
                }
            }
            return result;
        }
    }
}
