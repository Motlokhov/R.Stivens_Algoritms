namespace R.Stivens_Algoritms
{
    public class SimpleIntegerGenerator
    {
        private const int A = 7;
        private const int B = 5;
        private const int MOD = 11;
        private int _last;

        /// <summary>
        /// Реализация простого ГПСЧ(линейный конгруэнтный генератор)[Повторяемый]
        /// </summary>
        /// <param name="from">Начальное значение</param>
        public SimpleIntegerGenerator(int from)
        {
            _last = from; 
        }

        public int Do()
        {
            _last = (A * _last + B) % MOD;
            return _last;
        }
    }
}
