using System;

namespace R.Stivens_Algoritms
{
    internal class HeapAsArray
    {
        /// <summary>
        /// Сортирует массив представляя в виде структуры куча(heap), где каждый дочерний элемент меньше или равен родительскому.
        /// </summary>
        /// <param name="array"></param>
        public static void SortArrayToHeapStructure(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int currentIndex = i;
                while (currentIndex != 0)
                {
                    int parentIndex = (currentIndex - 1) / 2;
                    int currentValue = array[currentIndex];
                    int parrentValue = array[parentIndex];

                    if (currentValue <= parrentValue)
                    {
                        break;
                    }

                    Swap(ref array[currentIndex],ref array[parentIndex]);
                    currentIndex = parentIndex;
                }
            }
        }

        public static void RemoveTop(int[] array)
        {
            int result = array[0];
            array[0] = -1;

            int index = 0;
            while (true)
            {
                int childIndex1 = index * 2 + 1;
                int childIndex2 = index * 2 + 2;

                if (childIndex1 > array.Length)
                {
                    childIndex1 = index;
                    childIndex2 = index;
                }
                else if(childIndex2 > array.Length)
                {
                    childIndex2 = index;
                }


                if (array[childIndex1] <= array[index] && array[childIndex2] <= array[index])
                {
                    break;
                }

                int swapIndex;
                if (array[childIndex1] > array[childIndex2])
                {
                    swapIndex = childIndex1;
                }
                else
                {
                    swapIndex = childIndex2;
                }

                Swap(ref array[index],ref array[swapIndex]);
                index = swapIndex;
            }
        }

        private static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }
}
