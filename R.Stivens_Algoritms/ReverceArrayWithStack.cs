using System.Collections.Generic;

namespace R.Stivens_Algoritms
{
    public static class ReverceArrayWithStack
    {
        public static char[] Do(char[] array)
        {
            Stack<char> stack = new Stack<char>(array.Length);

            foreach(char ch in array)
                stack.Push(ch);

            char[] result = new char[array.Length];

            for(int i = 0; i < result.Length; i++)
                result[i] = stack.Pop();

            return result;
        }
    }
}
