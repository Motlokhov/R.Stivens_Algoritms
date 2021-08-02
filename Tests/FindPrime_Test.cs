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

        [TestMethod]
        public void PrimeFrom83to109()
        {
            Assert.IsTrue(IsPrime.Do(83));
            Assert.IsTrue(IsPrime.Do(89));
            Assert.IsTrue(IsPrime.Do(97));
            Assert.IsTrue(IsPrime.Do(101));
            Assert.IsTrue(IsPrime.Do(103));
            Assert.IsTrue(IsPrime.Do(107));
            Assert.IsTrue(IsPrime.Do(109));
        }

        [TestMethod]
        public void NotPrimeFrom80to90()
        {
            Assert.IsFalse(IsPrime.Do(80));
            Assert.IsFalse(IsPrime.Do(81));
            Assert.IsFalse(IsPrime.Do(82));
            Assert.IsFalse(IsPrime.Do(84));
            Assert.IsFalse(IsPrime.Do(85));
            Assert.IsFalse(IsPrime.Do(86));
            Assert.IsFalse(IsPrime.Do(88));
            Assert.IsFalse(IsPrime.Do(90));

        }
    }
}
