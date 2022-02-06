
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
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
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

        [TestMethod]
        [DataRow(new int[] { 5, 3, 1, 3, 2 }, new int[] { 3, 3, 1, -1, 2 })]
        [DataRow(new int[] { 14, 9, 13, 6, 8, 10, 12, 0, 3, 2, 7, 1, 5, 4, 11 }, new int[] { 13, 9, 12, 6, 8, 10, 11, 0, 3, 2, 7, 1, 5, 4, -1 })]
        public void RemoveTopHeapTest(int[] array, int[] expected)
        {
            HeapAsArray.RemoveTop(array);
            CollectionAssert.AreEqual(array, expected);
        }
    }
}
