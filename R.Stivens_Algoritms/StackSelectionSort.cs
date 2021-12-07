using System;
using System.Collections.Generic;

namespace R.Stivens_Algoritms
{
    public static class StackSelectionSort
    {
        public static Stack<int> Do(Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>(stack.Count);
            
            int lenght = stack.Count;
            int current_length = lenght;

            while (lenght > 0)
            {
                int min = stack.Peek();
                while (current_length > 0)
                {
                    int value = stack.Pop();
                    min = Math.Min(min, value);
                    temp.Push(value);
                    current_length--;
                }

                stack.Push(min);

                while (temp.TryPop(out int value) && value != min)
                { 
                    stack.Push(value);
                }

                while (temp.TryPop(out int value))
                {
                    stack.Push(value);
                }

                lenght -= 1;
                current_length = lenght;
            }
            return stack;
        }
    }
}
