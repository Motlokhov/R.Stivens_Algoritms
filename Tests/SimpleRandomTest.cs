using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class SimpleRandomTest
    {
        [TestMethod]
        public void SimpleBadRandomTest()
        {
            SimpleBadRandom random = new(0, 1);
            int[] values = new int[100];

            for(int i = 0; i < 100; i++)
                values[i] = random.Do(i);

            //тут предсказуемость значений четные дают 0 нечетные 1
            Assert.AreEqual(values.Count(_ => _ == 1),values.Count(_ => _ == 0));
        }

        [TestMethod]
        public void RandomArrayTest()
        {
            int[] newArray = RandomizeArray.Do(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
        }

        [TestMethod]
        public void TwoDiceSimulatorTest()
        {
            int value = TwoDiceSimulator.Do();
            Assert.IsTrue(value >= 2);
            Assert.IsTrue(value <= 12);
        }
    }
}
