using System;

namespace R.Stivens_Algoritms
{
    /// <summary>
    /// Примечание: делать кучу на объектах сложно из-за поддержания правильной ссылочной структуры при перерасчете родитель\потомок.
    /// </summary>
    internal class HeapAsArray
    {
        public int[] Array { get; private set; } = new int[1];

        public void AddValue(int value)
        {
            if (TryAddValue(value))
            {
                return;
            }

            int[] newArray = Expand();

            newArray[Array.Length] = value;
            System.Array.Clear(Array, 0, Array.Length);

            Array = newArray;
            Sort();
        }

        public void RemoveTop()
        {
            Array[0] = 0;
            Sort();
        }

        /// <summary>
        /// Сортирует массив представляя в виде структуры куча(heap), где каждый дочерний элемент меньше или равен родительскому.
        /// </summary>
        private void Sort()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                int currentIndex = i;
                while (currentIndex != 0)
                {
                    int parentIndex = (currentIndex - 1) / 2;
                    int currentValue = Array[currentIndex];
                    int parrentValue = Array[parentIndex];

                    if (currentValue <= parrentValue)
                    {
                        break;
                    }

                    Swap(ref Array[currentIndex], ref Array[parentIndex]);
                    currentIndex = parentIndex;
                }
            }
        }

        private bool TryAddValue(int value)
        {
            bool result = false;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == 0)
                {
                    Array[i] = value;
                    result = true;
                    break;
                }
            }

            Sort();
            return result;
        }

        private int[] Expand()
        {
            int log = Math.Max(Convert.ToInt32(Math.Log2(Array.Length)), 1);
            int newCount = Convert.ToInt32(Math.Pow(2, log));

            int[] newArray = new int[Array.Length + newCount];
            System.Array.Copy(Array, newArray, Array.Length);
            return newArray;
        }

        private static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }
}
