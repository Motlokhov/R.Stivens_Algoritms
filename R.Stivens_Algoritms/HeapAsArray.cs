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

        private static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }
}
