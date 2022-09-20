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
            int insertionIndex = Array.Length;
            newArray[insertionIndex] = value;

            Array = newArray;
            SiftUp(insertionIndex);
        }

        public void RemoveTop()
        {
            Array[0] = 0;
            SiftDown();
        }

        /// <summary>
        /// Двигает элемент вниз по правилам структуры (max - heap).
        /// </summary>
        private void SiftDown()
        {
            int parentIndex = 0;
            while (true)
            {
                int leftIndex = parentIndex * 2 + 1;
                int rightIndex = parentIndex * 2 + 2;

                if (Array.Length <= rightIndex)
                {
                    break;
                }

                int childIndex = leftIndex;

                if (Array[rightIndex] > Array[leftIndex])
                {
                    childIndex = rightIndex;
                }

                if (Array[childIndex] > Array[parentIndex])
                {
                    Swap(ref Array[childIndex], ref Array[parentIndex]);
                    parentIndex = childIndex;
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Двигает элемент вверх по правилам структуры (max - heap)
        /// </summary>
        /// <param name="childIndex"></param>
        private void SiftUp(int childIndex)
        {
            if (childIndex == 0)
            {
                return;
            }

            int parentIndex = ParentIndex(childIndex);
            if (Array[childIndex] > Array[parentIndex])
            {
                Swap(ref Array[childIndex], ref Array[parentIndex]);
                SiftUp(parentIndex);
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
                    SiftUp(i);
                    break;
                }
            }

            return result;
        }

        private int[] Expand()
        {
            int log = Math.Max(Height, 1);
            int newCount = Convert.ToInt32(Math.Pow(2, log));

            int[] newArray = new int[Array.Length + newCount];
            System.Array.Copy(Array, newArray, Array.Length);
            return newArray;
        }

        private int Height => Convert.ToInt32(Math.Log2(Array.Length));

        private static int ParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }
}
