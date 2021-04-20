using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Array.Problem.Sort3Digits
{
    public class Sort3Digits
    {
        private IConsoleWriter console;
        public Sort3Digits(IConsoleWriter console = null)
        {
            this.console = console;
        }

        public void Sort(int[] array)
        {
            if (array.Length == 0)
                return;

            void swap(int from, int to)
            {
                var temp = array[from];
                array[from] = array[to];
                array[to] = temp;
            }

            int low = 0;
            int mid = 0;
            int high = array.Length - 1;

            while (mid < high)
            {
                if (array[mid] > array[high])
                {
                    swap(mid++, high--);
                }
                else if (array[low] > array[mid])
                {
                    swap(low++, mid++);
                }
                else if (array[mid] == array[high])
                {
                    high--;
                }
                else
                {
                    mid++;
                }
            }
            Print(array);
        }

        private void Print(int[] array)
        {
            int i = 0;
            int length = array.Length - 1;
            while (i < length)
            {
                console.WriteLine(array[i]);
                i++;
            }
        }

    }
}
