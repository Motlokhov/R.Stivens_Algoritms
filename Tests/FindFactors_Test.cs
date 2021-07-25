using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;

namespace Tests
{
    [TestClass]
    public class FindFactors_Test
    {
        [TestMethod]
        public void FindFactors144()
        {
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 3, 3 }, FindFactors.Do(144));
        }

        [TestMethod]
        public void FindFactors128()
        {
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2, 2, 2, 2 }, FindFactors.Do(128));
        }

        [TestMethod]
        public void FindFactors127()
        {
            CollectionAssert.AreEqual(new int[] { 127 }, FindFactors.Do(127));
        }
    }
}
