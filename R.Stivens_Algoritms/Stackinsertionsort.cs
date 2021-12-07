using System.Collections.Generic;

namespace R.Stivens_Algoritms
{
    public static class Stackinsertionsort
    {
        public static Stack<int> Do(Stack<int> stack)
        {
            Stack<int> result = new();
            Stack<int> temp = new();

            while(stack.TryPop(out int next_item))
            {
                bool inserted = false;
                while(result.TryPeek(out int result_item))
                {
                    if(result_item > next_item )
                    {
                        result.Push(next_item);
                        inserted = true;
                        break;
                    }
                    temp.Push(result.Pop());
                }

                if (!inserted)
                {
                    result.Push(next_item);
                }

                while (temp.TryPop(out int temp_item))
                    result.Push(temp_item);
            }

            return result;
        }
    }
}
