using System;

namespace R.Stivens_Algoritms
{
    public static class ArrayExtensionAlgorithm
    {
        private static void Swap(ref int left,ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        public static void InsertionSort(this int[] array, bool asc = true)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }

            static bool ascSort(int @new, int sorted) => @new < sorted;
            static bool descSort(int @new, int sorted) => @new > sorted;
            Func<int, int, bool> sort = asc ? ascSort : descSort;

            for (int index = 0; index < array.Length; index++)
            {
                for (int sortedIndex = index - 1; sortedIndex >= 0; sortedIndex--)
                {
                    int newIndex = sortedIndex + 1;
                    if (sort(array[newIndex], array[sortedIndex]))
                    {
                        Swap(ref array[newIndex], ref array[sortedIndex]);
                    }
                }
            }
        }
    }
}
