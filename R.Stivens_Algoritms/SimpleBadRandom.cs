namespace R.Stivens_Algoritms
{
    public class SimpleBadRandom
    {
        private readonly int _from;
        private readonly int _to;
        public SimpleBadRandom(int from, int to)
        {
            _from = from;
            _to = to;
        }

        public int Do(int value)
        {
            return _from + value % (_to - _from + 1);
        }
    }
}
