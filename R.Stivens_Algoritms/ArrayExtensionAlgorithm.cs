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

        private static bool IsArrayValid(int[] array)
        {
            return array != null && array.Length > 2;
        }

        private static bool AscSort(int @new, int sorted) => @new < sorted;
        private static bool DescSort(int @new, int sorted) => @new > sorted;
        private static Func<int,int, bool>SortStrategy(bool asc) => asc? AscSort : DescSort;

        public static void InsertionSort(this int[] array, bool asc = true)
        {
            if (!IsArrayValid(array))
            {
                return;
            }

            Func<int, int, bool> sortStrategy = SortStrategy(asc);

            for (int index = 0; index < array.Length; index++)
            {
                for (int sortedIndex = index - 1; sortedIndex >= 0; sortedIndex--)
                {
                    int newIndex = sortedIndex + 1;
                    if (sortStrategy(array[newIndex], array[sortedIndex]))
                    {
                        Swap(ref array[newIndex], ref array[sortedIndex]);
                    }
                }
            }
        }

        public static void SelectionSort(this int[] array, bool asc = true)
        {
            if (!IsArrayValid(array))
            {
                return;
            }

            Func<int, int, bool> sortStrategy = SortStrategy(asc);

            for (int currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                int currentValue = array[currentIndex];
                int newIndex = currentIndex;

                for (int notSortedIndex = currentIndex; notSortedIndex < array.Length; notSortedIndex++)
                {
                    if (sortStrategy(array[notSortedIndex], currentValue))
                    {
                        currentValue = array[notSortedIndex];
                        newIndex = notSortedIndex;
                    }
                }

                Swap(ref array[newIndex], ref array[currentIndex]);
            }
        }

        public static void BubbleSort(this int[] array, bool asc = true)
        {
            if (!IsArrayValid(array))
            {
                return;
            }

            Func<int, int, bool> sortStrategy = SortStrategy(asc);

            bool sorted;

            do
            {
                sorted = true;
                for (int index = 1; index < array.Length; index++)
                {
                    int previousIndex = index - 1;
                    if (sortStrategy(array[index], array[previousIndex]))
                    {
                        Swap(ref array[index], ref array[previousIndex]);
                        sorted = false;
                    }
                }
            } while (!sorted);
        }
    }
}
