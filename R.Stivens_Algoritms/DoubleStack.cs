using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.Stivens_Algoritms
{
    public class DoubleStack
    {
        private string[] _data;
        private int _leftIndex, _rightIndex;
        private int leftBorder { get => -1; }
        private int rightBorder { get => _data.Length; }
        public DoubleStack(int length)
        {
            _data = new string[length];
            _leftIndex = leftBorder;
            _rightIndex = rightBorder;
        }

        public void PushLeft(string value)
        {
            CheckIndexesForIntersection();
            _data[++_leftIndex] = value;
        }

        public string PopLeft()
        {
            if(_leftIndex == leftBorder)
                throw new ArgumentException();
            return _data[_leftIndex--];
        }

        public void PushRight(string value)
        {
            CheckIndexesForIntersection();
            _data[--_rightIndex] = value;
        }

        public string PopRight()
        {
            if(_rightIndex == rightBorder)
                throw new ArgumentException();
            return _data[_rightIndex++];
        }

        private void CheckIndexesForIntersection()
        {
            if(_rightIndex - _leftIndex == 1)
                throw new ArgumentException();
        }
    }
}
