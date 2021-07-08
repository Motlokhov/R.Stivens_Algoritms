using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;

namespace Tests
{
    [TestClass]
    public class FindLargest_Test
    {
        [TestMethod]
        public void LargestFirst()
        {
            Assert.AreEqual(100,FindLargesWithinArray.Do(new[] { 100, 1, 2, 3, 4, 5, 6, 7, 8 }));
        }

        [TestMethod]
        public void LargestLast()
        {
            Assert.AreEqual(100, FindLargesWithinArray.Do(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 100 }));
        }
    }
}
