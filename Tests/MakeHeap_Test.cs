
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class MakeHeap_Test
    {
        [TestMethod]
        public void AddValueTest()
        {
            HeapAsArray heap = new();
            heap.AddValue(0);
            heap.AddValue(1);
            heap.AddValue(2);
            heap.AddValue(3);
            heap.AddValue(4);
            heap.AddValue(5);
            heap.AddValue(6);
            heap.AddValue(7);
            heap.AddValue(8);
            heap.AddValue(9);
            heap.AddValue(10);
            heap.AddValue(11);
            heap.AddValue(12);
            heap.AddValue(13);
            heap.AddValue(14);

            for (int i = heap.Array.Length - 1; i > 0; i--)
            {
                int parrentIndex = (i - 1) / 2;
                if (parrentIndex > 0)
                {
                    Assert.IsTrue(heap.Array[parrentIndex] >= heap.Array[i]);
                }
            }
        }

        [TestMethod]
        [DataRow(new int[] { 5, 3, 1, 3, 2 })]
        [DataRow(new int[] { 14, 9, 13, 6, 8, 10, 12, 0, 3, 2, 7, 1, 5, 4, 11 })]
        public void RemoveTopFromHeapTest(int[] array)
        {
            HeapAsArray heap = new();

            for (int i = 0; i < array.Length; i++)
            {
                heap.AddValue(array[i]);
            }

            heap.RemoveTop();

            for (int i = heap.Array.Length - 1; i > 0; i--)
            {
                int parrentIndex = (i - 1) / 2;
                if (parrentIndex > 0)
                {
                    Assert.IsTrue(heap.Array[parrentIndex] >= heap.Array[i]);
                }
            }
        }
    }
}
