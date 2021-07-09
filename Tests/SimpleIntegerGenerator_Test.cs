using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;

namespace Tests
{
    [TestClass]
    public class SimpleIntegerGenerator_Test
    {
        [TestMethod]
        public void SimpleIntegerGeneratorRun()
        {
            SimpleIntegerGenerator random = new(0);
            Assert.AreEqual(5, random.Do());
            Assert.AreEqual(7, random.Do());
            Assert.AreEqual(10, random.Do());
            Assert.AreEqual(9, random.Do());
            Assert.AreEqual(2, random.Do());
            Assert.AreEqual(8, random.Do());
            Assert.AreEqual(6, random.Do());
            Assert.AreEqual(3, random.Do());
            Assert.AreEqual(4, random.Do());
            Assert.AreEqual(0, random.Do());
        }
    }
}
