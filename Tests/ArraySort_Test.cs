using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;

namespace Tests
{
    [TestClass]
    public class ArraySort_Test
    {
        [TestMethod]
        public void InsertionSortAscTest()
        {
            int[] array = new[] { 10, 2, 1, 5, 3, 4, 1, 3 };
            array.InsertionSort();

            CollectionAssert.AreEqual(new[] { 1, 1, 2, 3, 3, 4, 5, 10 }, array);
        }

        [TestMethod]
        public void InsertionSortDescTest()
        {
            int[] array = new[] { 10, 2, 1, 5, 3, 4, 1, 3 };
            array.InsertionSort(false);

            CollectionAssert.AreEqual(new[] { 10, 5, 4, 3, 3, 2, 1, 1 }, array);
        }

        [TestMethod]
        public void SelectionSortAscTest()
        {
            int[] array = new[] { 10, 2, 1, 5, 3, 4, 1, 3 };
            array.SelectionSort();

            CollectionAssert.AreEqual(new[] { 1, 1, 2, 3, 3, 4, 5, 10 }, array);
        }

        [TestMethod]
        public void SelectionSortDescTest()
        {
            int[] array = new[] { 10, 2, 1, 5, 3, 4, 1, 3 };
            array.SelectionSort(false);

            CollectionAssert.AreEqual(new[] { 10, 5, 4, 3, 3, 2, 1, 1 }, array);
        }
    }
}
