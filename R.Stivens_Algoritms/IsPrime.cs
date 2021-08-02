using System;

namespace R.Stivens_Algoritms
{
    public static class IsPrime
    {
        //Посмотреть в сторону реализаций https://habr.com/ru/post/526924/
        public static bool Do(int p)
        {
            if(p % 2 == 0)
                return false;

            for(int sqrt = 3; sqrt <= Math.Sqrt(p); sqrt += 2)
                if(p % sqrt == 0)
                    return false;

            return true;
        }
    }
}
