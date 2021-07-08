namespace R.Stivens_Algoritms
{
    public class FindLargesWithinArray
    {
        public static int Do(int[] array) // 1 + (N + N + N) + 1 = 2 + 3N = 2 + 3(N)
        {
            int largest = array[0]; // 0(1)
            for(int index = 1; index < array.Length; index++)//O(N)
                if(array[index] > largest)// O(N)
                    largest = array[index]; // O(N)
            return largest;// O(1)
        }
    }
}
