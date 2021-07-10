using System;

namespace R.Stivens_Algoritms
{
    /// <summary>
    /// Равномерное распределение
    /// </summary>
    public class RandomizeArray
    {
        public static int[] Do(int[] array)
        {
            int maxIndex = array.Length;
            int[] resultArray = new int[maxIndex];
            array.CopyTo(resultArray, 0);
            Random random = new();

            for (int index = 0; index < maxIndex; index++)
            {
                int randomIndex = random.Next(0, maxIndex);
                int value = array[index];
                int valueFromRandomIndex = array[randomIndex];
                array[randomIndex] = value;
                array[index] = valueFromRandomIndex;
            }
            return array;
        }
    }
}
