using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;
using System;

namespace Tests
{
    [TestClass]
    public class FindPrime_Test
    {
        [TestMethod]
        public void FindPrimesOf_0_and_1()
        {
            int[] primes = Array.Empty<int>();

            CollectionAssert.AreEqual(primes, FindPrimeNumbers.Do(0));
            CollectionAssert.AreEqual(primes, FindPrimeNumbers.Do(1));
        }

        [TestMethod]
        public void FindPrimesOf199()
        {
            int[] primes = new int[] 
            {
                2,3,5,7,11,13,17,19,
                23,29,31,37,41,43,47,
                53,59,61,67,71,73,79,
                83,89,97,101,103,107,109,
                113,127,131,137,139,149,
                151,157,163,167,173,179,
                181,191,193,197,199
            };

            CollectionAssert.AreEqual(primes, FindPrimeNumbers.Do(199));
        }
    }
}
