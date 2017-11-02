using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixArrayZero
{
    class MatrixArray
    {
        public int[,] MtxArr { get; set; }

        public MatrixArray(int length, int width)
        {
            MtxArr = new int[length, width];
        }
    }
}
