using System;

namespace R.Stivens_Algoritms
{
    /// <summary>
    /// Неравномерное распределение
    /// </summary>
    public class TwoDiceSimulator
    {
        const int minDiceValue = 1;
        const int maxDiceValue = 6;

        public static int Do()
        {
            Random random = new();
            return random.Next(minDiceValue, maxDiceValue) + random.Next(minDiceValue, maxDiceValue);
        }
    }
}
