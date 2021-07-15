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

        [TestMethod]
        public void Raise_7_ToPower_7_AreEqual_823_543()
        {
            Assert.AreEqual(RaiseToPower.Do(7, 7), 823_543);
        }

        [TestMethod]
        public void Raise_7_ToPower_8_AreEqual_5_764_801()
        {
            Assert.AreEqual(RaiseToPower.Do(7, 8), 5_764_801);
        }

        [TestMethod]
        public void Raise_Negative_7_ToPower_7_AreEqual_Negative_823_543()
        {
            Assert.AreEqual(RaiseToPower.Do(-7, 7), -823_543);
        }

        [TestMethod]
        public void Raise_0_ToPower_0_AreEqual_1()
        {
            Assert.AreEqual(RaiseToPower.Do(0, 0),1);
        }

        [TestMethod]
        public void Raise_0_ToAnyPowerGreaterThen_0_AreEqualZero()
        {
            Assert.AreEqual(RaiseToPower.Do(0, 7), 0);
        }
    }
}
