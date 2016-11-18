using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigMath
{
    public class BigMath
    {
        /// <summary>
        /// Evaluates the greatest common divisor.
        /// </summary>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Evaluates the least common multiple.
        /// </summary>
        /// <param name="int1"></param>
        /// <param name="int2"></param>
        /// <returns></returns>
        public static long LeastCommonMultiple(int int1, int int2)
        {
            int min = Math.Min(int1, int2);
            int max = Math.Max(int1, int2);
            long currentValue = min;
            while (true)
            {
                if (currentValue % max == 0)
                {
                    return currentValue;
                }
                currentValue += min;
            }
        }

        /// <summary>
        /// Evaluates wether a given integer is a prime or not.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPrime(int value)
        {
            for (int i = 2; i < ((int)Math.Sqrt(value))+1; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
