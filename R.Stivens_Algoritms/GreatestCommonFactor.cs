namespace R.Stivens_Algoritms
{
    //Наибольший общий делитель (алгоритм Евклида)
    public static class GreatestCommonFactor
    {
        public static int Do(int first, int second)
        {
            while(second != 0)
            {
                int remainder = first % second;
                first = second;
                second = remainder;
            }
            return first;
        }
    }
}
