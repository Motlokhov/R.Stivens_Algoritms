using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;

namespace Tests
{
    [TestClass]
    public class IntegerAlgorithm_Test
    {
        [TestMethod]
        public void GCF_Test()
        {
            Assert.AreEqual(GreatestCommonFactor.Do(4851, 3003), 231);
        }

        [TestMethod]
        public void GCF_Test_Invert()
        {
            Assert.AreEqual(GreatestCommonFactor.Do(3003, 4851), 231);
        }
    }
}
