using System;
using System.Collections.Generic;

namespace R.Stivens_Algoritms
{
    public static class FindFactors
    {
        public static int[] Do(int number)
        {
            List<int> factors = new();
            for(int factor = 2; factor <= (int)Math.Sqrt(number); factor++)
            {
                while(number % factor == 0)
                {
                    number /= factor;
                    factors.Add(factor);
                }
            }
            if(number > 1)
                factors.Add(number);
            return factors.ToArray();
        }
    }
}
