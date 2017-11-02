using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixRotation
{
    class Matrix
    {
        public int[,] MtxArr { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public Matrix(int width, int depth)
        {
            MtxArr = new int[width, depth];
            Width = width;
            Depth = depth;
        }
    }
}
