using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    class Multiplier
    {
        private int A, B;

        int[] arrA, arrB;

        public Multiplier(int A, int B)
        {
            this.A = A;
            this.B = B;
            arrA = new int[32];
            arrB = new int[32];
            NumUtils.DecToBinArray(A).CopyTo(arrA, 0);
            NumUtils.DecToBinArray(B).CopyTo(arrB, 0);
        }

        internal void Multiply()
        {
            throw new NotImplementedException();
        }
    }
}
