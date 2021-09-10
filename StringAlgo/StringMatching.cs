using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.StringAlgo
{
    public class StringMatching
    {
        public int MatchInBruteForce(string str1, string str2)
        {
            if (str1 == null && str2 == null)
                return 0;

            for (int index = 0; index < str1.Length; index++)
            {
                int innerStringIndex = 0;
                while (innerStringIndex < str2.Length && str1[index + innerStringIndex] == str2[innerStringIndex])
                {
                    innerStringIndex++;
                }
                if (innerStringIndex == str2.Length)
                {
                    return index;
                }
            }

            return 0;
        }
    }
}
