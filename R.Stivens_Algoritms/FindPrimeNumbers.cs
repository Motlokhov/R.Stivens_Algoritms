using System;
using System.Collections.Generic;

namespace R.Stivens_Algoritms
{
    public static class FindPrimeNumbers
    {
        public static int[] Do(int maxNumber)
        {
            bool[] isComplex = new bool[maxNumber + 1];

            for(int factor = 4; factor <= maxNumber; factor += 2)
                isComplex[factor] = true;

            // Первых шаг берем квадрат модификатора, так как все числа до квадарата модификатора уже помечены
            // каждый следующий шаг берем сумму двух модификаторов так как большинство уже закрыто. (редко встречаются уже помеченные)
            // возможно можно вычислить зависимость которая не будет помечать уже помеченные числа
            for(int factor = 3; factor <= Math.Sqrt(maxNumber); factor += 2)
                for(int number = factor * factor; number <= maxNumber; number += factor * 2)
                    isComplex[number] = true;

            var list = new List<int>(maxNumber / 4);

            for(int number = 2; number <= maxNumber; number++)
                if(isComplex[number] is false)
                    list.Add(number);

            return list.ToArray();
        }
    }
}
