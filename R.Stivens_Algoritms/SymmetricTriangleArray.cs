using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.Stivens_Algoritms
{
    class SymmetricTriangleArray
    {
        int[][] _array;

        public SymmetricTriangleArray(int n = 1)
        {
            _array = new int[n][];

            for(int i = 0; i < n; i++)
                _array[i] = new int[i + 1];
        }

        public int this[int row, int col]
        {
            get 
            {
                Rule(ref row, ref col);
                return _array[row][col]; 
            }

            set
            {
                Rule(ref row, ref col);
                _array[row][col] = value;
            }
        }

        private void Rule(ref int row, ref int col)
        {
            if(row >= _array.Length)
                throw new ArgumentException("");

            if(col > row)
            {
                int temp = row;
                row = col;
                col = temp;
            }
        }
    }
}
