using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigMath
{
    public class BigMath
    {
        public static int GreatestCommonDivisor(int int1, int int2)
        {
            int min = Math.Min(int1, int2);
            int max = Math.Max(int1, int2);
            for (int i = min - 1; i >= 2; i--)
            {
                if (min % i == 0 && max % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
