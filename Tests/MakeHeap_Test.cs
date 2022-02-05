
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class MakeHeap_Test
    {
        [TestMethod]
        public void MakeHeapFromArrayTest()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6 ,7,8,9,10,11,12,13,14 };
            HeapAsArray.SortArrayToHeapStructure(array);

            for (int i = array.Length - 1; i > 0; i--)
            {
                int parrentIndex = (i - 1) / 2;
                if (parrentIndex > 0)
                {
                    Assert.IsTrue(array[parrentIndex] >= array[i]);
                }
            }
        }
    }
}
